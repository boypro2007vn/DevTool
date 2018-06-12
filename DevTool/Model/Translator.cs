using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using DevTool.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DevTool.Model
{
    /// <summary>
    /// Translates text using Google's online language tools.
    /// </summary>
    public class Translator
    {
        #region Private Variable

        /// <summary>
        /// The language to translation mode map.
        /// </summary>
        private static Dictionary<string, string> _languageList;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the supported languages.
        /// </summary>
        public static Dictionary<string,string> Languages {
            get
            {
                EnsureInitialized();
                return _languageList;
            }
        }

        /// <summary>
        /// Gets source language
        /// </summary>
        public string SourceLanguage
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets translation language
        /// </summary>
        public string TranslationLanguage
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the time taken to perform the translation.
        /// </summary>
        public TimeSpan TranslationTime
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the url translation.
        /// </summary>
        /// <value>The url used to speak the translation.</value>
        public string TranslationhUrl
        {
            get;
            private set;
        }

        /// <summary>
        /// Base language text
        /// </summary>
        public string TranslationSourceText
        {
            get;
            private set;
        }

        /// <summary>
        /// Text result after translation
        /// </summary>
        public string TranslationResultText
        {
            get;
            private set;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Translates the specified source text.
        /// </summary>
        /// <param name="sourceText">The source text.</param>
        /// <param name="sourceLanguage">The source language.</param>
        /// <param name="targetLanguage">The target language.</param>
        /// <returns>The translation.</returns>
        public void Translate
            (string sourceText,
             string sourceLanguage,
             string targetLanguage)
        {
            // Initialize
            DateTime tmStart = DateTime.Now;
            this.TranslationTime = TimeSpan.Zero;
            this.SourceLanguage = sourceLanguage;
            this.TranslationLanguage = targetLanguage;
            this.TranslationSourceText = sourceText;
            this.TranslationResultText = String.Empty;
            this.TranslationhUrl =
                string.Format(format: Resources.UrlTranslate, 
                                arg0: HttpUtility.UrlEncode(this.TranslationSourceText), 
                                arg1: this.SourceLanguage, 
                                arg2: this.TranslationLanguage);

            string outputFile = String.Empty;
            try
            {
                // Download translation
                string translationFileUrl =
                    string.Format(format: Resources.UrlFileTranslate, 
                                    arg0: this.SourceLanguage, 
                                    arg1: this.TranslationLanguage,
                                    arg2: HttpUtility.UrlEncode(this.TranslationSourceText));

                outputFile = Path.GetTempFileName();
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("user-agent",
                        "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                    wc.DownloadFile(translationFileUrl, outputFile);
                }

                // Get translated text
                if (File.Exists(outputFile))
                {

                    // Get phrase collection
                    string text = File.ReadAllText(outputFile);
                    int index = text.IndexOf($",,\"{sourceLanguage}\"", StringComparison.Ordinal);
                    if (index == -1)
                    {
                        // Get translate text
                        Object[] jsonObjs = JsonConvert.DeserializeObject<Object[]>(text);
                        JArray jsonTrans = (JArray)jsonObjs[0];
                        StringBuilder resultTrans = new StringBuilder();
                        foreach (var items in jsonTrans)
                        {
                            resultTrans.Append(items[0]);
                        }

                        text = resultTrans.ToString();
                    }
                    else
                    {
                        // Translation of phrase
                        text = text.Substring(0, index);
                        text = text.Replace("],[", ",");
                        text = text.Replace("]", string.Empty);
                        text = text.Replace("[", string.Empty);
                        text = text.Replace("\",\"", "\"");

                        // Get translated phrases
                        string[] phrases = text.Split(new[] {'\"'}, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; (i < phrases.Count()); i += 2)
                        {
                            string translatedPhrase = phrases[i];
                            if (translatedPhrase.StartsWith(",,"))
                            {
                                i--;
                                continue;
                            }

                            this.TranslationResultText += translatedPhrase + "  ";
                        }
                    }

                    // Fix up translation
                    this.TranslationResultText = text.Trim();
                    this.TranslationResultText = this.TranslationResultText.Replace(" ?", "?");
                    this.TranslationResultText = this.TranslationResultText.Replace(" !", "!");
                    this.TranslationResultText = this.TranslationResultText.Replace(" ,", ",");
                    this.TranslationResultText = this.TranslationResultText.Replace(" .", ".");
                    this.TranslationResultText = this.TranslationResultText.Replace(" ;", ";");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (File.Exists(outputFile))
                {
                    File.Delete(outputFile);
                }
            }

            // Return result
            this.TranslationTime = DateTime.Now - tmStart;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Get link speech
        /// </summary>
        /// <param name="vTrans">source text</param>
        /// <param name="vLanguage">language for speech</param>
        /// <param name="vfileName">name of audio file</param>
        /// <returns>
        ///     Return src file if not error
        ///     Return the full url to get online if error
        /// </returns>
        public string GetFileTranslationSpeechUrl(string vTrans, string vLanguage, string vfileName)
        {
            string speechStringUrl = string.Format(format: Resources.UrlSpeechTranslate, 
                                                    arg0: HttpUtility.UrlEncode(Regex.Escape(vTrans)), 
                                                    arg1: vLanguage, 
                                                    arg2: vTrans.Length);

            string outputTempFile = Path.GetTempFileName();

            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFile(speechStringUrl, vfileName);
                }

                // Get translated file

                if (File.Exists(vfileName))
                {
                    return vfileName;
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, Resources.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (File.Exists(outputTempFile))
                {
                    File.Delete(outputTempFile);
                }
            }

            return String.Empty;
        }

        /// <summary>
        /// Get full name language
        /// </summary>
        public string GetFullLanguage(string vLang)
        {
            EnsureInitialized();
            return _languageList[vLang];
        }

        /// <summary>
        /// Ensures the translator has been initialized.
        /// </summary>
        private static void EnsureInitialized()
        {
            if (Translator._languageList == null) {
                Translator._languageList = new Dictionary<string, string>
                {
                    {"auto", "Auto"},
                    {"af", "Afrikaans"},
                    {"sq", "Albanian"},
                    {"ar", "Arabic"},
                    {"hy", "Armenian"},
                    {"az", "Azerbaijani"},
                    {"eu","Basque"},
                    {"be","Belarusian"},
                    {"bn","Bengali"},
                    {"bg","Bulgarian"},
                    {"ca","Catalan"},
                    {"zh-CN","Chinese"},
                    {"hr","Croatian"},
                    {"cs","Czech"},
                    {"da","Danish"},
                    {"nl","Dutch"},
                    {"en","English"},
                    {"eo","Esperanto"},
                    {"et","Estonian"},
                    {"tl","Filipino"},
                    {"fi","Finnish"},
                    {"fr","French"},
                    {"gl","Galician"},
                    {"de","German"},
                    {"ka","Georgian"},
                    {"el","Greek"},
                    {"ht","Haitian Creole"},
                    {"iw","Hebrew"},
                    {"hi","Hindi"},
                    {"hu","Hungarian"},
                    {"is","Icelandic"},
                    {"id","Indonesian"},
                    {"ga","Irish"},
                    {"it","Italian"},
                    {"ja","Japanese"},
                    {"ko","Korean"},
                    {"lo","Lao"},
                    {"la","Latin"},
                    {"lv","Latvian"},
                    {"lt", "Lithuanian"},
                    {"mk", "Macedonian"},
                    {"ms", "Malay"},
                    {"mt", "Maltese"},
                    {"no", "Norwegian"},
                    {"fa", "Persian"},
                    {"pl", "Polish"},
                    {"pt", "Portuguese"},
                    {"ro", "Romanian"},
                    {"ru", "Russian"},
                    {"sr", "Serbian"},
                    {"sk", "Slovak"},
                    {"sl", "Slovenian"},
                    {"es", "Spanish"},
                    {"sw", "Swahili"},
                    {"sv", "Swedish"},
                    {"ta", "Tamil"},
                    {"te", "Telugu"},
                    {"th", "Thai"},
                    {"tr", "Turkish"},
                    {"uk", "Ukrainian"},
                    {"ur", "Urdu"},
                    {"vi", "Vietnamese"},
                    {"cy", "Welsh"},
                    {"yi", "Yiddish"}
                };
            }
        }

        #endregion
    }
}

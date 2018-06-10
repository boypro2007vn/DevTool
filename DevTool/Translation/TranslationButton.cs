using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using DevTool.Model;
using DevTool.Properties;
using DevTool.Services;
using Gma.System.MouseKeyHook;

namespace DevTool.Translation
{
    public partial class TranslationButton : Form
    {
        #region Const Variable

        private const string REGEX =
            @"<span id=result_box (?:\s*[a-z_\-]+(?:=(?:""[^""]*""|'[^']*'|[^>]+))?)*>([^<]+)</span>";

        private const string GOOGLE_URL = "https://translate.google.com/?hl=en&ie=UTF8&";

        #endregion
        #region Private Variable

        private IKeyboardMouseEvents _jKeyboardMouseEvents;
        private WebClient _webClient;
        private TranslationResult _frmResult;
        private string _inputLang;
        private string _outputLang;
        private bool _copyToClipboard;

        #endregion

        public TranslationButton()
        {
            InitializeComponent();
        }

        #region Init Controll

        public void InitTranslation(bool vActive)
        {
            if (_jKeyboardMouseEvents != null)
            {
                DestroyKeyboardMouseEvent();
            }

            if (vActive)
            {
                InitKeyboardMouseEvent();
            }

        }

        private void InitKeyboardMouseEvent()
        {
            _jKeyboardMouseEvents = Hook.GlobalEvents();

            _jKeyboardMouseEvents.KeyUp += KeyUp;
            _jKeyboardMouseEvents.MouseClick += MouseClick;
        }

        #endregion

        #region Event

        #region MouseEvent

        private new void MouseClick(object sender, MouseEventArgs e)
        {
            // Get current window
            int activeWinPtr = WindowActivity.GetForegroundWindow().ToInt32();
            int processId = 0;

            // Get active window processid
            int activeThreadId = WindowActivity.GetWindowThreadProcessId(activeWinPtr, out processId);
            // Get current window processid
            int currentThreadId = WindowActivity.GetCurrentThreadId();
            if (activeThreadId != currentThreadId)
            {
                this.Visible = false;
            }
        }

        #endregion
        #region KeyboardEvent

        private new void KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (!string.IsNullOrEmpty(Clipboard.GetText().Trim()))
                {
                    ShowTranslationButton();
                }
            }
        }

        #endregion

        private void DestroyKeyboardMouseEvent()
        {
            _jKeyboardMouseEvents.KeyUp -= KeyUp;
            _jKeyboardMouseEvents.MouseClick -= MouseClick;
            _jKeyboardMouseEvents.Dispose();
        }

        #endregion

        #region Function

        private void ShowTranslationButton()
        {
            this.SetDesktopLocation(Cursor.Position.X - 15, Cursor.Position.Y + 15);
            this.Visible = true;
            this.TopMost = true;
        }

        private string Translation(string url)
        {
            string result = String.Empty;
            try
            {
                
                Cursor.Current = Cursors.WaitCursor;

                _webClient = new WebClient();
                _webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                _webClient.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                _webClient.Encoding = Encoding.UTF8;

                result = _webClient.DownloadString(url);
                result = Regex.Match(result, REGEX).Groups[1].Value.Trim();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            return result;
        }
        private void BtnTran_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            try
            {
                // Initialize the translator
                Translator translator = new Translator();

                this.Cursor = Cursors.WaitCursor;

                _inputLang = DevTool.Properties.Settings.Default.InputLang;
                _outputLang = DevTool.Properties.Settings.Default.OutputLang;
                _copyToClipboard = DevTool.Properties.Settings.Default.CopyClipBoard;

                string inputText = Clipboard.GetText().Trim();
                string baseUrl = translator.TranslationhUrl;
                translator.Translate(inputText, _inputLang, _outputLang);

                if (translator.Error == null)
                {
                    if (string.IsNullOrEmpty(translator.TranslationResultText))
                    {
                        if (MessageBox.Show(
                                Resources.ERR001,
                                Resources.TitleError,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error
                            ) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(translator.TranslationhUrl);
                        }
                    }
                    else
                    {
                        // Copy if setting = true
                        if (_copyToClipboard)
                        {
                            Clipboard.SetText(translator.TranslationResultText);
                        }

                        if (_frmResult == null || _frmResult.IsDisposed)
                        {
                            _frmResult = new TranslationResult();
                            _frmResult.InitControll(translator);
                            _frmResult.Show();
                        }
                        else
                        {
                            _frmResult.InitControll(translator);
                            // Set the form to top window
                            _frmResult.Focus();
                        }
                    }

                }
                else
                {
                    MessageBox.Show(translator.Error.Message, Resources.TitleError, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion
    }
}

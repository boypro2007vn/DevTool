using System;
using System.Windows.Forms;
using DevTool.Common;
using DevTool.Model;
using DevTool.Properties;
using WMPLib;

namespace DevTool.Translation
{
    public partial class TranslationResult : Form
    {
        private Translator _translator;
        private WindowsMediaPlayer _wplayer;

        public TranslationResult()
        {
            InitializeComponent();
        }

        private void TranslationResult_Load(object sender, EventArgs e)
        {
            // Move form without border
            new FormCommon().MoveForm(this.PnlForm, this);
        }

        public void InitControll(Translator translator)
        {
            _translator = translator;

            //Init button tag
            BtnSpeakSource.Tag = String.Empty;
            BtnSpeakResult.Tag = String.Empty;

            // Get full name of language
            LblInLang.Text = Translator.GetFullLanguage(translator.SourceLanguage);
            LblOutLang.Text = Translator.GetFullLanguage(translator.TranslationLanguage);

            TxtInlang.Text = translator.TranslationSourceText;
            TxtOutlang.Text = translator.TranslationResultText;
            LblTranslationTime.Text = string.Format(Resources.TranslationTime, Math.Round(translator.TranslationTime.TotalSeconds,2));

            // ----------------Set form location---------------------------
            int frmWidth = this.Width;
            int frmHeight = this.Height;

            int cursorX = Cursor.Position.X;
            int cursorY = Cursor.Position.Y;

            int frmLocationX = cursorX;
            int frmLocationY = cursorY;

            // Check if cursor is near the right screen
            if (Screen.PrimaryScreen.WorkingArea.Width - cursorX < (frmWidth + 20))
            {
                frmLocationX -= (frmWidth + 15);
            }

            // Check if cursor is near the bottom screen
            if (Screen.PrimaryScreen.WorkingArea.Height - cursorY < (frmHeight + 20))
            {
                frmLocationY -= (frmHeight + 15);
            }

            this.SetDesktopLocation(frmLocationX + 5, frmLocationY - 5);
        }

        /// <summary>
        /// Speak the text
        /// </summary>
        /// <param name="vObject">Button object</param>
        /// <param name="vTrans">Text to speak</param>
        /// <param name="vLang">Language for speak</param>
        /// <param name="vFileName">File audio to read</param>
        private void SpeekText(Button vObject, string vTrans, string vLang, string vFileName)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                _wplayer?.close();

                if (string.IsNullOrEmpty(vObject.Tag.ToString()))
                {
                    // Set button tag for check the first call
                    if (string.Equals(this.BtnSpeakSource.Name, vObject.Name))
                    {
                        this.BtnSpeakSource.Tag = _translator.GetFileTranslationSpeechUrl(vTrans, vLang, vFileName);
                    }
                    else
                    {
                        this.BtnSpeakResult.Tag = _translator.GetFileTranslationSpeechUrl(vTrans, vLang, vFileName);
                    }
                }

                _wplayer = new WindowsMediaPlayer {URL = vObject.Tag.ToString() };
                _wplayer.controls.play();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            finally
            {
                this.Cursor =  Cursors.Default;
            }
        }

        private void LblSeeMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the online link  
            System.Diagnostics.Process.Start(_translator.TranslationhUrl);
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            _wplayer?.close();
            this.Close();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtOutlang.Text);
            _wplayer?.close();
            this.Close();
        }

        private void BtnSpeakSource_Click(object sender, EventArgs e)
        {
            SpeekText(
                this.BtnSpeakSource,
                TxtInlang.Text.Trim(), 
                _translator.SourceLanguage, 
                Resources.SourceLanguageFileName);
        }

        private void BtnSpeakResult_Click(object sender, EventArgs e)
        {
            SpeekText(
                this.BtnSpeakResult,
                TxtOutlang.Text.Trim(), 
                _translator.TranslationLanguage,
                Resources.TranslateLanguageFileName);
        }

        private void BtnTranslate_Click(object sender, EventArgs e)
        {
            TxtOutlang.Text = String.Empty;

            if (string.IsNullOrEmpty(this.TxtInlang.Text.Trim()))
            {
                return;
            }

            _translator.Translate(this.TxtInlang.Text.Trim(), _translator.SourceLanguage, _translator.TranslationLanguage);

            if (_translator.Error == null)
            {
                if (string.IsNullOrEmpty(_translator.TranslationResultText))
                {
                    // Redirect to online link
                    if (MessageBox.Show(
                            Resources.ERR001,
                            Resources.TitleError,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Error
                        ) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(_translator.TranslationhUrl);
                    }
                }
                else
                {
                    // Copy if setting = true
                    if (DevTool.Properties.Settings.Default.CopyClipBoard)
                    {
                        Clipboard.SetText(_translator.TranslationResultText);
                    }

                    TxtOutlang.Text = _translator.TranslationResultText;
                    LblTranslationTime.Text = String.Format(Resources.TranslationTime, Math.Round(_translator.TranslationTime.TotalSeconds,2));
                }
            }
        }

        /// <summary>
        /// Text change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtInlang_Validated(object sender, EventArgs e)
        {
            if (!TxtInlang.Text.Trim().Equals(TxtInlang.Tag))
            {
                BtnSpeakSource.Tag = String.Empty;
            }

            TxtInlang.Tag = TxtInlang.Text.Trim();
        }

        /// <summary>
        /// Text change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtOutlang_Validated(object sender, EventArgs e)
        {
            if (!TxtOutlang.Text.Trim().Equals(TxtOutlang.Tag))
            {
                BtnSpeakSource.Tag = String.Empty;
            }

            TxtOutlang.Tag = TxtOutlang.Text.Trim();
        }
    }
}

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
        /// <summary>
        /// Flag to check is speaking
        /// </summary>
        private bool _flagSpeech;
        /// <summary>
        /// Flag to check is translate
        /// </summary>
        private bool _flagTran;

        public TranslationResult()
        {
            InitializeComponent();
        }

        private void TranslationResult_Load(object sender, EventArgs e)
        {
            // Move form without border
            new FormCommon().MoveForm(this.PnlForm, this);
        }

        public void InitControl(Translator translator)
        {
            _translator = translator;

            // Init button tag
            BtnSpeakSource.Tag = String.Empty;
            BtnSpeakResult.Tag = String.Empty;

            // Get full name of language
            LblInLang.Text = _translator.GetFullLanguage(translator.SourceLanguage);
            LblOutLang.Text = _translator.GetFullLanguage(translator.TranslationLanguage);

            TxtInlang.Text = translator.TranslationSourceText;
            TxtOutlang.Text = translator.TranslationResultText;
            LblTranslationTime.Text = string.Format(Resources.TranslationTime, Math.Round(translator.TranslationTime.TotalSeconds, 2));

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
                _flagSpeech = true;

                this.Cursor = Cursors.WaitCursor;

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

                if (_wplayer == null)
                {
                    _wplayer = new WindowsMediaPlayer();
                }
                _wplayer.URL = vObject.Tag.ToString();
                _wplayer.PlayStateChange += wplayer_Change;
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
                _flagSpeech = false;
            }
        }

        private void wplayer_Change(int newState)
        {
            // stop
            if (newState == 1)
            {
                _wplayer.close();
            }
        }

        private void LblSeeMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the online link  
            System.Diagnostics.Process.Start(_translator.TranslationhUrl);
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtOutlang.Text);
            this.Visible = false;
        }

        private void BtnSpeakSource_Click(object sender, EventArgs e)
        {
            if (_flagSpeech)
            {
                return;
            }

            SpeekText(
                this.BtnSpeakSource,
                TxtInlang.Text.Trim(), 
                _translator.SourceLanguage, 
                Resources.SourceLanguageFileName);
        }

        private void BtnSpeakResult_Click(object sender, EventArgs e)
        {
            if (_flagSpeech)
            {
                return;
            }

            SpeekText(
                this.BtnSpeakResult,
                TxtOutlang.Text.Trim(), 
                _translator.TranslationLanguage,
                Resources.TranslateLanguageFileName);
        }

        private void BtnTranslate_Click(object sender, EventArgs e)
        {
            if (_flagTran || string.IsNullOrEmpty(this.TxtInlang.Text.Trim()))
            {
                return;
            }

            _flagTran = true;

            TxtOutlang.Text = String.Empty;

            _translator.Translate(this.TxtInlang.Text.Trim(), _translator.SourceLanguage, _translator.TranslationLanguage);

            if (string.IsNullOrEmpty(_translator.TranslationResultText))
            {
                // Redirect to online link
                if (MessageBox.Show(
                        Resources.Err001,
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
                LblTranslationTime.Text = String.Format(Resources.TranslationTime, Math.Round(_translator.TranslationTime.TotalSeconds, 2));
            }

            _flagTran = false;
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

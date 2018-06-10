using System;
using System.Windows.Forms;
using DevTool.Model;
using DevTool.Properties;
using DevTool.Services;
using Gma.System.MouseKeyHook;

namespace DevTool.Translation
{
    public partial class TranslationButton : Form
    {
        #region Private Variable

        private IKeyboardMouseEvents _jKeyboardMouseEvents;
        private Translator _translator;
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

        public void Active(bool vActive)
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

        private void BtnTran_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            try
            {
                // Initialize the translator
                if (_translator == null)
                {
                    _translator = new Translator();
                }
                
                this.Cursor = Cursors.WaitCursor;

                _inputLang = Properties.Settings.Default.InputLang;
                _outputLang = Properties.Settings.Default.OutputLang;
                _copyToClipboard = Properties.Settings.Default.CopyClipBoard;

                string inputText = Clipboard.GetText().Trim();
                _translator.Translate(inputText, _inputLang, _outputLang);

                if (_translator.Error == null)
                {
                    if (string.IsNullOrEmpty(_translator.TranslationResultText))
                    {
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
                        if (_copyToClipboard)
                        {
                            Clipboard.SetText(_translator.TranslationResultText);
                        }

                        if (_frmResult == null || _frmResult.IsDisposed)
                        {
                            _frmResult = new TranslationResult();
                            _frmResult.InitControll(_translator);
                            _frmResult.Show();
                        }
                        else
                        {
                            _frmResult.InitControll(_translator);
                            // Set the form to top window
                            _frmResult.Focus();
                        }
                    }

                }
                else
                {
                    MessageBox.Show(_translator.Error.Message, Resources.TitleError, MessageBoxButtons.OK,
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

using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using DevTool.Common;
using DevTool.Model;
using DevTool.Properties;
using Gma.System.MouseKeyHook;

namespace DevTool.Translation
{
    public partial class TranslationButton : Form
    {
        #region Private Variable

        private IKeyboardMouseEvents _jKeyboardMouseEvents;
        private Translator _translator;
        private TranslationResult _frmResult;
        private bool _flagCheckTranslate;
        private string _clipboardData;

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

            //Mouse event
            _jKeyboardMouseEvents.MouseDragFinished += MouseTranslateEvent;
            _jKeyboardMouseEvents.MouseDoubleClick += MouseTranslateEvent;
        }

        #endregion

        #region MouseEvent

        private void MouseTranslateEvent(object sender, MouseEventArgs e)
        {
            if (_flagCheckTranslate)
            {
                return;
            }

            ReadOnlyCollection<ClipboardData> listClipboardData = null;

            try
            {
                _flagCheckTranslate = true;

                // Get current clipboard data
                listClipboardData = ClipboardHelper.GetClipboard();

                // Clear previous clipboard
                Clipboard.Clear();

                // Copy the target
                SendKeys.SendWait("^c");

                // Get new clipboard data
                ReadOnlyCollection<ClipboardData> listClipboardDataNew = ClipboardHelper.GetClipboard();

                foreach (ClipboardData data in listClipboardDataNew)
                {
                    if (data.Format == 1 || data.Format == 7)
                    {
                        _clipboardData = System.Text.Encoding.UTF8.GetString(data.Buffer, 0, data.Buffer.Length - 1).Trim();
                        if (!string.IsNullOrEmpty(_clipboardData))
                        {
                            ShowTranslationButton();
                        }
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                if (listClipboardData != null)
                {
                    ClipboardHelper.SetClipboard(listClipboardData);
                }
                _flagCheckTranslate = false;
            }
        }

        private void DestroyKeyboardMouseEvent()
        {
            _jKeyboardMouseEvents.MouseDoubleClick -= MouseTranslateEvent;
            _jKeyboardMouseEvents.MouseDragFinished -= MouseTranslateEvent;
            _jKeyboardMouseEvents.Dispose();
        }

        #endregion

        #region Function
       
        /// <summary>
        /// Show button for translate
        /// </summary>
        private void ShowTranslationButton()
        {
            this.SetDesktopLocation(Cursor.Position.X - 15, Cursor.Position.Y + 15);
            this.Visible = true;
            this.TopMost = true;
        }

        private void GetResultTranslate()
        {
            if (string.IsNullOrEmpty(_clipboardData))
            {
                return;
            }

            try
            {
                // Initialize the translator
                if (_translator == null)
                {
                    _translator = new Translator();
                }

                string inputLang = Properties.Settings.Default.InputLang;
                string outputLang = Properties.Settings.Default.OutputLang;
                bool copyToClipboard = Properties.Settings.Default.CopyClipBoard;

                _translator.Translate(_clipboardData, inputLang, outputLang);

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
                    if (copyToClipboard)
                    {
                        Clipboard.SetText(_translator.TranslationResultText);
                    }

                    if (_frmResult == null)
                    {
                        _frmResult = new TranslationResult();
                    }

                    _frmResult.InitControl(_translator);
                    _frmResult.Show();
                    // Set the form to top window
                    _frmResult.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.TitleError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                _clipboardData = string.Empty;
            }
        }
        private void BtnTran_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GetResultTranslate();
        }

        #endregion

        private void TranslationButton_Deactivate(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.Visible = false;
        }
    }
}

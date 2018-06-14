using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevTool.Common;
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
        private bool _flagCheckTranslate;
        private string _clipboardData;
        IntPtr _nextClipboardViewer;

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
                InitFormEvent();
            }
        }

        private void InitFormEvent()
        {
            _jKeyboardMouseEvents = Hook.GlobalEvents();

            // Key event
            _jKeyboardMouseEvents.KeyDown += TranslateKeyDown;

            // Mouse event
            _jKeyboardMouseEvents.MouseDragFinished += MouseTranslateEvent;
            _jKeyboardMouseEvents.MouseDoubleClick += MouseTranslateEvent;

            // ClipboardEvent
            _nextClipboardViewer = (IntPtr)ClipboardApi.SetClipboardViewer((int)this.Handle);
        }

        #endregion

        #region Event

        #region KeyboardEvent

        private void TranslateKeyDown(object sender, KeyEventArgs e)
        {
            this.Visible = false;
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

                // Get current clipboard data to backup
                listClipboardData = ClipboardHelper.GetClipboard();

                // Copy the target
                SendKeys.SendWait("^c");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            finally
            {
                _flagCheckTranslate = false;
                if (listClipboardData != null)
                {
                    // Rollback clipboard
                    ClipboardHelper.SetClipboard(listClipboardData);
                }
            }
        }

        /// <summary>
        /// Destroy all mouse event
        /// </summary>
        private void DestroyKeyboardMouseEvent()
        {
            if (_nextClipboardViewer != null)
            {
                // Set clipboard event to default
                ClipboardApi.ChangeClipboardChain(this.Handle, _nextClipboardViewer);
            }
                
            _jKeyboardMouseEvents.MouseDoubleClick -= MouseTranslateEvent;
            _jKeyboardMouseEvents.MouseDragFinished -= MouseTranslateEvent;
            _jKeyboardMouseEvents.Dispose();
        }

        #endregion

        #region Clipboard event

        /// <summary>
        /// Override clipboard changed event
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            // defined in winuser.h
            const int wmDrawclipboard = 0x308;
            const int wmChangecbchain = 0x030D;

            try
            {
                switch (m.Msg)
                {
                    case wmDrawclipboard:
                        IDataObject iData = Clipboard.GetDataObject();
                        Object oData = null;
                        if (iData != null)
                        {
                            oData = iData.GetData(DataFormats.UnicodeText);
                        }

                        string textData = String.Empty;
                        if (oData != null)
                        {
                            textData = oData.ToString().Trim();
                        }

                        if (!string.IsNullOrEmpty(textData) && _flagCheckTranslate)
                        {
                            _clipboardData = textData;
                            ShowTranslationButton();
                        }

                        break;

                    case wmChangecbchain:
                        if (m.WParam == _nextClipboardViewer)
                            _nextClipboardViewer = m.LParam;
                        else
                            WindowApi.SendMessage(_nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                        break;

                    default:
                        base.WndProc(ref m);
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        #endregion

        #endregion

        #region Function

        /// <summary>
        /// Show button for translate
        /// </summary>
        private void ShowTranslationButton()
        {
            this.SetDesktopLocation(Cursor.Position.X - 15, Cursor.Position.Y + 15);
            this.Visible = true;
            this.Focus();
            WindowApi.SetForegroundWindow(this.Handle);
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
            this.Visible = false;
        }

        private void Form_LostFocus(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

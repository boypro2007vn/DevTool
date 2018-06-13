using System;
using System.Configuration;
using System.Windows.Forms;
using DevTool.Settings;
using DevTool.Translation;

namespace DevTool
{
    class TaskTrayApplicationContext: ApplicationContext
    {
        #region Private Variable

        private FrmSetting _configWindow;
        private NotifyIcon _notifyIcon;

        /// <summary>
        /// Flag setting of translator
        /// </summary>
        private bool _tranEnable;

        #endregion

        #region Function Variable

        private TranslationButton _translation;

        #endregion

        public TaskTrayApplicationContext()
        {
            InitControl();
            InitFunction();
        }

        #region ApplicationEvent

        /// <summary>
        /// Init control of app
        /// </summary>
        private void InitControl()
        {
            _notifyIcon = new NotifyIcon();

            // Add Item on muney right-click app
            MenuItem configMenuItem = new MenuItem("Config", ShowConfig);
            MenuItem feetBackMenuItem = new MenuItem("Feetback", ShowFeetBack);
            MenuItem exitMenuItem = new MenuItem("Exit", Exit);
            _notifyIcon.ContextMenu = new ContextMenu(new[] { configMenuItem, feetBackMenuItem, exitMenuItem });

            _notifyIcon.Icon = DevTool.Properties.Resources.AppIcon_48;
            _notifyIcon.Visible = true;

            Properties.Settings.Default.SettingChanging += SettingChanging;
        }

        /// <summary>
        /// App's Setting change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingChanging(object sender, SettingChangingEventArgs e)
        {
            InitFunction();
        }

        /// <summary>
        /// Init function of app
        /// </summary>
        private void InitFunction()
        {
            InitConfig();

            if (_translation == null)
            {
                _translation = new TranslationButton();
            }

            _translation.Active(_tranEnable);

        }

        /// <summary>
        /// Load config of function
        /// </summary>
        private void InitConfig()
        {
            _tranEnable = Properties.Settings.Default.TranslatorEnable;
        }

        #endregion

        #region TaskbarIconEvent

        private void ShowConfig(object sender, EventArgs e)
        {
            if (_configWindow == null)
            {
                _configWindow = new FrmSetting();
            }
            // If we are already showing the window meerly focus it.
            if (_configWindow.Visible)
            {
                _configWindow.Focus();
            }
            else
            {
                _configWindow.ShowDialog();
            }
        }

        private void ShowFeetBack(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, EventArgs e)
        {
            _notifyIcon.Icon = null;
            Application.Exit();
        }

        #endregion
    }
}

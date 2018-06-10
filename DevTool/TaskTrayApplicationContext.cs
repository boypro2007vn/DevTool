using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DevTool.Settings;
using DevTool.Translation;

namespace DevTool
{
    class TaskTrayApplicationContext: ApplicationContext
    {
        #region Private Variable

        private NotifyIcon _notifyIcon;
        private FrmSetting _configWindow;

        #region Function Setting
        /// <summary>
        /// Flag setting of translator
        /// </summary>
        private bool tranEnable;

        #endregion

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
            //_httpClient = new HttpClient();
            _notifyIcon = new NotifyIcon();
            _configWindow = new FrmSetting();

            // Add Item on muney right-click app
            MenuItem configMenuItem = new MenuItem("Config", new EventHandler(ShowConfig));
            MenuItem feetBackMenuItem = new MenuItem("Feetback", new EventHandler(ShowFeetBack));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));
            _notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { configMenuItem, feetBackMenuItem, exitMenuItem });

            _notifyIcon.Icon = DevTool.Properties.Resources.AppIcon;
            _notifyIcon.Visible = true;

            DevTool.Properties.Settings.Default.SettingChanging += new SettingChangingEventHandler(SettingChanging);
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

            _translation.InitTranslation(tranEnable);

        }

        /// <summary>
        /// Load config of function
        /// </summary>
        private void InitConfig()
        {
            tranEnable = DevTool.Properties.Settings.Default.Translator;
        }

        #endregion

        #region TaskbarIconEvent

        private void ShowConfig(object sender, EventArgs e)
        {
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
            // We must manually tidy up and remove the icon before we exit.
            // Otherwise it will be left behind until the user mouses over.
            _configWindow.Visible = false;

            Application.Exit();
        }

        #endregion
    }
}

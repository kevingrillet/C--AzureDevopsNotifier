using CSharp_AzureDevopsNotifier.Entities;
using CSharp_TrayShortcut.Helpers;

namespace CSharp_AzureDevopsNotifier.Forms
{
    public class TrayApplicationContext : ApplicationContext
    {
        private const string _pathSettings = @"Configurations\AzureDevOpsSettings.json";
        private readonly NotifyIcon _notificationIcon;
        private AzureDevOpsManager _manager;
        private AzureDevOpsSettings _settings;

        public TrayApplicationContext()
        {
            _notificationIcon = new NotifyIcon()
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Visible = true
            };
            SetTrayIcon();
            Refresh(null, null);
        }

        /// <summary>
        /// Open Form to edit config file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit(object sender, EventArgs e)
        {
            var editForm = new EditForm(_pathSettings, _settings);
            editForm.FormClosed += (sender, e) => { Refresh(null, null); };
            editForm.Show();
        }

        /// <summary>
        /// Exit app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {
            _notificationIcon.Visible = false;
            Application.Exit();
        }

        /// <summary>
        /// Load _settings from Json. Set Icons. Refresh Menus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ApplicationException">If _settings.Path does not exists, BOOM!</exception>
        private void Refresh(object sender, EventArgs e)
        {
            // Load config file
            _settings = JsonHelpers<AzureDevOpsSettings>.Load(_pathSettings);

            if (_manager != null)
                _manager.Update(_settings);
            else
                _manager = new AzureDevOpsManager(_settings);
            _ = _manager.RunAsync();
        }

        private void SetTrayIcon()
        {
            // Set Tray icon
            _notificationIcon.Icon = new Icon(Path.Combine("Ressources", "Microsoft-Azure.ico"));

            // Update menus
            var contextMenuStrip = _notificationIcon.ContextMenuStrip;
            contextMenuStrip.Items.Clear();

            // Static bottom menus
            contextMenuStrip.Items.AddRange(new ToolStripItem[] {
                //new ToolStripMenuItem(nameof(Refresh), null, new EventHandler(Refresh)),
                //new ToolStripMenuItem(nameof(Edit), null, new EventHandler(Edit)),
                new ToolStripMenuItem(nameof(Exit), null, new EventHandler(Exit)),
            });
        }
    }
}

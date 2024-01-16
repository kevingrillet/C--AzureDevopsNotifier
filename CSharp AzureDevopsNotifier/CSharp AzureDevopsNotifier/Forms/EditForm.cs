using CSharp_AzureDevopsNotifier.Entities;
using CSharp_TrayShortcut.Helpers;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_AzureDevopsNotifier
{
    public partial class EditForm : Form
    {
        private readonly AzureDevOpsSettings _azureDevOpsSettings;
        private readonly string _pathSettings;

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(string pathSettings, AzureDevOpsSettings azureDevOpsSettings = null)
        {
            _pathSettings = pathSettings;
            _azureDevOpsSettings = azureDevOpsSettings ?? JsonHelpers<AzureDevOpsSettings>.Load(_pathSettings);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            numericUpDownDelay.Value = _azureDevOpsSettings.Delay;
            textBoxOrganizationUrl.Text = _azureDevOpsSettings.OrganizationUrl;
            textBoxPersonalAccessToken.Text = _azureDevOpsSettings.PersonalAccessToken;
            textBoxProjectName.Text = _azureDevOpsSettings.ProjectName;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _azureDevOpsSettings.Delay = (int)numericUpDownDelay.Value;
            _azureDevOpsSettings.OrganizationUrl = textBoxOrganizationUrl.Text;
            _azureDevOpsSettings.PersonalAccessToken = textBoxPersonalAccessToken.Text;
            _azureDevOpsSettings.ProjectName = textBoxProjectName.Text;
        }
    }
}

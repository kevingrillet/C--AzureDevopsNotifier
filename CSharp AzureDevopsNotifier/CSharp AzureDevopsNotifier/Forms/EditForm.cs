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
        private BindingList<AzureDevOpsQuery> bindingListQueries;
        private BindingList<string> bindingListQueriesFilters;

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(string pathSettings, AzureDevOpsSettings azureDevOpsSettings = null)
        {
            _pathSettings = pathSettings;
            _azureDevOpsSettings = azureDevOpsSettings ?? JsonHelpers<AzureDevOpsSettings>.Load(_pathSettings);
        }

        private void ButtonQueriesDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewQueries.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridViewQueries.SelectedRows)
                {
                    dataGridViewQueries.Rows.RemoveAt(item.Index);
                }
            }
            else
            {
                if (dataGridViewQueries.CurrentCell != null)
                {
                    dataGridViewQueries.Rows.RemoveAt(dataGridViewQueries.CurrentCell.RowIndex);
                }
            }
        }

        private void ButtonQueriesDetailsSave_Click(object sender, EventArgs e)
        {
            var currentIndex = GetCurrentQueryIndex();
            if (currentIndex == null) return;
            var currentQuery = _azureDevOpsSettings.Queries[currentIndex.Value];

            dataGridViewQueriesFilters.ClearSelection();
            dataGridViewQueriesFilters.CurrentCell = null;

            currentQuery.Filters = bindingListQueriesFilters.AsEnumerable().Where(w => !string.IsNullOrWhiteSpace(w)).ToList();
            currentQuery.Name = !string.IsNullOrWhiteSpace(textBoxName.Text) ? textBoxName.Text : null;
            currentQuery.RepositoryName = !string.IsNullOrWhiteSpace(textBoxRepositoryName.Text) ? textBoxRepositoryName.Text : null;
            currentQuery.Running = checkBoxRunning.Checked;
            currentQuery.Type = (AzureDevopsQueryType)comboBoxType.SelectedIndex;
        }

        private void DataGridViewQueries_SelectionChanged(object sender, EventArgs e)
        {
            var currentIndex = GetCurrentQueryIndex();
            if (currentIndex == null) return;

            LoadDetails(currentIndex.Value);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(AzureDevopsQueryType)))
            {
                comboBoxType.Items.Add(item);
            }

            numericUpDownDelay.Value = _azureDevOpsSettings.Delay;
            textBoxOrganizationUrl.Text = _azureDevOpsSettings.OrganizationUrl ?? string.Empty;
            textBoxPersonalAccessToken.Text = _azureDevOpsSettings.PersonalAccessToken ?? string.Empty;
            textBoxProjectName.Text = _azureDevOpsSettings.ProjectName ?? string.Empty;

            var queries = _azureDevOpsSettings.Queries
                .Select(s => new AzureDevOpsQuery
                {
                    Filters = s.Filters ?? [],
                    Name = s.Name ?? string.Empty,
                    RepositoryName = s.RepositoryName ?? string.Empty,
                    Running = s.Running,
                    Type = s.Type,
                }).ToList();

            bindingListQueries = new(queries)
            {
                AllowEdit = true,
                AllowNew = true,
                AllowRemove = true,
                RaiseListChangedEvents = true,
            };
            bindingListQueries.AddingNew += (sender, e) =>
            {
                e.NewObject = new AzureDevOpsQuery();
            };

            dataGridViewQueries.DataSource = bindingListQueries;
            foreach (DataGridViewColumn col in dataGridViewQueries.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.FillWeight = 25;
            }
        }

        private int? GetCurrentQueryIndex()
        {
            if (dataGridViewQueries.SelectedRows.Count > 0)
            {
                return dataGridViewQueries.SelectedRows[0].Index;
            }
            else if (dataGridViewQueries.CurrentCell != null)
            {
                return dataGridViewQueries.CurrentCell.RowIndex;
            }
            return null;
        }

        private void LoadDetails(int index)
        {
            var currentQuery = _azureDevOpsSettings.Queries[index];

            textBoxName.Text = currentQuery.Name ?? string.Empty;
            checkBoxRunning.Checked = currentQuery.Running;
            comboBoxType.SelectedIndex = (int)currentQuery.Type;
            labelRepositoryName.Text = currentQuery.RepositoryName ?? string.Empty;

            var filters = currentQuery.Filters;

            bindingListQueriesFilters = new(filters)
            {
                AllowEdit = true,
                AllowNew = true,
                AllowRemove = true,
                RaiseListChangedEvents = true,
            };
            bindingListQueriesFilters.AddingNew += (sender, e) =>
            {
                e.NewObject = string.Empty;
            };

            dataGridViewQueriesFilters.DataSource = bindingListQueriesFilters;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _azureDevOpsSettings.Delay = (int)numericUpDownDelay.Value;
            _azureDevOpsSettings.OrganizationUrl = !string.IsNullOrWhiteSpace(textBoxOrganizationUrl.Text) ? textBoxOrganizationUrl.Text : null;
            _azureDevOpsSettings.PersonalAccessToken = !string.IsNullOrWhiteSpace(textBoxPersonalAccessToken.Text) ? textBoxPersonalAccessToken.Text : null;
            _azureDevOpsSettings.ProjectName = !string.IsNullOrWhiteSpace(textBoxProjectName.Text) ? textBoxProjectName.Text : null;

            //JsonHelpers<AzureDevOpsSettings>.Save(_pathSettings, _azureDevOpsSettings);
        }
    }
}

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
        private readonly BindingList<AzureDevOpsQuery> bindingList;

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(string pathSettings, AzureDevOpsSettings azureDevOpsSettings = null)
        {
            _pathSettings = pathSettings;
            _azureDevOpsSettings = azureDevOpsSettings ?? JsonHelpers<AzureDevOpsSettings>.Load(_pathSettings);

            var queries = _azureDevOpsSettings.Queries
                .Select(s => new AzureDevOpsQuery
                {
                    Filters = s.Filters ?? [],
                    RepositoryName = s.RepositoryName ?? string.Empty,
                    Type = s.Type,
                }).ToList();

            bindingList = new(queries)
            {
                AllowEdit = true,
                AllowNew = true,
                AllowRemove = true,
                RaiseListChangedEvents = true,
            };
            bindingList.AddingNew += (sender, e) =>
            {
                // If property is null, it can't be adited -_-
                e.NewObject = new AzureDevOpsQuery();
            };

            // Complete DataGridView
            dataGridView1.DataSource = bindingList;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.FillWeight = 25;
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
            else
            {
                if (dataGridView1.CurrentCell != null)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                }
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear selection to update the bindingList
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            // Remove empty path, replace empty with null
            _azureDevOpsSettings.Queries = bindingList.AsEnumerable()
                .Where(q => q.Filters.Count != 0 || !string.IsNullOrWhiteSpace(q.RepositoryName))
                .Select(q => new AzureDevOpsQuery
                {
                    Filters = q.Filters.Count != 0 ? q.Filters : null,
                    RepositoryName = string.IsNullOrWhiteSpace(q.RepositoryName) ? null : q.RepositoryName,
                    Type = q.Type,
                })
                .ToList();
            JsonHelpers<AzureDevOpsSettings>.Save(_pathSettings, _azureDevOpsSettings);
            Close();
        }
    }
}

using CSharp_AzureDevopsNotifier.Entities;
using CSharp_AzureDevopsNotifier.Helpers;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_AzureDevopsNotifier
{
    public class AzureDevOpsManager
    {
        private readonly StorageInfos _storageInfos;
        private AzureDevOpsClient _azureDevOpsClient;
        private bool _running;
        private AzureDevOpsSettings _settings;

        public AzureDevOpsManager()
        {
            Update(_settings);
            _storageInfos = JsonHelpers<StorageInfos>.Load(@"Configurations/StorageInfos.json");
        }

        public AzureDevOpsManager(AzureDevOpsSettings azureDevOpsSettings) : this()
        {
            _settings = azureDevOpsSettings;
        }

        public void Run()
        {
            QueryGit();
            QueryWorkItems();
            SaveStorageInfos();
        }

        public async Task RunAsync()
        {
            _running = true;
            while (_running)
            {
                Run();
                // Wait for X minutes before the next check
                await Task.Delay(_settings.Delay * 60 * 1000);
            }
        }

        public void Stop()
        {
            _running = false;
        }

        public void Update(AzureDevOpsSettings azureDevOpsSettings)
        {
            _settings = azureDevOpsSettings ?? JsonHelpers<AzureDevOpsSettings>.Load(@"Configurations/AzureDevOpsSettings.json");
            _azureDevOpsClient = new AzureDevOpsClient(_settings);
            _running = false;
        }

        private void QueryGit()
        {
            foreach (var query in _settings.Queries.Where(q => q.Running && q.Type == AzureDevopsQueryType.Git))
            {
                var prs = AzureDevOpsHelpers.GetNewPullRequests(_azureDevOpsClient.GetGitClient(), _settings.ProjectName, query.RepositoryName);
                AzureDevOpsHelpers.DisplayNewItems(prs, _storageInfos.DisplayedPrIds, _settings, query);
            }
        }

        private void QueryWorkItems()
        {
            foreach (var query in _settings.Queries.Where(q => q.Running && q.Type == AzureDevopsQueryType.WorkItem))
            {
                var workItems = AzureDevOpsHelpers.GetWorkItems(_azureDevOpsClient.GetWorkItemClient(), query.Filters);
                AzureDevOpsHelpers.DisplayNewItems(workItems, _storageInfos.DisplayedWorkItemsIds, _settings);
            }
        }

        private void SaveStorageInfos()
        {
            if (_storageInfos != null)
            {
                JsonHelpers<StorageInfos>.Save("Configurations/StorageInfos.json", _storageInfos);
            }
        }
    }
}

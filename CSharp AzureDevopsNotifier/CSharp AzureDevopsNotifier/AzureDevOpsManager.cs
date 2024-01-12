using CSharp_AzureDevopsNotifier.Entities;
using CSharp_AzureDevopsNotifier.Helpers;
using CSharp_TrayShortcut.Helpers;

namespace CSharp_AzureDevopsNotifier
{
    public class AzureDevOpsManager
    {
        private readonly AzureDevOpsClient _AzureDevOpsClient;
        private readonly AzureDevOpsSettings _settings;
        private readonly StorageInfos _storageInfos;
        private bool _running;

        public AzureDevOpsManager()
        {
            _settings ??= JsonHelpers<AzureDevOpsSettings>.Load("Configurations/AzureDevOpsSettings.json");
            _AzureDevOpsClient = new AzureDevOpsClient(_settings);
            _running = false;
            _storageInfos = JsonHelpers<StorageInfos>.Load("Configurations/StorageInfos.json");
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
                // Wait for 5 minutes before the next check
                await Task.Delay(5 * 60 * 1000);
            }
        }

        public void Stop()
        {
            _running = false;
        }

        private void QueryGit()
        {
            foreach (var query in _settings.Queries.Where(q => q.Type == AzureDevopsQueryType.Git))
            {
                var prs = AzureDevOpsHelpers.GetNewPullRequests(_AzureDevOpsClient.GetGitClient(), _settings.ProjectName, query.RepositoryName);
                AzureDevOpsHelpers.DisplayNewItems(prs, _storageInfos.DisplayedPrIds, _settings, query);
            }
        }

        private void QueryWorkItems()
        {
            foreach (var query in _settings.Queries.Where(q => q.Type == AzureDevopsQueryType.WorkItem))
            {
                var workItems = AzureDevOpsHelpers.GetWorkItems(_AzureDevOpsClient.GetWorkItemClient(), query.Filters);
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

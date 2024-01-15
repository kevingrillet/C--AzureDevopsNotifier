using CSharp_AzureDevopsNotifier.Entities;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;

namespace CSharp_AzureDevopsNotifier.Helpers
{
    public static class AzureDevOpsHelpers
    {
        /// <summary>
        /// Display items & show a toast
        /// </summary>
        /// <typeparam name="TType"><see cref="GitPullRequest"/> or <see cref="WorkItem"/></typeparam>
        /// <param name="items"></param>
        /// <param name="displayedItemIds"></param>
        public static void DisplayNewItems<TType>(IList<TType> items, IList<int> displayedItemIds, AzureDevOpsSettings settings, AzureDevOpsQuery query = null)
        {
            foreach (var item in items)
            {
                // Check if the item ID is not in the list of displayed IDs
                if (!displayedItemIds.Contains(GetItemId(item)))
                {
                    // Display the item information as a toast notification
                    ToastHelpers.ShowToastNotification($"New {typeof(TType).Name}", GetItemName(item), GetItemUrl(item, settings, query));

                    // Add the item ID to the list of displayed IDs
                    displayedItemIds.Add(GetItemId(item));
                }
            }
        }

        /// <summary>
        /// Retrieve the list of Pull Requests
        /// </summary>
        /// <param name="gitClient"></param>
        /// <param name="projectName"></param>
        /// <param name="repositoryName"></param>
        /// <returns>List of Pull Requests</returns>
        public static List<GitPullRequest> GetNewPullRequests(GitHttpClient gitClient, string projectName, string repositoryName)
        {
            // Define a search criteria for Pull Requests
            GitPullRequestSearchCriteria prSearchCriteria = new()
            {
                Status = PullRequestStatus.Active
            };

            // Retrieve the list of Pull Requests
            List<GitPullRequest> pullRequests = gitClient.GetPullRequestsAsync(projectName, repositoryName, prSearchCriteria).Result;

            return pullRequests;
        }

        /// <summary>
        /// Retrieve the detailed information for each WorkItem
        /// </summary>
        /// <param name="workItemClient"></param>
        /// <param name="workItemType"></param>
        /// <param name="filters"></param>
        /// <returns>List of WorkItems</returns>
        public static List<WorkItem> GetWorkItems(WorkItemTrackingHttpClient workItemClient, IList<string> filters)
        {
            // Define a Wiql query to retrieve Bugs
            string wiql = "SELECT [System.Id], [System.Title], [System.State], [System.CreatedDate] FROM workitems " +
                $"WHERE {string.Join(" And ", filters)} ORDER BY [System.CreatedDate] DESC";

            // Execute the query to get the list of Bugs
            WorkItemQueryResult queryResult = workItemClient.QueryByWiqlAsync(new Wiql { Query = wiql }).Result;
            List<WorkItemReference> workItemReferences = queryResult.WorkItems.ToList();

            // Retrieve the detailed information for each Bug
            List<WorkItem> bugs = workItemClient.GetWorkItemsAsync(workItemReferences.Select(w => w.Id)).Result;

            return bugs;
        }

        /// <summary>
        /// Implement logic to get the ID of the item
        /// </summary>
        /// <typeparam name="TType"><see cref="GitPullRequest"/> or <see cref="WorkItem"/></typeparam>
        /// <param name="item"></param>
        /// <returns>URL of the item</returns>
        /// <exception cref="InvalidOperationException"></exception>
        private static int GetItemId<TType>(TType item)
        {
            if (item is GitPullRequest)
            {
                return (item as GitPullRequest).PullRequestId;
            }
            else if (item is WorkItem)
            {
                return (item as WorkItem).Id ?? 0;
            }
            throw new InvalidOperationException("Unsupported item type");
        }

        /// <summary>
        /// Implement logic to get the name of the item
        /// </summary>
        /// <typeparam name="TType"><see cref="GitPullRequest"/> or <see cref="WorkItem"/></typeparam>
        /// <param name="item"></param>
        /// <returns>URL of the item</returns>
        /// <exception cref="InvalidOperationException"></exception>
        private static string GetItemName<TType>(TType item)
        {
            if (item is GitPullRequest)
            {
                return (item as GitPullRequest).Title;
            }
            else if (item is WorkItem)
            {
                return (item as WorkItem).Fields["System.Title"].ToString();
            }
            throw new InvalidOperationException("Unsupported item type");
        }

        /// <summary>
        /// Implement logic to get the URL of the item
        /// </summary>
        /// <typeparam name="TType"><see cref="GitPullRequest"/> or <see cref="WorkItem"/></typeparam>
        /// <param name="item"></param>
        /// <returns>URL of the item</returns>
        /// <exception cref="InvalidOperationException"></exception>
        private static string GetItemUrl<TType>(TType item, AzureDevOpsSettings settings, AzureDevOpsQuery query)
        {
            if (item is GitPullRequest)
            {
                return $"{settings.OrganizationUrl}/{settings.ProjectName}/_git/{query?.RepositoryName}/pullrequest/{GetItemId(item)}";
            }
            else if (item is WorkItem)
            {
                return $"{settings.OrganizationUrl}/{settings.ProjectName}/_workitems/edit/{GetItemId(item)}";
            }
            throw new InvalidOperationException("Unsupported item type");
        }
    }
}

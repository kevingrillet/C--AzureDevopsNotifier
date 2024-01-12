namespace CSharp_AzureDevopsNotifier.Entities
{
    public enum AzureDevopsQueryType
    {
        WorkItem = 0,
        Git = 1
    }

    public class AzureDevOpsQuery
    {
        /// <summary>
        /// Use to create wiql conditions to query WorkItems
        /// </summary>
        /// <remarks>Works for: AzureDevopsQueryType.WorkItem</remarks>
        public List<AzureDevOpsFilter> Filters { get; set; }

        /// <summary>
        /// Use to specify which repository will be used to query Git
        /// </summary>
        /// <remarks>Works for: AzureDevopsQueryType.Git</remarks>
        public string RepositoryName { get; set; }

        public AzureDevopsQueryType Type { get; set; }

        public AzureDevOpsQuery()
        {
            Filters = [];
            RepositoryName = string.Empty;
        }
    }
}

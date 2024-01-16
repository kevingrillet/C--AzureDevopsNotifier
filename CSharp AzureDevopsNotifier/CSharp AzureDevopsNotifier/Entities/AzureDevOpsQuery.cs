using System.Collections.Generic;

namespace CSharp_AzureDevopsNotifier.Entities
{
    public enum AzureDevopsQueryType
    {
        WorkItem = 0,
        Git = 1
    }

    /// <summary>
    /// Represents an Azure DevOps query.
    /// </summary>
    public class AzureDevOpsQuery
    {
        /// <summary>
        /// Used to create WIQL conditions to query work items.
        /// </summary>
        /// <remarks>Works for: AzureDevopsQueryType.WorkItem</remarks>
        public IList<string> Filters { get; set; }

        /// <summary>
        /// Name or description of the query.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Used to specify which repository will be used to query Git.
        /// </summary>
        /// <remarks>Works for: AzureDevopsQueryType.Git</remarks>
        public string RepositoryName { get; set; }

        /// <summary>
        /// Value indicating whether the query should be run.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the query should be run; otherwise, <c>false</c>.
        /// </value>
        public bool Running { get; set; }

        public AzureDevopsQueryType Type { get; set; }

        public AzureDevOpsQuery()
        {
            Filters = [];
            Name = string.Empty;
            RepositoryName = string.Empty;
            Running = false;
        }
    }
}

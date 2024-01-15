using System.Collections.Generic;

namespace CSharp_AzureDevopsNotifier.Entities
{
    /// <summary>
    /// Represents the settings for Azure DevOps integration.
    /// </summary>
    public class AzureDevOpsSettings
    {
        /// <summary>
        /// Delay between calls
        /// </summary>
        public int Delay { get; set; }

        /// <summary>
        /// https://dev.azure.com/{MyOrganisation}/
        /// </summary>
        public string OrganizationUrl { get; set; }

        /// <summary>
        /// Can be created at: https://dev.azure.com/{MyOrganisation}/_usersSettings/tokens
        /// </summary>
        public string PersonalAccessToken { get; set; }

        /// <summary>
        /// https://dev.azure.com/{MyOrganisation}/{ProjectName}/
        /// </summary>
        public string ProjectName { get; set; }

        public IList<AzureDevOpsQuery> Queries { get; set; }

        public AzureDevOpsSettings()
        {
            Delay = 0;
            OrganizationUrl = string.Empty;
            PersonalAccessToken = string.Empty;
            ProjectName = string.Empty;
            Queries = [];
        }
    }
}

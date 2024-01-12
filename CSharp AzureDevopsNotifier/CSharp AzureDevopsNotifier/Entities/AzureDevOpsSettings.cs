namespace CSharp_AzureDevopsNotifier.Entities
{
    public class AzureDevOpsSettings
    {
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
            OrganizationUrl = string.Empty;
            PersonalAccessToken = string.Empty;
            ProjectName = string.Empty;
            Queries = [];
        }
    }
}

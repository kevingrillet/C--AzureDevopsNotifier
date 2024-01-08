namespace CSharp_AzureDevopsNotifier.Entities
{
    public class Settings
    {
        public string OrganisationUrl { get; set; }
        public string PersonalAccessToken { get; set; }
        public string TeamProjectName { get; set; }
        public Settings()
        {
            OrganisationUrl = string.Empty;
            PersonalAccessToken = string.Empty;
            TeamProjectName = string.Empty;
        }
    }
}

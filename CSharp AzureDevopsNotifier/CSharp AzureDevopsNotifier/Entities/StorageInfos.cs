namespace CSharp_AzureDevopsNotifier.Entities
{
    /// <summary>
    /// Represents a class that holds storage information.
    /// </summary>
    public class StorageInfos
    {
        public List<int> DisplayedPrIds { get; set; }
        public List<int> DisplayedWorkItemsIds { get; set; }

        public StorageInfos()
        {
            DisplayedPrIds = [];
            DisplayedWorkItemsIds = [];
        }
    }
}

namespace CSharp_AzureDevopsNotifier.Entities
{
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

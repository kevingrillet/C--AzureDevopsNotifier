using System.Collections.Generic;

namespace CSharp_AzureDevopsNotifier.Entities
{
    /// <summary>
    /// Represents a class that holds storage information.
    /// </summary>
    public class StorageInfos
    {
        public IList<int> DisplayedPrIds { get; set; }
        public IList<int> DisplayedWorkItemsIds { get; set; }

        public StorageInfos()
        {
            DisplayedPrIds = [];
            DisplayedWorkItemsIds = [];
        }
    }
}

using Microsoft.Toolkit.Uwp.Notifications;

namespace CSharp_AzureDevopsNotifier.Helpers
{
    public static class ToastHelpers
    {
        /// <summary>
        /// Show a toast notification
        /// </summary>
        /// <remarks>Only works on W10/11</remarks>
        /// <param name="title">Title</param>
        /// <param name="description">Description</param>
        /// <param name="url">Url on click</param>
        public static void ShowToastNotification(string title, string description, string url)
        {
            new ToastContentBuilder()
                .AddText(title)
                .AddText(description)
                .SetProtocolActivation(new Uri(url))
                .Show();
        }
    }
}

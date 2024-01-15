using Microsoft.Toolkit.Uwp.Notifications;

namespace CSharp_AzureDevopsNotifier.Helpers
{
    /// <summary>
    /// Provides helper methods for showing toast notifications.
    /// </summary>
    /// <remarks>
    /// This class is specifically designed for Windows 10/11 operating systems.
    /// </remarks>
    public static class ToastHelpers
    {
        /// <summary>
        /// Shows a toast notification with the specified title, description, and URL.
        /// </summary>
        /// <param name="title">The title of the toast notification.</param>
        /// <param name="description">The description of the toast notification.</param>
        /// <param name="url">The URL to open when the toast notification is clicked.</param>
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

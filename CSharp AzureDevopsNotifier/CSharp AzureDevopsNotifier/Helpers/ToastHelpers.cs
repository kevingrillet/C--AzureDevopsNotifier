using Microsoft.Toolkit.Uwp.Notifications;
using System;

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
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }
            var toast = new ToastContentBuilder().AddText(title);
            if (!string.IsNullOrWhiteSpace(description)) toast.AddText(description);
            if (!string.IsNullOrWhiteSpace(url)) toast.SetProtocolActivation(new Uri(url));
            toast.Show();
        }
    }
}

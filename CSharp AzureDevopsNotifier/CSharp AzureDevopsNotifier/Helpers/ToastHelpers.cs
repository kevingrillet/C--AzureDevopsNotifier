using Microsoft.Toolkit.Uwp.Notifications;
using System;

namespace CSharp_AzureDevopsNotifier.Helpers
{
    public static class ToastContentBuilderExtensions
    {
        /// <summary>
        /// Adds the specified text to the toast content if it is not null or whitespace.
        /// </summary>
        /// <param name="builder">The toast content builder.</param>
        /// <param name="text">The text to add.</param>
        /// <returns>The toast content builder.</returns>
        public static ToastContentBuilder AddTextIfNotNullOrWhiteSpace(this ToastContentBuilder builder, string text)
        {
            ArgumentNullException.ThrowIfNull(builder);

            if (!string.IsNullOrWhiteSpace(text))
            {
                builder.AddText(text);
            }

            return builder;
        }

        /// <summary>
        /// Sets the protocol activation to open the specified URL if it is not null or whitespace.
        /// </summary>
        /// <param name="builder">The toast content builder.</param>
        /// <param name="url">The URL to open.</param>
        /// <returns>The toast content builder.</returns>
        public static ToastContentBuilder SetProtocolActivationIfNotNullOrWhiteSpace(this ToastContentBuilder builder, string url)
        {
            ArgumentNullException.ThrowIfNull(builder);

            if (url != null && !string.IsNullOrWhiteSpace(url.ToString()))
            {
                builder.SetProtocolActivation(new Uri(url));
            }

            return builder;
        }
    }

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

            var toastContentBuilder = new ToastContentBuilder()
                .AddText(title)
                .AddTextIfNotNullOrWhiteSpace(description)
                .SetProtocolActivationIfNotNullOrWhiteSpace(url);

            toastContentBuilder.Show();
        }
    }
}

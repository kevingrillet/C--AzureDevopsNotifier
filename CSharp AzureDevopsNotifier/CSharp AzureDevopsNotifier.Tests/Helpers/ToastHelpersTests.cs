using CSharp_AzureDevopsNotifier.Helpers;
using NUnit.Framework;
using System;

namespace CSharp_AzureDevopsNotifier.Tests.Helpers
{
    internal class ToastHelpersTests
    {
        // Show toast notification with only title
        [Test]
        public void Test_show_toast_notification_with_only_title()
        {
            // Arrange
            string title = "Test Title";
            string description = null;
            string url = null;

            // Act
            ToastHelpers.ShowToastNotification(title, description, url);

            // Assert
            Assert.DoesNotThrow(() => ToastHelpers.ShowToastNotification(title, description, url));
        }

        // Show toast notification with only title and description
        [Test]
        public void Test_show_toast_notification_with_only_title_and_description()
        {
            // Arrange
            string title = "Test Title";
            string description = "Test Description";
            string url = null;

            // Act
            ToastHelpers.ShowToastNotification(title, description, url);

            // Assert
            Assert.DoesNotThrow(() => ToastHelpers.ShowToastNotification(title, description, url));
        }

        // Show toast notification with title, description, and URL
        [Test]
        public void Test_show_toast_notification_with_title_description_and_url()
        {
            // Arrange
            string title = "Test Title";
            string description = "Test Description";
            string url = "https://example.com";

            // Act
            ToastHelpers.ShowToastNotification(title, description, url);

            // Assert
            Assert.DoesNotThrow(() => ToastHelpers.ShowToastNotification(title, description, url));
        }

        // Throw ArgumentNullException when title is empty
        [Test]
        public void Test_throw_argument_null_exception_when_title_is_empty()
        {
            // Arrange
            string title = "";
            string description = "Test Description";
            string url = "https://example.com";

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => ToastHelpers.ShowToastNotification(title, description, url));
        }

        // Throw ArgumentNullException when title is null
        [Test]
        public void Test_throw_argument_null_exception_when_title_is_null()
        {
            // Arrange
            string title = null;
            string description = "Test Description";
            string url = "https://example.com";

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => ToastHelpers.ShowToastNotification(title, description, url));
        }
    }
}

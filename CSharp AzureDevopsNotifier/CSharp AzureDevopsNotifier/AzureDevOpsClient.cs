using CSharp_AzureDevopsNotifier.Entities;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;

namespace CSharp_AzureDevopsNotifier
{
    public interface IAzureDevOpsClient
    {
        GitHttpClient GetGitClient();

        WorkItemTrackingHttpClient GetWorkItemClient();
    }

    /// <summary>
    /// Client for interacting with Azure DevOps services.
    /// </summary>
    public class AzureDevOpsClient : IAzureDevOpsClient
    {
        private readonly VssConnection _connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureDevOpsClient"/> class with the specified organization URL and personal access token.
        /// </summary>
        /// <param name="organisationUrl">The organization URL.</param>
        /// <param name="personalAccessToken">The personal access token.</param>
        /// <exception cref="ArgumentException">Thrown when the organization URL or personal access token is null or empty, or when the organization URL is not a valid URL.</exception>
        public AzureDevOpsClient(string organisationUrl, string personalAccessToken)
        {
            if (string.IsNullOrEmpty(organisationUrl))
            {
                throw new ArgumentException("Organization URL cannot be null or empty.", nameof(organisationUrl));
            }

            if (!Uri.IsWellFormedUriString(organisationUrl, UriKind.Absolute))
            {
                throw new ArgumentException("Organization URL is not a valid URL.", nameof(organisationUrl));
            }

            if (string.IsNullOrEmpty(personalAccessToken))
            {
                throw new ArgumentException("Personal access token cannot be null or empty.", nameof(personalAccessToken));
            }

            _connection = new VssConnection(new Uri(organisationUrl), new VssBasicCredential(string.Empty, personalAccessToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureDevOpsClient"/> class.
        /// </summary>
        /// <param name="configSettings">The Azure DevOps configuration settings.</param>
        /// <exception cref="ArgumentNullException">Thrown when configSettings is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the organization URL is null, empty, or not a valid URL.</exception>
        public AzureDevOpsClient(AzureDevOpsSettings configSettings) : this(configSettings.OrganizationUrl, configSettings.PersonalAccessToken)
        {
            ArgumentNullException.ThrowIfNull(configSettings);
        }

        /// <summary>
        /// Gets the Git client for querying Git repositories in Azure DevOps.
        /// </summary>
        /// <returns>The Git client.</returns>
        public virtual GitHttpClient GetGitClient()
        {
            return _connection.GetClient<GitHttpClient>();
        }

        /// <summary>
        /// Gets the WorkItem client for querying work items in Azure DevOps.
        /// </summary>
        /// <returns>The WorkItem client.</returns>
        public virtual WorkItemTrackingHttpClient GetWorkItemClient()
        {
            return _connection.GetClient<WorkItemTrackingHttpClient>();
        }
    }
}

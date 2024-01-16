﻿using CSharp_AzureDevopsNotifier.Entities;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;

namespace CSharp_AzureDevopsNotifier
{
    /// <summary>
    /// Create connection to AzureDevOps
    /// </summary>
    /// <param name="configSettings"></param>
    public class AzureDevOpsClient
    {
        private readonly VssConnection connection;

        public AzureDevOpsClient(AzureDevOpsSettings configSettings)
        {
            ArgumentNullException.ThrowIfNull(configSettings);
            connection = new VssConnection(new Uri(configSettings.OrganizationUrl), new VssBasicCredential(string.Empty, configSettings.PersonalAccessToken));
        }

        /// <summary>
        /// Get client to query Git part of Azure
        /// </summary>
        /// <returns></returns>
        public GitHttpClient GetGitClient()
        {
            return connection.GetClient<GitHttpClient>();
        }

        /// <summary>
        /// Get client to query WorkItem part of Azure
        /// </summary>
        /// <returns></returns>
        public WorkItemTrackingHttpClient GetWorkItemClient()
        {
            return connection.GetClient<WorkItemTrackingHttpClient>();
        }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.PostgreSql.FlexibleServers. </summary>
    public static partial class FlexibleServersExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary>
        /// Get private DNS zone suffix in the cloud
        /// Request Path: /providers/Microsoft.DBforPostgreSQL/getPrivateDnsZoneSuffix
        /// Operation Id: GetPrivateDnsZoneSuffix_Execute
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<string>> ExecuteGetPrivateDnsZoneSuffixAsync(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(tenantResource).ExecuteGetPrivateDnsZoneSuffixAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get private DNS zone suffix in the cloud
        /// Request Path: /providers/Microsoft.DBforPostgreSQL/getPrivateDnsZoneSuffix
        /// Operation Id: GetPrivateDnsZoneSuffix_Execute
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<string> ExecuteGetPrivateDnsZoneSuffix(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenantResource).ExecuteGetPrivateDnsZoneSuffix(cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/flexibleServers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ServerResource> GetServersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetServersAsync(cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/flexibleServers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ServerResource> GetServers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetServers(cancellationToken);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability
        /// Operation Id: CheckNameAvailability_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<NameAvailability>> ExecuteCheckNameAvailabilityAsync(this SubscriptionResource subscriptionResource, NameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).ExecuteCheckNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability
        /// Operation Id: CheckNameAvailability_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<NameAvailability> ExecuteCheckNameAvailability(this SubscriptionResource subscriptionResource, NameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).ExecuteCheckNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/capabilities
        /// Operation Id: LocationBasedCapabilities_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> An async collection of <see cref="CapabilityProperties" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<CapabilityProperties> ExecuteLocationBasedCapabilitiesAsync(this SubscriptionResource subscriptionResource, string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            return GetExtensionClient(subscriptionResource).ExecuteLocationBasedCapabilitiesAsync(locationName, cancellationToken);
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/capabilities
        /// Operation Id: LocationBasedCapabilities_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> A collection of <see cref="CapabilityProperties" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<CapabilityProperties> ExecuteLocationBasedCapabilities(this SubscriptionResource subscriptionResource, string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            return GetExtensionClient(subscriptionResource).ExecuteLocationBasedCapabilities(locationName, cancellationToken);
        }

        /// <summary>
        /// Get virtual network subnet usage for a given vNet resource id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/checkVirtualNetworkSubnetUsage
        /// Operation Id: VirtualNetworkSubnetUsage_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="virtualNetworkSubnetUsageParameter"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="virtualNetworkSubnetUsageParameter"/> is null. </exception>
        public static async Task<Response<VirtualNetworkSubnetUsageResult>> ExecuteVirtualNetworkSubnetUsageAsync(this SubscriptionResource subscriptionResource, string locationName, VirtualNetworkSubnetUsageParameter virtualNetworkSubnetUsageParameter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNull(virtualNetworkSubnetUsageParameter, nameof(virtualNetworkSubnetUsageParameter));

            return await GetExtensionClient(subscriptionResource).ExecuteVirtualNetworkSubnetUsageAsync(locationName, virtualNetworkSubnetUsageParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get virtual network subnet usage for a given vNet resource id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/checkVirtualNetworkSubnetUsage
        /// Operation Id: VirtualNetworkSubnetUsage_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="virtualNetworkSubnetUsageParameter"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="virtualNetworkSubnetUsageParameter"/> is null. </exception>
        public static Response<VirtualNetworkSubnetUsageResult> ExecuteVirtualNetworkSubnetUsage(this SubscriptionResource subscriptionResource, string locationName, VirtualNetworkSubnetUsageParameter virtualNetworkSubnetUsageParameter, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNull(virtualNetworkSubnetUsageParameter, nameof(virtualNetworkSubnetUsageParameter));

            return GetExtensionClient(subscriptionResource).ExecuteVirtualNetworkSubnetUsage(locationName, virtualNetworkSubnetUsageParameter, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ServerResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ServerResources and their operations over a ServerResource. </returns>
        public static ServerCollection GetServers(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetServers();
        }

        /// <summary>
        /// Gets information about a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ServerResource>> GetServerAsync(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetServers().GetAsync(serverName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ServerResource> GetServer(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetServers().Get(serverName, cancellationToken);
        }

        #region ServerResource
        /// <summary>
        /// Gets an object representing a <see cref="ServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServerResource.CreateResourceIdentifier" /> to create a <see cref="ServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServerResource" /> object. </returns>
        public static ServerResource GetServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServerResource.ValidateResourceId(id);
                return new ServerResource(client, id);
            }
            );
        }
        #endregion

        #region FirewallRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="FirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="FirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FirewallRuleResource" /> object. </returns>
        public static FirewallRuleResource GetFirewallRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FirewallRuleResource.ValidateResourceId(id);
                return new FirewallRuleResource(client, id);
            }
            );
        }
        #endregion

        #region ConfigurationResource
        /// <summary>
        /// Gets an object representing a <see cref="ConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="ConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConfigurationResource" /> object. </returns>
        public static ConfigurationResource GetConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ConfigurationResource.ValidateResourceId(id);
                return new ConfigurationResource(client, id);
            }
            );
        }
        #endregion

        #region DatabaseResource
        /// <summary>
        /// Gets an object representing a <see cref="DatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DatabaseResource.CreateResourceIdentifier" /> to create a <see cref="DatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DatabaseResource" /> object. </returns>
        public static DatabaseResource GetDatabaseResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DatabaseResource.ValidateResourceId(id);
                return new DatabaseResource(client, id);
            }
            );
        }
        #endregion
    }
}

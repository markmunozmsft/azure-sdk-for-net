// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class FirewallPolicyRuleCollectionGroupOperationSource : IOperationSource<FirewallPolicyRuleCollectionGroupResource>
    {
        private readonly ArmClient _client;

        internal FirewallPolicyRuleCollectionGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        FirewallPolicyRuleCollectionGroupResource IOperationSource<FirewallPolicyRuleCollectionGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<FirewallPolicyRuleCollectionGroupData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return new FirewallPolicyRuleCollectionGroupResource(_client, data);
        }

        async ValueTask<FirewallPolicyRuleCollectionGroupResource> IOperationSource<FirewallPolicyRuleCollectionGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<FirewallPolicyRuleCollectionGroupData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return await Task.FromResult(new FirewallPolicyRuleCollectionGroupResource(_client, data)).ConfigureAwait(false);
        }
    }
}

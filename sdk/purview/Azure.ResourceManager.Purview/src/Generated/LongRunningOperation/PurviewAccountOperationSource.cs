// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Purview
{
    internal class PurviewAccountOperationSource : IOperationSource<PurviewAccountResource>
    {
        private readonly ArmClient _client;

        internal PurviewAccountOperationSource(ArmClient client)
        {
            _client = client;
        }

        PurviewAccountResource IOperationSource<PurviewAccountResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PurviewAccountData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerPurviewContext.Default);
            return new PurviewAccountResource(_client, data);
        }

        async ValueTask<PurviewAccountResource> IOperationSource<PurviewAccountResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PurviewAccountData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerPurviewContext.Default);
            return await Task.FromResult(new PurviewAccountResource(_client, data)).ConfigureAwait(false);
        }
    }
}

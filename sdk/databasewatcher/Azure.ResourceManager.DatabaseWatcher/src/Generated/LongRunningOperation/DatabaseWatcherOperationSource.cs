// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DatabaseWatcher
{
    internal class DatabaseWatcherOperationSource : IOperationSource<DatabaseWatcherResource>
    {
        private readonly ArmClient _client;

        internal DatabaseWatcherOperationSource(ArmClient client)
        {
            _client = client;
        }

        DatabaseWatcherResource IOperationSource<DatabaseWatcherResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DatabaseWatcherData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDatabaseWatcherContext.Default);
            return new DatabaseWatcherResource(_client, data);
        }

        async ValueTask<DatabaseWatcherResource> IOperationSource<DatabaseWatcherResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DatabaseWatcherData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDatabaseWatcherContext.Default);
            return await Task.FromResult(new DatabaseWatcherResource(_client, data)).ConfigureAwait(false);
        }
    }
}

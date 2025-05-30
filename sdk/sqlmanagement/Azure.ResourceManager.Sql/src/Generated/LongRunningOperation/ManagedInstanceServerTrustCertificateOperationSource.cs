// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class ManagedInstanceServerTrustCertificateOperationSource : IOperationSource<ManagedInstanceServerTrustCertificateResource>
    {
        private readonly ArmClient _client;

        internal ManagedInstanceServerTrustCertificateOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedInstanceServerTrustCertificateResource IOperationSource<ManagedInstanceServerTrustCertificateResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ServerTrustCertificateData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSqlContext.Default);
            return new ManagedInstanceServerTrustCertificateResource(_client, data);
        }

        async ValueTask<ManagedInstanceServerTrustCertificateResource> IOperationSource<ManagedInstanceServerTrustCertificateResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ServerTrustCertificateData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerSqlContext.Default);
            return await Task.FromResult(new ManagedInstanceServerTrustCertificateResource(_client, data)).ConfigureAwait(false);
        }
    }
}

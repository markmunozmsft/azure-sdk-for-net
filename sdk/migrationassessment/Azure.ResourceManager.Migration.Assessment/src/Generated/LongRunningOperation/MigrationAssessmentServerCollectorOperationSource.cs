// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Migration.Assessment
{
    internal class MigrationAssessmentServerCollectorOperationSource : IOperationSource<MigrationAssessmentServerCollectorResource>
    {
        private readonly ArmClient _client;

        internal MigrationAssessmentServerCollectorOperationSource(ArmClient client)
        {
            _client = client;
        }

        MigrationAssessmentServerCollectorResource IOperationSource<MigrationAssessmentServerCollectorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MigrationAssessmentServerCollectorData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMigrationAssessmentContext.Default);
            return new MigrationAssessmentServerCollectorResource(_client, data);
        }

        async ValueTask<MigrationAssessmentServerCollectorResource> IOperationSource<MigrationAssessmentServerCollectorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<MigrationAssessmentServerCollectorData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMigrationAssessmentContext.Default);
            return await Task.FromResult(new MigrationAssessmentServerCollectorResource(_client, data)).ConfigureAwait(false);
        }
    }
}

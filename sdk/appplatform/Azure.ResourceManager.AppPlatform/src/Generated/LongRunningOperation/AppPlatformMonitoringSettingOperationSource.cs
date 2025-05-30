// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform
{
    internal class AppPlatformMonitoringSettingOperationSource : IOperationSource<AppPlatformMonitoringSettingResource>
    {
        private readonly ArmClient _client;

        internal AppPlatformMonitoringSettingOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppPlatformMonitoringSettingResource IOperationSource<AppPlatformMonitoringSettingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AppPlatformMonitoringSettingData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerAppPlatformContext.Default);
            return new AppPlatformMonitoringSettingResource(_client, data);
        }

        async ValueTask<AppPlatformMonitoringSettingResource> IOperationSource<AppPlatformMonitoringSettingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<AppPlatformMonitoringSettingData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerAppPlatformContext.Default);
            return await Task.FromResult(new AppPlatformMonitoringSettingResource(_client, data)).ConfigureAwait(false);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class NetworkInterfaceTapConfigurationResource : IJsonModel<NetworkInterfaceTapConfigurationData>
    {
        void IJsonModel<NetworkInterfaceTapConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetworkInterfaceTapConfigurationData>)Data).Write(writer, options);

        NetworkInterfaceTapConfigurationData IJsonModel<NetworkInterfaceTapConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetworkInterfaceTapConfigurationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<NetworkInterfaceTapConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<NetworkInterfaceTapConfigurationData>(Data, options, AzureResourceManagerNetworkContext.Default);

        NetworkInterfaceTapConfigurationData IPersistableModel<NetworkInterfaceTapConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetworkInterfaceTapConfigurationData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<NetworkInterfaceTapConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetworkInterfaceTapConfigurationData>)Data).GetFormatFromOptions(options);
    }
}

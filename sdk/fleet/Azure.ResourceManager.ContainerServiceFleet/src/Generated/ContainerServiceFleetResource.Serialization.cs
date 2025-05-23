// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerServiceFleet
{
    public partial class ContainerServiceFleetResource : IJsonModel<ContainerServiceFleetData>
    {
        void IJsonModel<ContainerServiceFleetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ContainerServiceFleetData>)Data).Write(writer, options);

        ContainerServiceFleetData IJsonModel<ContainerServiceFleetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ContainerServiceFleetData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ContainerServiceFleetData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ContainerServiceFleetData>(Data, options, AzureResourceManagerContainerServiceFleetContext.Default);

        ContainerServiceFleetData IPersistableModel<ContainerServiceFleetData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ContainerServiceFleetData>(data, options, AzureResourceManagerContainerServiceFleetContext.Default);

        string IPersistableModel<ContainerServiceFleetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ContainerServiceFleetData>)Data).GetFormatFromOptions(options);
    }
}

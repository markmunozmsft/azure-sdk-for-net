// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    public partial class KubernetesFluxConfigurationResource : IJsonModel<KubernetesFluxConfigurationData>
    {
        void IJsonModel<KubernetesFluxConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<KubernetesFluxConfigurationData>)Data).Write(writer, options);

        KubernetesFluxConfigurationData IJsonModel<KubernetesFluxConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<KubernetesFluxConfigurationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<KubernetesFluxConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<KubernetesFluxConfigurationData>(Data, options, AzureResourceManagerKubernetesConfigurationContext.Default);

        KubernetesFluxConfigurationData IPersistableModel<KubernetesFluxConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<KubernetesFluxConfigurationData>(data, options, AzureResourceManagerKubernetesConfigurationContext.Default);

        string IPersistableModel<KubernetesFluxConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<KubernetesFluxConfigurationData>)Data).GetFormatFromOptions(options);
    }
}

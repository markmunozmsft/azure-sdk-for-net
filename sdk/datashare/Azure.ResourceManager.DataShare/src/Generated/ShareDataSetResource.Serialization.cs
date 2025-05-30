// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataShare
{
    public partial class ShareDataSetResource : IJsonModel<ShareDataSetData>
    {
        void IJsonModel<ShareDataSetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ShareDataSetData>)Data).Write(writer, options);

        ShareDataSetData IJsonModel<ShareDataSetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ShareDataSetData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ShareDataSetData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ShareDataSetData>(Data, options, AzureResourceManagerDataShareContext.Default);

        ShareDataSetData IPersistableModel<ShareDataSetData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ShareDataSetData>(data, options, AzureResourceManagerDataShareContext.Default);

        string IPersistableModel<ShareDataSetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ShareDataSetData>)Data).GetFormatFromOptions(options);
    }
}

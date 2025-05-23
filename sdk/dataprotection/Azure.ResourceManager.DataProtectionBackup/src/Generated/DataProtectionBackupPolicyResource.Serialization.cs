// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataProtectionBackup
{
    public partial class DataProtectionBackupPolicyResource : IJsonModel<DataProtectionBackupPolicyData>
    {
        void IJsonModel<DataProtectionBackupPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataProtectionBackupPolicyData>)Data).Write(writer, options);

        DataProtectionBackupPolicyData IJsonModel<DataProtectionBackupPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataProtectionBackupPolicyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DataProtectionBackupPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DataProtectionBackupPolicyData>(Data, options, AzureResourceManagerDataProtectionBackupContext.Default);

        DataProtectionBackupPolicyData IPersistableModel<DataProtectionBackupPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataProtectionBackupPolicyData>(data, options, AzureResourceManagerDataProtectionBackupContext.Default);

        string IPersistableModel<DataProtectionBackupPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataProtectionBackupPolicyData>)Data).GetFormatFromOptions(options);
    }
}

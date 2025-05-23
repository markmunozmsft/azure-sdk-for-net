// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkCloudAgentPoolPatch : IUtf8JsonSerializable, IJsonModel<NetworkCloudAgentPoolPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudAgentPoolPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkCloudAgentPoolPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudAgentPoolPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudAgentPoolPatch)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorConfiguration))
            {
                writer.WritePropertyName("administratorConfiguration"u8);
                writer.WriteObjectValue(AdministratorConfiguration, options);
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(UpgradeSettings))
            {
                writer.WritePropertyName("upgradeSettings"u8);
                writer.WriteObjectValue(UpgradeSettings, options);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        NetworkCloudAgentPoolPatch IJsonModel<NetworkCloudAgentPoolPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudAgentPoolPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudAgentPoolPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudAgentPoolPatch(document.RootElement, options);
        }

        internal static NetworkCloudAgentPoolPatch DeserializeNetworkCloudAgentPoolPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            NodePoolAdministratorConfigurationPatch administratorConfiguration = default;
            long? count = default;
            AgentPoolUpgradeSettings upgradeSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("administratorConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administratorConfiguration = NodePoolAdministratorConfigurationPatch.DeserializeNodePoolAdministratorConfigurationPatch(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("count"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            count = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("upgradeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeSettings = AgentPoolUpgradeSettings.DeserializeAgentPoolUpgradeSettings(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkCloudAgentPoolPatch(tags ?? new ChangeTrackingDictionary<string, string>(), administratorConfiguration, count, upgradeSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudAgentPoolPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudAgentPoolPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkCloudContext.Default);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudAgentPoolPatch)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkCloudAgentPoolPatch IPersistableModel<NetworkCloudAgentPoolPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudAgentPoolPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetworkCloudAgentPoolPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudAgentPoolPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudAgentPoolPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

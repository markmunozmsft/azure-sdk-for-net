// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubNetworkRuleSetIPRule : IUtf8JsonSerializable, IJsonModel<IotHubNetworkRuleSetIPRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubNetworkRuleSetIPRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotHubNetworkRuleSetIPRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubNetworkRuleSetIPRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubNetworkRuleSetIPRule)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("filterName"u8);
            writer.WriteStringValue(FilterName);
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            writer.WritePropertyName("ipMask"u8);
            writer.WriteStringValue(IPMask);
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

        IotHubNetworkRuleSetIPRule IJsonModel<IotHubNetworkRuleSetIPRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubNetworkRuleSetIPRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubNetworkRuleSetIPRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubNetworkRuleSetIPRule(document.RootElement, options);
        }

        internal static IotHubNetworkRuleSetIPRule DeserializeIotHubNetworkRuleSetIPRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string filterName = default;
            IotHubNetworkRuleIPAction? action = default;
            string ipMask = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filterName"u8))
                {
                    filterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new IotHubNetworkRuleIPAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipMask"u8))
                {
                    ipMask = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotHubNetworkRuleSetIPRule(filterName, action, ipMask, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubNetworkRuleSetIPRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubNetworkRuleSetIPRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerIotHubContext.Default);
                default:
                    throw new FormatException($"The model {nameof(IotHubNetworkRuleSetIPRule)} does not support writing '{options.Format}' format.");
            }
        }

        IotHubNetworkRuleSetIPRule IPersistableModel<IotHubNetworkRuleSetIPRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubNetworkRuleSetIPRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIotHubNetworkRuleSetIPRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubNetworkRuleSetIPRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubNetworkRuleSetIPRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

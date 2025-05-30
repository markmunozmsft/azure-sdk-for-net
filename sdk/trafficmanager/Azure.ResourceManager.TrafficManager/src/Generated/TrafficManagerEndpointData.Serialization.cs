// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    public partial class TrafficManagerEndpointData : IUtf8JsonSerializable, IJsonModel<TrafficManagerEndpointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrafficManagerEndpointData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TrafficManagerEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficManagerEndpointData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceId"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsDefined(EndpointStatus))
            {
                writer.WritePropertyName("endpointStatus"u8);
                writer.WriteStringValue(EndpointStatus.Value.ToString());
            }
            if (Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteNumberValue(Weight.Value);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(EndpointLocation))
            {
                writer.WritePropertyName("endpointLocation"u8);
                writer.WriteStringValue(EndpointLocation);
            }
            if (Optional.IsDefined(EndpointMonitorStatus))
            {
                writer.WritePropertyName("endpointMonitorStatus"u8);
                writer.WriteStringValue(EndpointMonitorStatus.Value.ToString());
            }
            if (Optional.IsDefined(MinChildEndpoints))
            {
                if (MinChildEndpoints != null)
                {
                    writer.WritePropertyName("minChildEndpoints"u8);
                    writer.WriteNumberValue(MinChildEndpoints.Value);
                }
                else
                {
                    writer.WriteNull("minChildEndpoints");
                }
            }
            if (Optional.IsDefined(MinChildEndpointsIPv4))
            {
                if (MinChildEndpointsIPv4 != null)
                {
                    writer.WritePropertyName("minChildEndpointsIPv4"u8);
                    writer.WriteNumberValue(MinChildEndpointsIPv4.Value);
                }
                else
                {
                    writer.WriteNull("minChildEndpointsIPv4");
                }
            }
            if (Optional.IsDefined(MinChildEndpointsIPv6))
            {
                if (MinChildEndpointsIPv6 != null)
                {
                    writer.WritePropertyName("minChildEndpointsIPv6"u8);
                    writer.WriteNumberValue(MinChildEndpointsIPv6.Value);
                }
                else
                {
                    writer.WriteNull("minChildEndpointsIPv6");
                }
            }
            if (Optional.IsCollectionDefined(GeoMapping))
            {
                writer.WritePropertyName("geoMapping"u8);
                writer.WriteStartArray();
                foreach (var item in GeoMapping)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Subnets))
            {
                writer.WritePropertyName("subnets"u8);
                writer.WriteStartArray();
                foreach (var item in Subnets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CustomHeaders))
            {
                writer.WritePropertyName("customHeaders"u8);
                writer.WriteStartArray();
                foreach (var item in CustomHeaders)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AlwaysServe))
            {
                writer.WritePropertyName("alwaysServe"u8);
                writer.WriteStringValue(AlwaysServe.Value.ToString());
            }
            writer.WriteEndObject();
        }

        TrafficManagerEndpointData IJsonModel<TrafficManagerEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficManagerEndpointData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficManagerEndpointData(document.RootElement, options);
        }

        internal static TrafficManagerEndpointData DeserializeTrafficManagerEndpointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            ResourceIdentifier targetResourceId = default;
            string target = default;
            TrafficManagerEndpointStatus? endpointStatus = default;
            long? weight = default;
            long? priority = default;
            string endpointLocation = default;
            TrafficManagerEndpointMonitorStatus? endpointMonitorStatus = default;
            long? minChildEndpoints = default;
            long? minChildEndpointsIPv4 = default;
            long? minChildEndpointsIPv6 = default;
            IList<string> geoMapping = default;
            IList<TrafficManagerEndpointSubnetInfo> subnets = default;
            IList<TrafficManagerEndpointCustomHeaderInfo> customHeaders = default;
            TrafficManagerEndpointAlwaysServeStatus? alwaysServe = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("targetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("target"u8))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpointStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointStatus = new TrafficManagerEndpointStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("weight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weight = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("endpointLocation"u8))
                        {
                            endpointLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpointMonitorStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointMonitorStatus = new TrafficManagerEndpointMonitorStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("minChildEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                minChildEndpoints = null;
                                continue;
                            }
                            minChildEndpoints = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("minChildEndpointsIPv4"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                minChildEndpointsIPv4 = null;
                                continue;
                            }
                            minChildEndpointsIPv4 = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("minChildEndpointsIPv6"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                minChildEndpointsIPv6 = null;
                                continue;
                            }
                            minChildEndpointsIPv6 = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("geoMapping"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            geoMapping = array;
                            continue;
                        }
                        if (property0.NameEquals("subnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrafficManagerEndpointSubnetInfo> array = new List<TrafficManagerEndpointSubnetInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrafficManagerEndpointSubnetInfo.DeserializeTrafficManagerEndpointSubnetInfo(item, options));
                            }
                            subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("customHeaders"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrafficManagerEndpointCustomHeaderInfo> array = new List<TrafficManagerEndpointCustomHeaderInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrafficManagerEndpointCustomHeaderInfo.DeserializeTrafficManagerEndpointCustomHeaderInfo(item, options));
                            }
                            customHeaders = array;
                            continue;
                        }
                        if (property0.NameEquals("alwaysServe"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alwaysServe = new TrafficManagerEndpointAlwaysServeStatus(property0.Value.GetString());
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
            return new TrafficManagerEndpointData(
                id,
                name,
                type,
                serializedAdditionalRawData,
                targetResourceId,
                target,
                endpointStatus,
                weight,
                priority,
                endpointLocation,
                endpointMonitorStatus,
                minChildEndpoints,
                minChildEndpointsIPv4,
                minChildEndpointsIPv6,
                geoMapping ?? new ChangeTrackingList<string>(),
                subnets ?? new ChangeTrackingList<TrafficManagerEndpointSubnetInfo>(),
                customHeaders ?? new ChangeTrackingList<TrafficManagerEndpointCustomHeaderInfo>(),
                alwaysServe);
        }

        BinaryData IPersistableModel<TrafficManagerEndpointData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerTrafficManagerContext.Default);
                default:
                    throw new FormatException($"The model {nameof(TrafficManagerEndpointData)} does not support writing '{options.Format}' format.");
            }
        }

        TrafficManagerEndpointData IPersistableModel<TrafficManagerEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTrafficManagerEndpointData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrafficManagerEndpointData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrafficManagerEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

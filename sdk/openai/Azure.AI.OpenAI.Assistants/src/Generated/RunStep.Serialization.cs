// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    public partial class RunStep : IUtf8JsonSerializable, IJsonModel<RunStep>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RunStep>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RunStep>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStep)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("assistant_id"u8);
            writer.WriteStringValue(AssistantId);
            writer.WritePropertyName("thread_id"u8);
            writer.WriteStringValue(ThreadId);
            writer.WritePropertyName("run_id"u8);
            writer.WriteStringValue(RunId);
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("step_details"u8);
            writer.WriteObjectValue(StepDetails, options);
            if (LastError != null)
            {
                writer.WritePropertyName("last_error"u8);
                writer.WriteObjectValue(LastError, options);
            }
            else
            {
                writer.WriteNull("last_error");
            }
            writer.WritePropertyName("created_at"u8);
            writer.WriteNumberValue(CreatedAt, "U");
            if (ExpiredAt != null)
            {
                writer.WritePropertyName("expired_at"u8);
                writer.WriteNumberValue(ExpiredAt.Value, "U");
            }
            else
            {
                writer.WriteNull("expired_at");
            }
            if (CompletedAt != null)
            {
                writer.WritePropertyName("completed_at"u8);
                writer.WriteNumberValue(CompletedAt.Value, "U");
            }
            else
            {
                writer.WriteNull("completed_at");
            }
            if (CancelledAt != null)
            {
                writer.WritePropertyName("cancelled_at"u8);
                writer.WriteNumberValue(CancelledAt.Value, "U");
            }
            else
            {
                writer.WriteNull("cancelled_at");
            }
            if (FailedAt != null)
            {
                writer.WritePropertyName("failed_at"u8);
                writer.WriteNumberValue(FailedAt.Value, "U");
            }
            else
            {
                writer.WriteNull("failed_at");
            }
            if (Metadata != null && Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNull("metadata");
            }
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

        RunStep IJsonModel<RunStep>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStep)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunStep(document.RootElement, options);
        }

        internal static RunStep DeserializeRunStep(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string @object = default;
            RunStepType type = default;
            string assistantId = default;
            string threadId = default;
            string runId = default;
            RunStepStatus status = default;
            RunStepDetails stepDetails = default;
            RunStepError lastError = default;
            DateTimeOffset createdAt = default;
            DateTimeOffset? expiredAt = default;
            DateTimeOffset? completedAt = default;
            DateTimeOffset? cancelledAt = default;
            DateTimeOffset? failedAt = default;
            IReadOnlyDictionary<string, string> metadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("object"u8))
                {
                    @object = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new RunStepType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assistant_id"u8))
                {
                    assistantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thread_id"u8))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("run_id"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new RunStepStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("step_details"u8))
                {
                    stepDetails = RunStepDetails.DeserializeRunStepDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("last_error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastError = null;
                        continue;
                    }
                    lastError = RunStepError.DeserializeRunStepError(property.Value, options);
                    continue;
                }
                if (property.NameEquals("created_at"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("expired_at"u8))
                {
                    DeserializeNullableDateTimeOffset(property, ref expiredAt);
                    continue;
                }
                if (property.NameEquals("completed_at"u8))
                {
                    DeserializeNullableDateTimeOffset(property, ref completedAt);
                    continue;
                }
                if (property.NameEquals("cancelled_at"u8))
                {
                    DeserializeNullableDateTimeOffset(property, ref cancelledAt);
                    continue;
                }
                if (property.NameEquals("failed_at"u8))
                {
                    DeserializeNullableDateTimeOffset(property, ref failedAt);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        metadata = new ChangeTrackingDictionary<string, string>();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RunStep(
                id,
                @object,
                type,
                assistantId,
                threadId,
                runId,
                status,
                stepDetails,
                lastError,
                createdAt,
                expiredAt,
                completedAt,
                cancelledAt,
                failedAt,
                metadata,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunStep>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStep>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIOpenAIAssistantsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RunStep)} does not support writing '{options.Format}' format.");
            }
        }

        RunStep IPersistableModel<RunStep>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStep>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRunStep(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunStep)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunStep>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RunStep FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeRunStep(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}

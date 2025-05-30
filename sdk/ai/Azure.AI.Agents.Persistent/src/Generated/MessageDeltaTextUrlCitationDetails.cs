// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> A representation of a URL citation, as used in text thread message content. </summary>
    public partial class MessageDeltaTextUrlCitationDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MessageDeltaTextUrlCitationDetails"/>. </summary>
        /// <param name="url"> The URL associated with this citation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        internal MessageDeltaTextUrlCitationDetails(string url)
        {
            Argument.AssertNotNull(url, nameof(url));

            Url = url;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaTextUrlCitationDetails"/>. </summary>
        /// <param name="url"> The URL associated with this citation. </param>
        /// <param name="title"> The title of the URL. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MessageDeltaTextUrlCitationDetails(string url, string title, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Url = url;
            Title = title;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaTextUrlCitationDetails"/> for deserialization. </summary>
        internal MessageDeltaTextUrlCitationDetails()
        {
        }

        /// <summary> The URL associated with this citation. </summary>
        public string Url { get; }
        /// <summary> The title of the URL. </summary>
        public string Title { get; }
    }
}

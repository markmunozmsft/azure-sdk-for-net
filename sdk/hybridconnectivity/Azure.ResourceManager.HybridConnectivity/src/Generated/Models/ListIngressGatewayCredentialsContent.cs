// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridConnectivity.Models
{
    /// <summary> Represent ListIngressGatewayCredentials Request object. </summary>
    public partial class ListIngressGatewayCredentialsContent
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

        /// <summary> Initializes a new instance of <see cref="ListIngressGatewayCredentialsContent"/>. </summary>
        public ListIngressGatewayCredentialsContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ListIngressGatewayCredentialsContent"/>. </summary>
        /// <param name="serviceName"> The name of the service. If not provided, the request will by pass the generation of service configuration token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ListIngressGatewayCredentialsContent(HybridConnectivityServiceName? serviceName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServiceName = serviceName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the service. If not provided, the request will by pass the generation of service configuration token. </summary>
        public HybridConnectivityServiceName? ServiceName { get; set; }
    }
}

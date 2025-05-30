// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity for Microsoft Fabric Lakehouse Table sink. </summary>
    public partial class LakeHouseTableSink : CopySink
    {
        /// <summary> Initializes a new instance of <see cref="LakeHouseTableSink"/>. </summary>
        public LakeHouseTableSink()
        {
            Type = "LakeHouseTableSink";
        }

        /// <summary> Initializes a new instance of <see cref="LakeHouseTableSink"/>. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="tableActionOption"> The type of table action for Lakehouse Table sink. Possible values include: "None", "Append", "Overwrite". </param>
        /// <param name="partitionOption"> Create partitions in folder structure based on one or multiple columns. Each distinct column value (pair) will be a new partition. Possible values include: "None", "PartitionByKey". </param>
        /// <param name="partitionNameList"> Specify the partition column names from sink columns. Type: array of objects (or Expression with resultType array of objects). </param>
        internal LakeHouseTableSink(string type, object writeBatchSize, object writeBatchTimeout, object sinkRetryCount, object sinkRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object tableActionOption, object partitionOption, object partitionNameList) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties)
        {
            TableActionOption = tableActionOption;
            PartitionOption = partitionOption;
            PartitionNameList = partitionNameList;
            Type = type ?? "LakeHouseTableSink";
        }

        /// <summary> The type of table action for Lakehouse Table sink. Possible values include: "None", "Append", "Overwrite". </summary>
        public object TableActionOption { get; set; }
        /// <summary> Create partitions in folder structure based on one or multiple columns. Each distinct column value (pair) will be a new partition. Possible values include: "None", "PartitionByKey". </summary>
        public object PartitionOption { get; set; }
        /// <summary> Specify the partition column names from sink columns. Type: array of objects (or Expression with resultType array of objects). </summary>
        public object PartitionNameList { get; set; }
    }
}

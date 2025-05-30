// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> BatchNodeReimageOption enums. </summary>
    public readonly partial struct BatchNodeReimageOption : IEquatable<BatchNodeReimageOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchNodeReimageOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchNodeReimageOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RequeueValue = "requeue";
        private const string TerminateValue = "terminate";
        private const string TaskCompletionValue = "taskcompletion";
        private const string RetainedDataValue = "retaineddata";

        /// <summary> Terminate running Task processes and requeue the Tasks. The Tasks will run again when a Compute Node is available. Reimage the Compute Node as soon as Tasks have been terminated. </summary>
        public static BatchNodeReimageOption Requeue { get; } = new BatchNodeReimageOption(RequeueValue);
        /// <summary> Terminate running Tasks. The Tasks will be completed with failureInfo indicating that they were terminated, and will not run again. Reimage the Compute Node as soon as Tasks have been terminated. </summary>
        public static BatchNodeReimageOption Terminate { get; } = new BatchNodeReimageOption(TerminateValue);
        /// <summary> Allow currently running Tasks to complete. Schedule no new Tasks while waiting. Reimage the Compute Node when all Tasks have completed. </summary>
        public static BatchNodeReimageOption TaskCompletion { get; } = new BatchNodeReimageOption(TaskCompletionValue);
        /// <summary> Allow currently running Tasks to complete, then wait for all Task data retention periods to expire. Schedule no new Tasks while waiting. Reimage the Compute Node when all Task retention periods have expired. </summary>
        public static BatchNodeReimageOption RetainedData { get; } = new BatchNodeReimageOption(RetainedDataValue);
        /// <summary> Determines if two <see cref="BatchNodeReimageOption"/> values are the same. </summary>
        public static bool operator ==(BatchNodeReimageOption left, BatchNodeReimageOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchNodeReimageOption"/> values are not the same. </summary>
        public static bool operator !=(BatchNodeReimageOption left, BatchNodeReimageOption right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BatchNodeReimageOption"/>. </summary>
        public static implicit operator BatchNodeReimageOption(string value) => new BatchNodeReimageOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchNodeReimageOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchNodeReimageOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

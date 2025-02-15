// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The current status of the run. </summary>
    public readonly partial struct RunStatus : IEquatable<RunStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RunStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RunStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QueuedValue = "Queued";
        private const string StartedValue = "Started";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string ErrorValue = "Error";
        private const string TimeoutValue = "Timeout";

        /// <summary> Queued. </summary>
        public static RunStatus Queued { get; } = new RunStatus(QueuedValue);
        /// <summary> Started. </summary>
        public static RunStatus Started { get; } = new RunStatus(StartedValue);
        /// <summary> Running. </summary>
        public static RunStatus Running { get; } = new RunStatus(RunningValue);
        /// <summary> Succeeded. </summary>
        public static RunStatus Succeeded { get; } = new RunStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static RunStatus Failed { get; } = new RunStatus(FailedValue);
        /// <summary> Canceled. </summary>
        public static RunStatus Canceled { get; } = new RunStatus(CanceledValue);
        /// <summary> Error. </summary>
        public static RunStatus Error { get; } = new RunStatus(ErrorValue);
        /// <summary> Timeout. </summary>
        public static RunStatus Timeout { get; } = new RunStatus(TimeoutValue);
        /// <summary> Determines if two <see cref="RunStatus"/> values are the same. </summary>
        public static bool operator ==(RunStatus left, RunStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RunStatus"/> values are not the same. </summary>
        public static bool operator !=(RunStatus left, RunStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RunStatus"/>. </summary>
        public static implicit operator RunStatus(string value) => new RunStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RunStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

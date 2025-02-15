// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Error code describing the error. </summary>
    public readonly partial struct JobErrorCode : IEquatable<JobErrorCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobErrorCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceErrorValue = "ServiceError";
        private const string ServiceTransientErrorValue = "ServiceTransientError";
        private const string DownloadNotAccessibleValue = "DownloadNotAccessible";
        private const string DownloadTransientErrorValue = "DownloadTransientError";
        private const string UploadNotAccessibleValue = "UploadNotAccessible";
        private const string UploadTransientErrorValue = "UploadTransientError";
        private const string ConfigurationUnsupportedValue = "ConfigurationUnsupported";
        private const string ContentMalformedValue = "ContentMalformed";
        private const string ContentUnsupportedValue = "ContentUnsupported";

        /// <summary> Fatal service error, please contact support. </summary>
        public static JobErrorCode ServiceError { get; } = new JobErrorCode(ServiceErrorValue);
        /// <summary> Transient error, please retry, if retry is unsuccessful, please contact support. </summary>
        public static JobErrorCode ServiceTransientError { get; } = new JobErrorCode(ServiceTransientErrorValue);
        /// <summary> While trying to download the input files, the files were not accessible, please check the availability of the source. </summary>
        public static JobErrorCode DownloadNotAccessible { get; } = new JobErrorCode(DownloadNotAccessibleValue);
        /// <summary> While trying to download the input files, there was an issue during transfer (storage service, network errors), see details and check your source. </summary>
        public static JobErrorCode DownloadTransientError { get; } = new JobErrorCode(DownloadTransientErrorValue);
        /// <summary> While trying to upload the output files, the destination was not reachable, please check the availability of the destination. </summary>
        public static JobErrorCode UploadNotAccessible { get; } = new JobErrorCode(UploadNotAccessibleValue);
        /// <summary> While trying to upload the output files, there was an issue during transfer (storage service, network errors), see details and check your destination. </summary>
        public static JobErrorCode UploadTransientError { get; } = new JobErrorCode(UploadTransientErrorValue);
        /// <summary> There was a problem with the combination of input files and the configuration settings applied, fix the configuration settings and retry with the same input, or change input to match the configuration. </summary>
        public static JobErrorCode ConfigurationUnsupported { get; } = new JobErrorCode(ConfigurationUnsupportedValue);
        /// <summary> There was a problem with the input content (for example: zero byte files, or corrupt/non-decodable files), check the input files. </summary>
        public static JobErrorCode ContentMalformed { get; } = new JobErrorCode(ContentMalformedValue);
        /// <summary> There was a problem with the format of the input (not valid media file, or an unsupported file/codec), check the validity of the input files. </summary>
        public static JobErrorCode ContentUnsupported { get; } = new JobErrorCode(ContentUnsupportedValue);
        /// <summary> Determines if two <see cref="JobErrorCode"/> values are the same. </summary>
        public static bool operator ==(JobErrorCode left, JobErrorCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobErrorCode"/> values are not the same. </summary>
        public static bool operator !=(JobErrorCode left, JobErrorCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobErrorCode"/>. </summary>
        public static implicit operator JobErrorCode(string value) => new JobErrorCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobErrorCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

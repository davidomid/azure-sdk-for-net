// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Represents the confidence scores across all sentiment classes: positive, neutral, negative. </summary>
    internal partial class TargetConfidenceScoreLabel
    {
        /// <summary> Initializes a new instance of TargetConfidenceScoreLabel. </summary>
        /// <param name="positive"></param>
        /// <param name="negative"></param>
        public TargetConfidenceScoreLabel(double positive, double negative)
        {
            Positive = positive;
            Negative = negative;
        }

        /// <summary> Gets or sets the positive. </summary>
        public double Positive { get; set; }
        /// <summary> Gets or sets the negative. </summary>
        public double Negative { get; set; }
    }
}

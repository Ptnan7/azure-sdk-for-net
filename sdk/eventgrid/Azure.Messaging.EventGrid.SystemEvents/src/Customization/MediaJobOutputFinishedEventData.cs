// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Job output finished event data. Schema of the data property of an EventGridEvent for a Microsoft.Media.JobOutputFinished event. </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class MediaJobOutputFinishedEventData : MediaJobOutputStateChangeEventData
    {
        /// <summary> Initializes a new instance of <see cref="MediaJobOutputFinishedEventData"/>. </summary>
        internal MediaJobOutputFinishedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobOutputFinishedEventData"/>. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="output">
        /// Gets the output.
        /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
        /// </param>
        /// <param name="jobCorrelationData"> Gets the Job correlation data. </param>
        internal MediaJobOutputFinishedEventData(MediaJobState? previousState, MediaJobOutput output, IReadOnlyDictionary<string, string> jobCorrelationData) : base(previousState, output, jobCorrelationData)
        {
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Referenced tumbling window trigger dependency. </summary>
    public partial class TumblingWindowTriggerDependencyReference : TriggerDependencyReference
    {
        /// <summary> Initializes a new instance of TumblingWindowTriggerDependencyReference. </summary>
        /// <param name="referenceTrigger"> Referenced trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceTrigger"/> is null. </exception>
        public TumblingWindowTriggerDependencyReference(FactoryTriggerReference referenceTrigger) : base(referenceTrigger)
        {
            Argument.AssertNotNull(referenceTrigger, nameof(referenceTrigger));

            DependencyReferenceType = "TumblingWindowTriggerDependencyReference";
        }

        /// <summary> Initializes a new instance of TumblingWindowTriggerDependencyReference. </summary>
        /// <param name="dependencyReferenceType"> The type of dependency reference. </param>
        /// <param name="referenceTrigger"> Referenced trigger. </param>
        /// <param name="offset"> Timespan applied to the start time of a tumbling window when evaluating dependency. </param>
        /// <param name="size"> The size of the window when evaluating the dependency. If undefined the frequency of the tumbling window will be used. </param>
        internal TumblingWindowTriggerDependencyReference(string dependencyReferenceType, FactoryTriggerReference referenceTrigger, string offset, string size) : base(dependencyReferenceType, referenceTrigger)
        {
            Offset = offset;
            Size = size;
            DependencyReferenceType = dependencyReferenceType ?? "TumblingWindowTriggerDependencyReference";
        }

        /// <summary> Timespan applied to the start time of a tumbling window when evaluating dependency. </summary>
        public string Offset { get; set; }
        /// <summary> The size of the window when evaluating the dependency. If undefined the frequency of the tumbling window will be used. </summary>
        public string Size { get; set; }
    }
}

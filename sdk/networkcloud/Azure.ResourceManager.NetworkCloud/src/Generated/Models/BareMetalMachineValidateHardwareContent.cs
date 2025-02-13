// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachineValidateHardwareParameters represents the body of the request to validate the physical hardware of a bare metal machine. </summary>
    public partial class BareMetalMachineValidateHardwareContent
    {
        /// <summary> Initializes a new instance of BareMetalMachineValidateHardwareContent. </summary>
        /// <param name="validationCategory"> The category of hardware validation to perform. </param>
        public BareMetalMachineValidateHardwareContent(BareMetalMachineHardwareValidationCategory validationCategory)
        {
            ValidationCategory = validationCategory;
        }

        /// <summary> The category of hardware validation to perform. </summary>
        public BareMetalMachineHardwareValidationCategory ValidationCategory { get; }
    }
}

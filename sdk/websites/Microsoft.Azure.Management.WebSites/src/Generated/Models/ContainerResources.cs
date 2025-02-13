// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Container App container resource requirements.
    /// </summary>
    public partial class ContainerResources
    {
        /// <summary>
        /// Initializes a new instance of the ContainerResources class.
        /// </summary>
        public ContainerResources()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerResources class.
        /// </summary>
        /// <param name="cpu">Required CPU in cores, e.g. 0.5</param>
        /// <param name="memory">Required memory, e.g. "250Mb"</param>
        public ContainerResources(double? cpu = default(double?), string memory = default(string))
        {
            Cpu = cpu;
            Memory = memory;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required CPU in cores, e.g. 0.5
        /// </summary>
        [JsonProperty(PropertyName = "cpu")]
        public double? Cpu { get; set; }

        /// <summary>
        /// Gets or sets required memory, e.g. "250Mb"
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public string Memory { get; set; }

    }
}

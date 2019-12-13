// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AzureCompositeModelClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Newtonsoft.Json.JsonObject("sawshark")]
    public partial class Sawshark : Shark
    {
        /// <summary>
        /// Initializes a new instance of the Sawshark class.
        /// </summary>
        public Sawshark()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sawshark class.
        /// </summary>
        public Sawshark(double length, System.DateTime birthday, string species = default(string), IList<FishInner> siblings = default(IList<FishInner>), int? age = default(int?), byte[] picture = default(byte[]))
            : base(length, birthday, species, siblings, age)
        {
            Picture = picture;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "picture")]
        public byte[] Picture { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

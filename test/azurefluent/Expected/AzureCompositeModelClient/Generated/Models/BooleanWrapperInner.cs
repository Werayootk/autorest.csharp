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
    using System.Linq;

    public partial class BooleanWrapperInner
    {
        /// <summary>
        /// Initializes a new instance of the BooleanWrapperInner class.
        /// </summary>
        public BooleanWrapperInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BooleanWrapperInner class.
        /// </summary>
        public BooleanWrapperInner(bool? fieldTrue = default(bool?), bool? fieldFalse = default(bool?))
        {
            FieldTrue = fieldTrue;
            FieldFalse = fieldFalse;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "field_true")]
        public bool? FieldTrue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "field_false")]
        public bool? FieldFalse { get; set; }

    }
}

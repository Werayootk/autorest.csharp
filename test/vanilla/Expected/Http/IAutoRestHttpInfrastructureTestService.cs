// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Http
{
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Test Infrastructure for AutoRest
    /// </summary>
    public partial interface IAutoRestHttpInfrastructureTestService : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Gets the IHttpFailure.
        /// </summary>
        IHttpFailure HttpFailure { get; }

        /// <summary>
        /// Gets the IHttpSuccess.
        /// </summary>
        IHttpSuccess HttpSuccess { get; }

        /// <summary>
        /// Gets the IHttpRedirects.
        /// </summary>
        IHttpRedirects HttpRedirects { get; }

        /// <summary>
        /// Gets the IHttpClientFailure.
        /// </summary>
        IHttpClientFailure HttpClientFailure { get; }

        /// <summary>
        /// Gets the IHttpServerFailure.
        /// </summary>
        IHttpServerFailure HttpServerFailure { get; }

        /// <summary>
        /// Gets the IHttpRetry.
        /// </summary>
        IHttpRetry HttpRetry { get; }

        /// <summary>
        /// Gets the IMultipleResponses.
        /// </summary>
        IMultipleResponses MultipleResponses { get; }

    }
}

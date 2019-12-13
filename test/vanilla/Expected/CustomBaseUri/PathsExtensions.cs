// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.CustomBaseUri
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Paths.
    /// </summary>
    public static partial class PathsExtensions
    {
            /// <summary>
            /// Get a 200 to test a valid base uri
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// Account Name
            /// </param>
            public static void GetEmpty(this IPaths operations, string accountName)
            {
                operations.GetEmptyAsync(accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a 200 to test a valid base uri
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// Account Name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetEmptyAsync(this IPaths operations, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetEmptyWithHttpMessagesAsync(accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}

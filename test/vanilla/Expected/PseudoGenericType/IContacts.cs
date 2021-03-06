// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zapappi.Client
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Contacts operations.
    /// </summary>
    public partial interface IContacts
    {
        /// <summary>
        /// Get a list of contacts
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='take'>
        /// Number of items to return
        /// </param>
        /// <param name='skip'>
        /// Number of item to skip over
        /// </param>
        /// <param name='country'>
        /// The country of the contact
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<PagedResponse<ContactsModel>>> GetContactsWithHttpMessagesAsync(string subscriptionId, int take, int skip, System.Guid? country = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a new contact
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='building'>
        /// </param>
        /// <param name='city'>
        /// </param>
        /// <param name='street'>
        /// </param>
        /// <param name='postcode'>
        /// </param>
        /// <param name='company'>
        /// </param>
        /// <param name='title'>
        /// </param>
        /// <param name='firstName'>
        /// </param>
        /// <param name='lastName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ContactsModel>> AddContactWithHttpMessagesAsync(string subscriptionId, string building, string city, string street, string postcode, string company = default(string), string title = default(string), string firstName = default(string), string lastName = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a contact
        /// </summary>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='id'>
        /// Get specific contact
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ContactsModel>> GetContactWithHttpMessagesAsync(string subscriptionId, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}

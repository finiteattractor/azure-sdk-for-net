// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApplicationsOperations.
    /// </summary>
    public static partial class ApplicationsOperationsExtensions
    {
            /// <summary>
            /// Create a new application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// The parameters for creating an application.
            /// </param>
            public static ApplicationInner Create(this IApplicationsOperations operations, ApplicationCreateParametersInner parameters)
            {
                return operations.CreateAsync(parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// The parameters for creating an application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationInner> CreateAsync(this IApplicationsOperations operations, ApplicationCreateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists applications by filter parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<ApplicationInner> List(this IApplicationsOperations operations, ODataQuery<ApplicationInner> odataQuery = default(ODataQuery<ApplicationInner>))
            {
                return ((IApplicationsOperations)operations).ListAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists applications by filter parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationInner>> ListAsync(this IApplicationsOperations operations, ODataQuery<ApplicationInner> odataQuery = default(ODataQuery<ApplicationInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            public static void Delete(this IApplicationsOperations operations, string applicationObjectId)
            {
                operations.DeleteAsync(applicationObjectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApplicationsOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get an application by object ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            public static ApplicationInner Get(this IApplicationsOperations operations, string applicationObjectId)
            {
                return operations.GetAsync(applicationObjectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an application by object ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationInner> GetAsync(this IApplicationsOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update an existing application.
            /// </param>
            public static void Patch(this IApplicationsOperations operations, string applicationObjectId, ApplicationUpdateParametersInner parameters)
            {
                operations.PatchAsync(applicationObjectId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an existing application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update an existing application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PatchAsync(this IApplicationsOperations operations, string applicationObjectId, ApplicationUpdateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PatchWithHttpMessagesAsync(applicationObjectId, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get the keyCredentials associated with an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            public static IEnumerable<KeyCredential> ListKeyCredentials(this IApplicationsOperations operations, string applicationObjectId)
            {
                return operations.ListKeyCredentialsAsync(applicationObjectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the keyCredentials associated with an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<KeyCredential>> ListKeyCredentialsAsync(this IApplicationsOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeyCredentialsWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the keyCredentials associated with an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update the keyCredentials of an existing application.
            /// </param>
            public static void UpdateKeyCredentials(this IApplicationsOperations operations, string applicationObjectId, KeyCredentialsUpdateParametersInner parameters)
            {
                operations.UpdateKeyCredentialsAsync(applicationObjectId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the keyCredentials associated with an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update the keyCredentials of an existing application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateKeyCredentialsAsync(this IApplicationsOperations operations, string applicationObjectId, KeyCredentialsUpdateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateKeyCredentialsWithHttpMessagesAsync(applicationObjectId, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get the passwordCredentials associated with an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            public static IEnumerable<PasswordCredential> ListPasswordCredentials(this IApplicationsOperations operations, string applicationObjectId)
            {
                return operations.ListPasswordCredentialsAsync(applicationObjectId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the passwordCredentials associated with an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<PasswordCredential>> ListPasswordCredentialsAsync(this IApplicationsOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListPasswordCredentialsWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update passwordCredentials associated with an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update passwordCredentials of an existing application.
            /// </param>
            public static void UpdatePasswordCredentials(this IApplicationsOperations operations, string applicationObjectId, PasswordCredentialsUpdateParametersInner parameters)
            {
                operations.UpdatePasswordCredentialsAsync(applicationObjectId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update passwordCredentials associated with an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update passwordCredentials of an existing application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdatePasswordCredentialsAsync(this IApplicationsOperations operations, string applicationObjectId, PasswordCredentialsUpdateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdatePasswordCredentialsWithHttpMessagesAsync(applicationObjectId, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of applications from the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for the list operation.
            /// </param>
            public static IPage<ApplicationInner> ListNext(this IApplicationsOperations operations, string nextLink)
            {
                return operations.ListNextAsync(nextLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of applications from the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for the list operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationInner>> ListNextAsync(this IApplicationsOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
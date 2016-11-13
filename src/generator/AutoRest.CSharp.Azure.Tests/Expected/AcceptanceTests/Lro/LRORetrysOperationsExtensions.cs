// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsLro
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for LRORetrysOperations.
    /// </summary>
    public static partial class LRORetrysOperationsExtensions
    {
            /// <summary>
            /// Long running put request, service returns a 500, then a 201 to the initial
            /// request, with an entity that contains ProvisioningState=’Creating’.  Polls
            /// return this value until the last poll returns a ‘200’ with
            /// ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product Put201CreatingSucceeded200(this ILRORetrysOperations operations, Product product = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).Put201CreatingSucceeded200Async(product), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 500, then a 201 to the initial
            /// request, with an entity that contains ProvisioningState=’Creating’.  Polls
            /// return this value until the last poll returns a ‘200’ with
            /// ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Product> Put201CreatingSucceeded200Async(this ILRORetrysOperations operations, Product product = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.Put201CreatingSucceeded200WithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Long running put request, service returns a 500, then a 200 to the initial
            /// request, with an entity that contains ProvisioningState=’Creating’. Poll
            /// the endpoint indicated in the Azure-AsyncOperation header for operation
            /// status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product PutAsyncRelativeRetrySucceeded(this ILRORetrysOperations operations, Product product = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).PutAsyncRelativeRetrySucceededAsync(product), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 500, then a 200 to the initial
            /// request, with an entity that contains ProvisioningState=’Creating’. Poll
            /// the endpoint indicated in the Azure-AsyncOperation header for operation
            /// status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Product> PutAsyncRelativeRetrySucceededAsync(this ILRORetrysOperations operations, Product product = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PutAsyncRelativeRetrySucceededWithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Long running delete request, service returns a 500, then a  202 to the
            /// initial request, with an entity that contains ProvisioningState=’Accepted’.
            /// Polls return this value until the last poll returns a ‘200’ with
            /// ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Product DeleteProvisioning202Accepted200Succeeded(this ILRORetrysOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).DeleteProvisioning202Accepted200SucceededAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 500, then a  202 to the
            /// initial request, with an entity that contains ProvisioningState=’Accepted’.
            /// Polls return this value until the last poll returns a ‘200’ with
            /// ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Product> DeleteProvisioning202Accepted200SucceededAsync(this ILRORetrysOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteProvisioning202Accepted200SucceededWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Long running delete request, service returns a 500, then a 202 to the
            /// initial request. Polls return this value until the last poll returns a
            /// ‘200’ with ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static LRORetrysDelete202Retry200Headers Delete202Retry200(this ILRORetrysOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).Delete202Retry200Async(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 500, then a 202 to the
            /// initial request. Polls return this value until the last poll returns a
            /// ‘200’ with ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LRORetrysDelete202Retry200Headers> Delete202Retry200Async(this ILRORetrysOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.Delete202Retry200WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Long running delete request, service returns a 500, then a 202 to the
            /// initial request. Poll the endpoint indicated in the Azure-AsyncOperation
            /// header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static LRORetrysDeleteAsyncRelativeRetrySucceededHeaders DeleteAsyncRelativeRetrySucceeded(this ILRORetrysOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).DeleteAsyncRelativeRetrySucceededAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 500, then a 202 to the
            /// initial request. Poll the endpoint indicated in the Azure-AsyncOperation
            /// header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LRORetrysDeleteAsyncRelativeRetrySucceededHeaders> DeleteAsyncRelativeRetrySucceededAsync(this ILRORetrysOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteAsyncRelativeRetrySucceededWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Long running post request, service returns a 500, then a 202 to the initial
            /// request, with 'Location' and 'Retry-After' headers, Polls return a 200 with
            /// a response body after success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static LRORetrysPost202Retry200Headers Post202Retry200(this ILRORetrysOperations operations, Product product = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).Post202Retry200Async(product), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 500, then a 202 to the initial
            /// request, with 'Location' and 'Retry-After' headers, Polls return a 200 with
            /// a response body after success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LRORetrysPost202Retry200Headers> Post202Retry200Async(this ILRORetrysOperations operations, Product product = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.Post202Retry200WithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Long running post request, service returns a 500, then a 202 to the initial
            /// request, with an entity that contains ProvisioningState=’Creating’. Poll
            /// the endpoint indicated in the Azure-AsyncOperation header for operation
            /// status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static LRORetrysPostAsyncRelativeRetrySucceededHeaders PostAsyncRelativeRetrySucceeded(this ILRORetrysOperations operations, Product product = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).PostAsyncRelativeRetrySucceededAsync(product), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 500, then a 202 to the initial
            /// request, with an entity that contains ProvisioningState=’Creating’. Poll
            /// the endpoint indicated in the Azure-AsyncOperation header for operation
            /// status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LRORetrysPostAsyncRelativeRetrySucceededHeaders> PostAsyncRelativeRetrySucceededAsync(this ILRORetrysOperations operations, Product product = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostAsyncRelativeRetrySucceededWithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Long running put request, service returns a 500, then a 201 to the initial
            /// request, with an entity that contains ProvisioningState=’Creating’.  Polls
            /// return this value until the last poll returns a ‘200’ with
            /// ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPut201CreatingSucceeded200(this ILRORetrysOperations operations, Product product = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).BeginPut201CreatingSucceeded200Async(product), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 500, then a 201 to the initial
            /// request, with an entity that contains ProvisioningState=’Creating’.  Polls
            /// return this value until the last poll returns a ‘200’ with
            /// ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Product> BeginPut201CreatingSucceeded200Async(this ILRORetrysOperations operations, Product product = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginPut201CreatingSucceeded200WithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Long running put request, service returns a 500, then a 200 to the initial
            /// request, with an entity that contains ProvisioningState=’Creating’. Poll
            /// the endpoint indicated in the Azure-AsyncOperation header for operation
            /// status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static Product BeginPutAsyncRelativeRetrySucceeded(this ILRORetrysOperations operations, Product product = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).BeginPutAsyncRelativeRetrySucceededAsync(product), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request, service returns a 500, then a 200 to the initial
            /// request, with an entity that contains ProvisioningState=’Creating’. Poll
            /// the endpoint indicated in the Azure-AsyncOperation header for operation
            /// status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Product> BeginPutAsyncRelativeRetrySucceededAsync(this ILRORetrysOperations operations, Product product = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginPutAsyncRelativeRetrySucceededWithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Long running delete request, service returns a 500, then a  202 to the
            /// initial request, with an entity that contains ProvisioningState=’Accepted’.
            /// Polls return this value until the last poll returns a ‘200’ with
            /// ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Product BeginDeleteProvisioning202Accepted200Succeeded(this ILRORetrysOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).BeginDeleteProvisioning202Accepted200SucceededAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 500, then a  202 to the
            /// initial request, with an entity that contains ProvisioningState=’Accepted’.
            /// Polls return this value until the last poll returns a ‘200’ with
            /// ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Product> BeginDeleteProvisioning202Accepted200SucceededAsync(this ILRORetrysOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginDeleteProvisioning202Accepted200SucceededWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Long running delete request, service returns a 500, then a 202 to the
            /// initial request. Polls return this value until the last poll returns a
            /// ‘200’ with ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static LRORetrysDelete202Retry200Headers BeginDelete202Retry200(this ILRORetrysOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).BeginDelete202Retry200Async(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 500, then a 202 to the
            /// initial request. Polls return this value until the last poll returns a
            /// ‘200’ with ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LRORetrysDelete202Retry200Headers> BeginDelete202Retry200Async(this ILRORetrysOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginDelete202Retry200WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Long running delete request, service returns a 500, then a 202 to the
            /// initial request. Poll the endpoint indicated in the Azure-AsyncOperation
            /// header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static LRORetrysDeleteAsyncRelativeRetrySucceededHeaders BeginDeleteAsyncRelativeRetrySucceeded(this ILRORetrysOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).BeginDeleteAsyncRelativeRetrySucceededAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running delete request, service returns a 500, then a 202 to the
            /// initial request. Poll the endpoint indicated in the Azure-AsyncOperation
            /// header for operation status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LRORetrysDeleteAsyncRelativeRetrySucceededHeaders> BeginDeleteAsyncRelativeRetrySucceededAsync(this ILRORetrysOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginDeleteAsyncRelativeRetrySucceededWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Long running post request, service returns a 500, then a 202 to the initial
            /// request, with 'Location' and 'Retry-After' headers, Polls return a 200 with
            /// a response body after success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static LRORetrysPost202Retry200Headers BeginPost202Retry200(this ILRORetrysOperations operations, Product product = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).BeginPost202Retry200Async(product), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 500, then a 202 to the initial
            /// request, with 'Location' and 'Retry-After' headers, Polls return a 200 with
            /// a response body after success
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LRORetrysPost202Retry200Headers> BeginPost202Retry200Async(this ILRORetrysOperations operations, Product product = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginPost202Retry200WithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Long running post request, service returns a 500, then a 202 to the initial
            /// request, with an entity that contains ProvisioningState=’Creating’. Poll
            /// the endpoint indicated in the Azure-AsyncOperation header for operation
            /// status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            public static LRORetrysPostAsyncRelativeRetrySucceededHeaders BeginPostAsyncRelativeRetrySucceeded(this ILRORetrysOperations operations, Product product = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ILRORetrysOperations)s).BeginPostAsyncRelativeRetrySucceededAsync(product), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request, service returns a 500, then a 202 to the initial
            /// request, with an entity that contains ProvisioningState=’Creating’. Poll
            /// the endpoint indicated in the Azure-AsyncOperation header for operation
            /// status
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='product'>
            /// Product to put
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LRORetrysPostAsyncRelativeRetrySucceededHeaders> BeginPostAsyncRelativeRetrySucceededAsync(this ILRORetrysOperations operations, Product product = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginPostAsyncRelativeRetrySucceededWithHttpMessagesAsync(product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

    }
}

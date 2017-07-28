// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Storage
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StorageAccounts.
    /// </summary>
    public static partial class StorageAccountsExtensions
    {
            /// <summary>
            /// Checks that account name is valid and is not in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            public static CheckNameAvailabilityResult CheckNameAvailability(this IStorageAccounts operations, StorageAccountCheckNameAvailabilityParameters accountName)
            {
                return operations.CheckNameAvailabilityAsync(accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks that account name is valid and is not in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityResult> CheckNameAvailabilityAsync(this IStorageAccounts operations, StorageAccountCheckNameAvailabilityParameters accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Asynchronously creates a new storage account with the specified parameters.
            /// Existing accounts cannot be updated with this API and should instead use
            /// the Update Storage Account API. If an account is already created and
            /// subsequent PUT request is issued with exact same set of properties, then
            /// HTTP 200 would be returned.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the created account.
            /// </param>
            public static StorageAccount Create(this IStorageAccounts operations, string resourceGroupName, string accountName, StorageAccountCreateParameters parameters)
            {
                return operations.CreateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Asynchronously creates a new storage account with the specified parameters.
            /// Existing accounts cannot be updated with this API and should instead use
            /// the Update Storage Account API. If an account is already created and
            /// subsequent PUT request is issued with exact same set of properties, then
            /// HTTP 200 would be returned.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to provide for the created account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccount> CreateAsync(this IStorageAccounts operations, string resourceGroupName, string accountName, StorageAccountCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a storage account in Microsoft Azure.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            public static void Delete(this IStorageAccounts operations, string resourceGroupName, string accountName)
            {
                operations.DeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a storage account in Microsoft Azure.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IStorageAccounts operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns the properties for the specified storage account including but not
            /// limited to name, account type, location, and account status. The ListKeys
            /// operation should be used to retrieve storage keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            public static StorageAccount GetProperties(this IStorageAccounts operations, string resourceGroupName, string accountName)
            {
                return operations.GetPropertiesAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the properties for the specified storage account including but not
            /// limited to name, account type, location, and account status. The ListKeys
            /// operation should be used to retrieve storage keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccount> GetPropertiesAsync(this IStorageAccounts operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPropertiesWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the account type or tags for a storage account. It can also be used
            /// to add a custom domain (note that custom domains cannot be added via the
            /// Create operation). Only one custom domain is supported per storage account.
            /// In order to replace a custom domain, the old value must be cleared before a
            /// new value may be set. To clear a custom domain, simply update the custom
            /// domain with empty string. Then call update again with the new cutsom domain
            /// name. The update API can only be used to update one of tags, accountType,
            /// or customDomain per call. To update multiple of these properties, call the
            /// API multiple times with one change per call. This call does not change the
            /// storage keys for the account. If you want to change storage account keys,
            /// use the RegenerateKey operation. The location and name of the storage
            /// account cannot be changed after creation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to update on the account. Note that only one property can be
            /// changed at a time using this API.
            /// </param>
            public static StorageAccount Update(this IStorageAccounts operations, string resourceGroupName, string accountName, StorageAccountUpdateParameters parameters)
            {
                return operations.UpdateAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the account type or tags for a storage account. It can also be used
            /// to add a custom domain (note that custom domains cannot be added via the
            /// Create operation). Only one custom domain is supported per storage account.
            /// In order to replace a custom domain, the old value must be cleared before a
            /// new value may be set. To clear a custom domain, simply update the custom
            /// domain with empty string. Then call update again with the new cutsom domain
            /// name. The update API can only be used to update one of tags, accountType,
            /// or customDomain per call. To update multiple of these properties, call the
            /// API multiple times with one change per call. This call does not change the
            /// storage keys for the account. If you want to change storage account keys,
            /// use the RegenerateKey operation. The location and name of the storage
            /// account cannot be changed after creation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to update on the account. Note that only one property can be
            /// changed at a time using this API.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccount> UpdateAsync(this IStorageAccounts operations, string resourceGroupName, string accountName, StorageAccountUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the access keys for the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account.
            /// </param>
            public static StorageAccountKeys ListKeys(this IStorageAccounts operations, string resourceGroupName, string accountName)
            {
                return operations.ListKeysAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the access keys for the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccountKeys> ListKeysAsync(this IStorageAccounts operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the storage accounts available under the subscription. Note that
            /// storage keys are not returned; use the ListKeys operation for this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static StorageAccountListResult List(this IStorageAccounts operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the storage accounts available under the subscription. Note that
            /// storage keys are not returned; use the ListKeys operation for this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccountListResult> ListAsync(this IStorageAccounts operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the storage accounts available under the given resource group.
            /// Note that storage keys are not returned; use the ListKeys operation for
            /// this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            public static StorageAccountListResult ListByResourceGroup(this IStorageAccounts operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the storage accounts available under the given resource group.
            /// Note that storage keys are not returned; use the ListKeys operation for
            /// this.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccountListResult> ListByResourceGroupAsync(this IStorageAccounts operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the access keys for the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='regenerateKey'>
            /// Specifies name of the key which should be regenerated. key1 or key2 for the
            /// default keys
            /// </param>
            public static StorageAccountKeys RegenerateKey(this IStorageAccounts operations, string resourceGroupName, string accountName, StorageAccountRegenerateKeyParameters regenerateKey)
            {
                return operations.RegenerateKeyAsync(resourceGroupName, accountName, regenerateKey).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the access keys for the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='regenerateKey'>
            /// Specifies name of the key which should be regenerated. key1 or key2 for the
            /// default keys
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageAccountKeys> RegenerateKeyAsync(this IStorageAccounts operations, string resourceGroupName, string accountName, StorageAccountRegenerateKeyParameters regenerateKey, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeyWithHttpMessagesAsync(resourceGroupName, accountName, regenerateKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

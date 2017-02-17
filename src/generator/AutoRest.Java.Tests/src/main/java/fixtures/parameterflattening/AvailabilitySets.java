/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.parameterflattening;

import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceFuture;
import com.microsoft.rest.ServiceResponse;
import java.util.Map;
import rx.Observable;

/**
 * An instance of this class provides access to all the operations defined
 * in AvailabilitySets.
 */
public interface AvailabilitySets {
    /**
     * Updates the tags for an availability set.
     *
     * @param resourceGroupName The name of the resource group.
     * @param avset The name of the storage availability set.
     * @param tags A set of tags. A description about the set of tags.
     */
    void update(String resourceGroupName, String avset, Map<String, String> tags);

    /**
     * Updates the tags for an availability set.
     *
     * @param resourceGroupName The name of the resource group.
     * @param avset The name of the storage availability set.
     * @param tags A set of tags. A description about the set of tags.
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceFuture} object
     */
    ServiceFuture<Void> updateAsync(String resourceGroupName, String avset, Map<String, String> tags, final ServiceCallback<Void> serviceCallback);

    /**
     * Updates the tags for an availability set.
     *
     * @param resourceGroupName The name of the resource group.
     * @param avset The name of the storage availability set.
     * @param tags A set of tags. A description about the set of tags.
     * @return the {@link ServiceResponse} object if successful.
     */
    Observable<Void> updateAsync(String resourceGroupName, String avset, Map<String, String> tags);

    /**
     * Updates the tags for an availability set.
     *
     * @param resourceGroupName The name of the resource group.
     * @param avset The name of the storage availability set.
     * @param tags A set of tags. A description about the set of tags.
     * @return the {@link ServiceResponse} object if successful.
     */
    Observable<ServiceResponse<Void>> updateWithServiceResponseAsync(String resourceGroupName, String avset, Map<String, String> tags);

}

/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.subscriptionidapiversion;

import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceResponse;
import com.squareup.okhttp.ResponseBody;
import fixtures.subscriptionidapiversion.models.ErrorException;
import fixtures.subscriptionidapiversion.models.SampleResourceGroup;
import java.io.IOException;
import retrofit.Call;
import retrofit.http.GET;
import retrofit.http.Header;
import retrofit.http.Path;
import retrofit.http.Query;

/**
 * An instance of this class provides access to all the operations defined
 * in GroupOperations.
 */
public interface GroupOperations {
    /**
     * The interface defining all the services for GroupOperations to be
     * used by Retrofit to perform actually REST calls.
     */
    interface GroupService {
        @GET("subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}")
        Call<ResponseBody> getSampleResourceGroup(@Path("subscriptionId") String subscriptionId, @Path("resourceGroupName") String resourceGroupName, @Query("api-version") String apiVersion, @Header("accept-language") String acceptLanguage);

    }
    /**
     * Provides a resouce group with name 'testgroup101' and location 'West US'.
     *
     * @param resourceGroupName Resource Group name 'testgroup101'.
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @throws IllegalArgumentException exception thrown from invalid parameters
     * @return the SampleResourceGroup object wrapped in ServiceResponse if successful.
     */
    ServiceResponse<SampleResourceGroup> getSampleResourceGroup(String resourceGroupName) throws ErrorException, IOException, IllegalArgumentException;

    /**
     * Provides a resouce group with name 'testgroup101' and location 'West US'.
     *
     * @param resourceGroupName Resource Group name 'testgroup101'.
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link Call} object
     */
    Call<ResponseBody> getSampleResourceGroupAsync(String resourceGroupName, final ServiceCallback<SampleResourceGroup> serviceCallback);

}
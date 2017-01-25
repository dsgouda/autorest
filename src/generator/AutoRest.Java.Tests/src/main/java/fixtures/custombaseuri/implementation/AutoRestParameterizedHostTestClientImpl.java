/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.custombaseuri.implementation;

import fixtures.custombaseuri.AutoRestParameterizedHostTestClient;
import fixtures.custombaseuri.Paths;
import com.microsoft.rest.ServiceClient;
import com.microsoft.rest.RestClient;
import okhttp3.OkHttpClient;
import retrofit2.Retrofit;

/**
 * Initializes a new instance of the AutoRestParameterizedHostTestClient class.
 */
public class AutoRestParameterizedHostTestClientImpl extends ServiceClient implements AutoRestParameterizedHostTestClient {

    /** A string value that is used as a global part of the parameterized host. */
    private String host;

    /**
     * Gets A string value that is used as a global part of the parameterized host.
     *
     * @return the host value.
     */
    public String host() {
        return this.host;
    }

    /**
     * Sets A string value that is used as a global part of the parameterized host.
     *
     * @param host the host value.
     * @return the service client itself
     */
    public AutoRestParameterizedHostTestClientImpl withHost(String host) {
        this.host = host;
        return this;
    }

    /**
     * The Paths object to access its operations.
     */
    private Paths paths;

    /**
     * Gets the Paths object to access its operations.
     * @return the Paths object.
     */
    public Paths paths() {
        return this.paths;
    }

    /**
     * Initializes an instance of AutoRestParameterizedHostTestClient client.
     */
    public AutoRestParameterizedHostTestClientImpl() {
        this("http://{accountName}{host}");
    }

    /**
     * Initializes an instance of AutoRestParameterizedHostTestClient client.
     *
     * @param baseUrl the base URL of the host
     */
    private AutoRestParameterizedHostTestClientImpl(String baseUrl) {
        super(baseUrl);
        initialize();
    }

    /**
     * Initializes an instance of AutoRestParameterizedHostTestClient client.
     *
     * @param clientBuilder the builder for building an OkHttp client, bundled with user configurations
     * @param restBuilder the builder for building an Retrofit client, bundled with user configurations
     */
    public AutoRestParameterizedHostTestClientImpl(OkHttpClient.Builder clientBuilder, Retrofit.Builder restBuilder) {
        this("http://{accountName}{host}", clientBuilder, restBuilder);
        initialize();
    }

    /**
     * Initializes an instance of AutoRestParameterizedHostTestClient client.
     *
     * @param baseUrl the base URL of the host
     * @param clientBuilder the builder for building an OkHttp client, bundled with user configurations
     * @param restBuilder the builder for building an Retrofit client, bundled with user configurations
     */
    private AutoRestParameterizedHostTestClientImpl(String baseUrl, OkHttpClient.Builder clientBuilder, Retrofit.Builder restBuilder) {
        super(baseUrl, clientBuilder, restBuilder);
        initialize();
    }

    /**
     * Initializes an instance of AutoRestParameterizedHostTestClient client.
     *
     * @param restClient the REST client containing pre-configured settings
     */
    public AutoRestParameterizedHostTestClientImpl(RestClient restClient) {
        super(restClient);
        initialize();
    }

    private void initialize() {
        this.host = "host";
        this.paths = new PathsImpl(retrofit(), this);
    }
}

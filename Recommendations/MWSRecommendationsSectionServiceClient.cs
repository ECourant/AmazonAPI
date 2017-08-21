/*******************************************************************************
 * Copyright 2009-2015 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * MWS Recommendations Section Service
 * API Version: 2013-04-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:29:19 GMT 2015
 */

using System;
using AmazonAPI.MWSClientRuntime;
using AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService
{

    /// <summary>
    /// MWSRecommendationsSectionServiceClient is an implementation of MWSRecommendationsSectionService
    /// </summary>
    public class MWSRecommendationsSectionServiceClient : MWSRecommendationsSectionService 
    {

        private const string libraryVersion = "2015-06-18";

        private string servicePath;

        private MwsConnection connection;

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        /// <param name="config">configuration</param>
        public MWSRecommendationsSectionServiceClient(
            string accessKey,
            string secretKey,
            string applicationName,
            string applicationVersion,
            MWSRecommendationsSectionServiceConfig config)
        {
            connection = config.CopyConnection();
            connection.AwsAccessKeyId = accessKey;
            connection.AwsSecretKeyId = secretKey;
            connection.ApplicationName = applicationName;
            connection.ApplicationVersion = applicationVersion;
            connection.LibraryVersion = libraryVersion;
            servicePath = config.ServicePath;
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="config">configuration</param>
        public MWSRecommendationsSectionServiceClient(String accessKey, String secretKey, MWSRecommendationsSectionServiceConfig config)
        {
            connection = config.CopyConnection();
            connection.AwsAccessKeyId = accessKey;
            connection.AwsSecretKeyId = secretKey;
            connection.LibraryVersion = libraryVersion;
            servicePath = config.ServicePath;
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        public MWSRecommendationsSectionServiceClient(String accessKey, String secretKey)
            : this(accessKey, secretKey, new MWSRecommendationsSectionServiceConfig())
        {
        }

        /// <summary>
        /// Create client.
        /// </summary>
        /// <param name="accessKey">Access Key</param>
        /// <param name="secretKey">Secret Key</param>
        /// <param name="applicationName">Application Name</param>
        /// <param name="applicationVersion">Application Version</param>
        public MWSRecommendationsSectionServiceClient(
            String accessKey, 
            String secretKey,
            String applicationName,
            String applicationVersion ) 
            : this(accessKey, secretKey, applicationName,
                applicationVersion, new MWSRecommendationsSectionServiceConfig())
        {
        }

        public GetLastUpdatedTimeForRecommendationsResponse GetLastUpdatedTimeForRecommendations(GetLastUpdatedTimeForRecommendationsRequest request)
        {
            return connection.Call(
                new MWSRecommendationsSectionServiceClient.Request<GetLastUpdatedTimeForRecommendationsResponse>("GetLastUpdatedTimeForRecommendations", typeof(GetLastUpdatedTimeForRecommendationsResponse), servicePath),
                request);
        }

        public ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request)
        {
            return connection.Call(
                new MWSRecommendationsSectionServiceClient.Request<ListRecommendationsResponse>("ListRecommendations", typeof(ListRecommendationsResponse), servicePath),
                request);
        }

        public ListRecommendationsByNextTokenResponse ListRecommendationsByNextToken(ListRecommendationsByNextTokenRequest request)
        {
            return connection.Call(
                new MWSRecommendationsSectionServiceClient.Request<ListRecommendationsByNextTokenResponse>("ListRecommendationsByNextToken", typeof(ListRecommendationsByNextTokenResponse), servicePath),
                request);
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return connection.Call(
                new MWSRecommendationsSectionServiceClient.Request<GetServiceStatusResponse>("GetServiceStatus", typeof(GetServiceStatusResponse), servicePath),
                request);
        }

        private class Request<R> : IMwsRequestType<R> where R : IMwsObject
        {
            private string operationName;
            private Type responseClass;
            private string servicePath;

            public Request(string operationName, Type responseClass, string servicePath) {
                this.operationName = operationName;
                this.responseClass = responseClass;
                this.servicePath = servicePath;
            }

            public string ServicePath
            {
                get { return servicePath; }
            }

            public string OperationName
            {
                get { return operationName; }
            }

            public Type ResponseClass
            {
                get { return responseClass; }
            }

            public MwsException WrapException(Exception cause) {
                return new MWSRecommendationsSectionServiceException(cause);
            }

            public void SetResponseHeaderMetadata(IMwsObject response, MwsResponseHeaderMetadata rhmd) {
                ((IMWSResponse)response).ResponseHeaderMetadata = new ResponseHeaderMetadata(rhmd);
            }

        }
    }
}

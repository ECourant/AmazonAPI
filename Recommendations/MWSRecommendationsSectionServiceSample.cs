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

using AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model;
using System;
using System.Collections.Generic;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService {

    /// <summary>
    /// Runnable sample code to demonstrate usage of the C# client.
    ///
    /// To use, import the client source as a console application,
    /// and mark this class as the startup object. Then, replace
    /// parameters below with sensible values and run.
    /// </summary>
    public class MWSRecommendationsSectionServiceSample {

        public static void Main(string[] args)
        {
            // TODO: Set the below configuration variables before attempting to run

            // Developer AWS access key
            string accessKey = "replaceWithAccessKey";

            // Developer AWS secret key
            string secretKey = "replaceWithSecretKey";

            // The client application name
            string appName = "CSharpSampleCode";

            // The client application version
            string appVersion = "1.0";

            // The endpoint for region service and version (see developer guide)
            // ex: https://mws.amazonservices.com
            string serviceURL = "replaceWithServiceURL";

            // Create a configuration object
            MWSRecommendationsSectionServiceConfig config = new MWSRecommendationsSectionServiceConfig();
            config.ServiceURL = serviceURL;
            // Set other client connection configurations here if needed
            // Create the client itself
            MWSRecommendationsSectionService client = new MWSRecommendationsSectionServiceClient(accessKey, secretKey, appName, appVersion, config);

            MWSRecommendationsSectionServiceSample sample = new MWSRecommendationsSectionServiceSample(client);

            // Uncomment the operation you'd like to test here
            // TODO: Modify the request created in the Invoke method to be valid

            try 
            {
                IMWSResponse response = null;
                // response = sample.InvokeGetLastUpdatedTimeForRecommendations();
                // response = sample.InvokeListRecommendations();
                // response = sample.InvokeListRecommendationsByNextToken();
                // response = sample.InvokeGetServiceStatus();
                Console.WriteLine("Response:");
                ResponseHeaderMetadata rhmd = response.ResponseHeaderMetadata;
                // We recommend logging the request id and timestamp of every call.
                Console.WriteLine("RequestId: " + rhmd.RequestId);
                Console.WriteLine("Timestamp: " + rhmd.Timestamp);
                string responseXml = response.ToXML();
                Console.WriteLine(responseXml);
            }
            catch (MWSRecommendationsSectionServiceException ex)
            {
                // Exception properties are important for diagnostics.
                ResponseHeaderMetadata rhmd = ex.ResponseHeaderMetadata;
                Console.WriteLine("Service Exception:");
                if(rhmd != null)
                {
                    Console.WriteLine("RequestId: " + rhmd.RequestId);
                    Console.WriteLine("Timestamp: " + rhmd.Timestamp);
                }
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("StatusCode: " + ex.StatusCode);
                Console.WriteLine("ErrorCode: " + ex.ErrorCode);
                Console.WriteLine("ErrorType: " + ex.ErrorType);
                throw ex;
            }
        }

        private readonly MWSRecommendationsSectionService client;

        public MWSRecommendationsSectionServiceSample(MWSRecommendationsSectionService client)
        {
            this.client = client;
        }

        public GetLastUpdatedTimeForRecommendationsResponse InvokeGetLastUpdatedTimeForRecommendations()
        {
            // Create a request.
            GetLastUpdatedTimeForRecommendationsRequest request = new GetLastUpdatedTimeForRecommendationsRequest();
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string sellerId = "example";
            request.SellerId = sellerId;
            return this.client.GetLastUpdatedTimeForRecommendations(request);
        }

        public ListRecommendationsResponse InvokeListRecommendations()
        {
            // Create a request.
            ListRecommendationsRequest request = new ListRecommendationsRequest();
            string marketplaceId = "example";
            request.MarketplaceId = marketplaceId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string sellerId = "example";
            request.SellerId = sellerId;
            string recommendationCategory = "example";
            request.RecommendationCategory = recommendationCategory;
            List<CategoryQuery> categoryQueryList = new List<CategoryQuery>();
            request.CategoryQueryList = categoryQueryList;
            return this.client.ListRecommendations(request);
        }

        public ListRecommendationsByNextTokenResponse InvokeListRecommendationsByNextToken()
        {
            // Create a request.
            ListRecommendationsByNextTokenRequest request = new ListRecommendationsByNextTokenRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string nextToken = "example";
            request.NextToken = nextToken;
            return this.client.ListRecommendationsByNextToken(request);
        }

        public GetServiceStatusResponse InvokeGetServiceStatus()
        {
            // Create a request.
            GetServiceStatusRequest request = new GetServiceStatusRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            return this.client.GetServiceStatus(request);
        }


    }
}

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
using AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService
{

    /// <summary>
    /// Service serving MWS Recommendation section APIs.
    /// </summary>
    public interface MWSRecommendationsSectionService 
    {

        /// <summary>
        /// Get Last Updated Time For Recommendations
        /// </summary>
        /// <param name="request">GetLastUpdatedTimeForRecommendationsRequest request.</param>
        /// <returns>GetLastUpdatedTimeForRecommendationsResponse response</returns>
        /// <remarks>
        /// Retrieving last updated time for all recommendation categories for the given marketplace and seller. 
        ///       If last updated time for a category is null, it indicates no active recommendations for this seller in the given marketplace for this category.
        /// </remarks>
        GetLastUpdatedTimeForRecommendationsResponse GetLastUpdatedTimeForRecommendations(GetLastUpdatedTimeForRecommendationsRequest request);

        /// <summary>
        /// List Recommendations
        /// </summary>
        /// <param name="request">ListRecommendationsRequest request.</param>
        /// <returns>ListRecommendationsResponse response</returns>
        /// <remarks>
        /// Retrieving first batch of recommendations.
        /// </remarks>
        ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request);

        /// <summary>
        /// List Recommendations By Next Token
        /// </summary>
        /// <param name="request">ListRecommendationsByNextTokenRequest request.</param>
        /// <returns>ListRecommendationsByNextTokenResponse response</returns>
        /// <remarks>
        /// Retrieving recommendation by next token.
        /// </remarks>
        ListRecommendationsByNextTokenResponse ListRecommendationsByNextToken(ListRecommendationsByNextTokenRequest request);

        /// <summary>
        /// Get Service Status
        /// </summary>
        /// <param name="request">GetServiceStatusRequest request.</param>
        /// <returns>GetServiceStatusResponse response</returns>
        /// <remarks>
        /// 
        /// </remarks>
        GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request);

    }
}

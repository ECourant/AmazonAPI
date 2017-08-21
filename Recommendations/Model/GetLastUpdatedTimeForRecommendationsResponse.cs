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
 * Get Last Updated Time For Recommendations Response
 * API Version: 2013-04-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:29:19 GMT 2015
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model
{
    public class GetLastUpdatedTimeForRecommendationsResponse : AbstractMwsObject, IMWSResponse
    {

        private GetLastUpdatedTimeForRecommendationsResult _getLastUpdatedTimeForRecommendationsResult;
        private ResponseMetadata _responseMetadata;
        private ResponseHeaderMetadata _responseHeaderMetadata;

        /// <summary>
        /// Gets and sets the GetLastUpdatedTimeForRecommendationsResult property.
        /// </summary>
        public GetLastUpdatedTimeForRecommendationsResult GetLastUpdatedTimeForRecommendationsResult
        {
            get { return this._getLastUpdatedTimeForRecommendationsResult; }
            set { this._getLastUpdatedTimeForRecommendationsResult = value; }
        }

        /// <summary>
        /// Sets the GetLastUpdatedTimeForRecommendationsResult property.
        /// </summary>
        /// <param name="getLastUpdatedTimeForRecommendationsResult">GetLastUpdatedTimeForRecommendationsResult property.</param>
        /// <returns>this instance.</returns>
        public GetLastUpdatedTimeForRecommendationsResponse WithGetLastUpdatedTimeForRecommendationsResult(GetLastUpdatedTimeForRecommendationsResult getLastUpdatedTimeForRecommendationsResult)
        {
            this._getLastUpdatedTimeForRecommendationsResult = getLastUpdatedTimeForRecommendationsResult;
            return this;
        }

        /// <summary>
        /// Checks if GetLastUpdatedTimeForRecommendationsResult property is set.
        /// </summary>
        /// <returns>true if GetLastUpdatedTimeForRecommendationsResult property is set.</returns>
        public bool IsSetGetLastUpdatedTimeForRecommendationsResult()
        {
            return this._getLastUpdatedTimeForRecommendationsResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        public ResponseMetadata ResponseMetadata
        {
            get { return this._responseMetadata; }
            set { this._responseMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property.
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property.</param>
        /// <returns>this instance.</returns>
        public GetLastUpdatedTimeForRecommendationsResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this._responseMetadata = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseMetadata property is set.</returns>
        public bool IsSetResponseMetadata()
        {
            return this._responseMetadata != null;
        }

        /// <summary>
        /// Gets and sets the ResponseHeaderMetadata property.
        /// </summary>
        public ResponseHeaderMetadata ResponseHeaderMetadata
        {
            get { return this._responseHeaderMetadata; }
            set { this._responseHeaderMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseHeaderMetadata property.
        /// </summary>
        /// <param name="responseHeaderMetadata">ResponseHeaderMetadata property.</param>
        /// <returns>this instance.</returns>
        public GetLastUpdatedTimeForRecommendationsResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
        {
            this._responseHeaderMetadata = responseHeaderMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseHeaderMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseHeaderMetadata property is set.</returns>
        public bool IsSetResponseHeaderMetadata()
        {
            return this._responseHeaderMetadata != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _getLastUpdatedTimeForRecommendationsResult = reader.Read<GetLastUpdatedTimeForRecommendationsResult>("GetLastUpdatedTimeForRecommendationsResult");
            _responseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("GetLastUpdatedTimeForRecommendationsResult", _getLastUpdatedTimeForRecommendationsResult);
            writer.Write("ResponseMetadata", _responseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Recommendations/2013-04-01", "GetLastUpdatedTimeForRecommendationsResponse", this);
        }

        public GetLastUpdatedTimeForRecommendationsResponse() : base()
        {
        }
    }
}

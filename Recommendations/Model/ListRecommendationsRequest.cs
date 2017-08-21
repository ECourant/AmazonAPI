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
 * List Recommendations Request
 * API Version: 2013-04-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:29:19 GMT 2015
 */


using System;
using System.Xml;
using System.Collections.Generic;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model
{
    public class ListRecommendationsRequest : AbstractMwsObject
    {

        private string _marketplaceId;
        private string _mwsAuthToken;
        private string _sellerId;
        private string _recommendationCategory;
        private List<CategoryQuery> _categoryQueryList;

        /// <summary>
        /// Gets and sets the MarketplaceId property.
        /// </summary>
        public string MarketplaceId
        {
            get { return this._marketplaceId; }
            set { this._marketplaceId = value; }
        }

        /// <summary>
        /// Sets the MarketplaceId property.
        /// </summary>
        /// <param name="marketplaceId">MarketplaceId property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsRequest WithMarketplaceId(string marketplaceId)
        {
            this._marketplaceId = marketplaceId;
            return this;
        }

        /// <summary>
        /// Checks if MarketplaceId property is set.
        /// </summary>
        /// <returns>true if MarketplaceId property is set.</returns>
        public bool IsSetMarketplaceId()
        {
            return this._marketplaceId != null;
        }

        /// <summary>
        /// Gets and sets the MWSAuthToken property.
        /// </summary>
        public string MWSAuthToken
        {
            get { return this._mwsAuthToken; }
            set { this._mwsAuthToken = value; }
        }

        /// <summary>
        /// Sets the MWSAuthToken property.
        /// </summary>
        /// <param name="mwsAuthToken">MWSAuthToken property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsRequest WithMWSAuthToken(string mwsAuthToken)
        {
            this._mwsAuthToken = mwsAuthToken;
            return this;
        }

        /// <summary>
        /// Checks if MWSAuthToken property is set.
        /// </summary>
        /// <returns>true if MWSAuthToken property is set.</returns>
        public bool IsSetMWSAuthToken()
        {
            return this._mwsAuthToken != null;
        }

        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        public string SellerId
        {
            get { return this._sellerId; }
            set { this._sellerId = value; }
        }

        /// <summary>
        /// Sets the SellerId property.
        /// </summary>
        /// <param name="sellerId">SellerId property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsRequest WithSellerId(string sellerId)
        {
            this._sellerId = sellerId;
            return this;
        }

        /// <summary>
        /// Checks if SellerId property is set.
        /// </summary>
        /// <returns>true if SellerId property is set.</returns>
        public bool IsSetSellerId()
        {
            return this._sellerId != null;
        }

        /// <summary>
        /// Gets and sets the RecommendationCategory property.
        /// </summary>
        public string RecommendationCategory
        {
            get { return this._recommendationCategory; }
            set { this._recommendationCategory = value; }
        }

        /// <summary>
        /// Sets the RecommendationCategory property.
        /// </summary>
        /// <param name="recommendationCategory">RecommendationCategory property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsRequest WithRecommendationCategory(string recommendationCategory)
        {
            this._recommendationCategory = recommendationCategory;
            return this;
        }

        /// <summary>
        /// Checks if RecommendationCategory property is set.
        /// </summary>
        /// <returns>true if RecommendationCategory property is set.</returns>
        public bool IsSetRecommendationCategory()
        {
            return this._recommendationCategory != null;
        }

        /// <summary>
        /// Gets and sets the CategoryQueryList property.
        /// </summary>
        public List<CategoryQuery> CategoryQueryList
        {
            get
            {
                if(this._categoryQueryList == null)
                {
                    this._categoryQueryList = new List<CategoryQuery>();
                }
                return this._categoryQueryList;
            }
            set { this._categoryQueryList = value; }
        }

        /// <summary>
        /// Sets the CategoryQueryList property.
        /// </summary>
        /// <param name="categoryQueryList">CategoryQueryList property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsRequest WithCategoryQueryList(CategoryQuery[] categoryQueryList)
        {
            this._categoryQueryList.AddRange(categoryQueryList);
            return this;
        }

        /// <summary>
        /// Checks if CategoryQueryList property is set.
        /// </summary>
        /// <returns>true if CategoryQueryList property is set.</returns>
        public bool IsSetCategoryQueryList()
        {
            return this.CategoryQueryList.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _sellerId = reader.Read<string>("SellerId");
            _recommendationCategory = reader.Read<string>("RecommendationCategory");
            _categoryQueryList = reader.ReadList<CategoryQuery>("CategoryQueryList", "CategoryQuery");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("SellerId", _sellerId);
            writer.Write("RecommendationCategory", _recommendationCategory);
            writer.WriteList("CategoryQueryList", "CategoryQuery", _categoryQueryList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Recommendations/2013-04-01", "ListRecommendationsRequest", this);
        }

        public ListRecommendationsRequest() : base()
        {
        }
    }
}

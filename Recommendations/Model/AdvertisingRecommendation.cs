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
 * Advertising Recommendation
 * API Version: 2013-04-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:29:19 GMT 2015
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model
{
    public class AdvertisingRecommendation : AbstractMwsObject
    {

        private DateTime? _lastUpdated;
        private ProductIdentifier _itemIdentifier;
        private string _itemName;
        private string _brandName;
        private string _productCategory;
        private decimal? _salesRank;
        private Price _yourPricePlusShipping;
        private Price _lowestPricePlusShipping;
        private decimal? _availableQuantity;
        private decimal? _salesForTheLast30Days;
        private string _recommendationId;
        private string _recommendationReason;

        /// <summary>
        /// Gets and sets the LastUpdated property.
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        /// <summary>
        /// Sets the LastUpdated property.
        /// </summary>
        /// <param name="lastUpdated">LastUpdated property.</param>
        /// <returns>this instance.</returns>
        public AdvertisingRecommendation WithLastUpdated(DateTime lastUpdated)
        {
            this._lastUpdated = lastUpdated;
            return this;
        }

        /// <summary>
        /// Checks if LastUpdated property is set.
        /// </summary>
        /// <returns>true if LastUpdated property is set.</returns>
        public bool IsSetLastUpdated()
        {
            return this._lastUpdated != null;
        }

        /// <summary>
        /// Gets and sets the ItemIdentifier property.
        /// </summary>
        public ProductIdentifier ItemIdentifier
        {
            get { return this._itemIdentifier; }
            set { this._itemIdentifier = value; }
        }

        /// <summary>
        /// Sets the ItemIdentifier property.
        /// </summary>
        /// <param name="itemIdentifier">ItemIdentifier property.</param>
        /// <returns>this instance.</returns>
        public AdvertisingRecommendation WithItemIdentifier(ProductIdentifier itemIdentifier)
        {
            this._itemIdentifier = itemIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if ItemIdentifier property is set.
        /// </summary>
        /// <returns>true if ItemIdentifier property is set.</returns>
        public bool IsSetItemIdentifier()
        {
            return this._itemIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the ItemName property.
        /// </summary>
        public string ItemName
        {
            get { return this._itemName; }
            set { this._itemName = value; }
        }

        /// <summary>
        /// Sets the ItemName property.
        /// </summary>
        /// <param name="itemName">ItemName property.</param>
        /// <returns>this instance.</returns>
        public AdvertisingRecommendation WithItemName(string itemName)
        {
            this._itemName = itemName;
            return this;
        }

        /// <summary>
        /// Checks if ItemName property is set.
        /// </summary>
        /// <returns>true if ItemName property is set.</returns>
        public bool IsSetItemName()
        {
            return this._itemName != null;
        }

        /// <summary>
        /// Gets and sets the BrandName property.
        /// </summary>
        public string BrandName
        {
            get { return this._brandName; }
            set { this._brandName = value; }
        }

        /// <summary>
        /// Sets the BrandName property.
        /// </summary>
        /// <param name="brandName">BrandName property.</param>
        /// <returns>this instance.</returns>
        public AdvertisingRecommendation WithBrandName(string brandName)
        {
            this._brandName = brandName;
            return this;
        }

        /// <summary>
        /// Checks if BrandName property is set.
        /// </summary>
        /// <returns>true if BrandName property is set.</returns>
        public bool IsSetBrandName()
        {
            return this._brandName != null;
        }

        /// <summary>
        /// Gets and sets the ProductCategory property.
        /// </summary>
        public string ProductCategory
        {
            get { return this._productCategory; }
            set { this._productCategory = value; }
        }

        /// <summary>
        /// Sets the ProductCategory property.
        /// </summary>
        /// <param name="productCategory">ProductCategory property.</param>
        /// <returns>this instance.</returns>
        public AdvertisingRecommendation WithProductCategory(string productCategory)
        {
            this._productCategory = productCategory;
            return this;
        }

        /// <summary>
        /// Checks if ProductCategory property is set.
        /// </summary>
        /// <returns>true if ProductCategory property is set.</returns>
        public bool IsSetProductCategory()
        {
            return this._productCategory != null;
        }

        /// <summary>
        /// Gets and sets the SalesRank property.
        /// </summary>
        public decimal SalesRank
        {
            get { return this._salesRank.GetValueOrDefault(); }
            set { this._salesRank = value; }
        }

        /// <summary>
        /// Sets the SalesRank property.
        /// </summary>
        /// <param name="salesRank">SalesRank property.</param>
        /// <returns>this instance.</returns>
        public AdvertisingRecommendation WithSalesRank(decimal salesRank)
        {
            this._salesRank = salesRank;
            return this;
        }

        /// <summary>
        /// Checks if SalesRank property is set.
        /// </summary>
        /// <returns>true if SalesRank property is set.</returns>
        public bool IsSetSalesRank()
        {
            return this._salesRank != null;
        }

        /// <summary>
        /// Gets and sets the YourPricePlusShipping property.
        /// </summary>
        public Price YourPricePlusShipping
        {
            get { return this._yourPricePlusShipping; }
            set { this._yourPricePlusShipping = value; }
        }

        /// <summary>
        /// Sets the YourPricePlusShipping property.
        /// </summary>
        /// <param name="yourPricePlusShipping">YourPricePlusShipping property.</param>
        /// <returns>this instance.</returns>
        public AdvertisingRecommendation WithYourPricePlusShipping(Price yourPricePlusShipping)
        {
            this._yourPricePlusShipping = yourPricePlusShipping;
            return this;
        }

        /// <summary>
        /// Checks if YourPricePlusShipping property is set.
        /// </summary>
        /// <returns>true if YourPricePlusShipping property is set.</returns>
        public bool IsSetYourPricePlusShipping()
        {
            return this._yourPricePlusShipping != null;
        }

        /// <summary>
        /// Gets and sets the LowestPricePlusShipping property.
        /// </summary>
        public Price LowestPricePlusShipping
        {
            get { return this._lowestPricePlusShipping; }
            set { this._lowestPricePlusShipping = value; }
        }

        /// <summary>
        /// Sets the LowestPricePlusShipping property.
        /// </summary>
        /// <param name="lowestPricePlusShipping">LowestPricePlusShipping property.</param>
        /// <returns>this instance.</returns>
        public AdvertisingRecommendation WithLowestPricePlusShipping(Price lowestPricePlusShipping)
        {
            this._lowestPricePlusShipping = lowestPricePlusShipping;
            return this;
        }

        /// <summary>
        /// Checks if LowestPricePlusShipping property is set.
        /// </summary>
        /// <returns>true if LowestPricePlusShipping property is set.</returns>
        public bool IsSetLowestPricePlusShipping()
        {
            return this._lowestPricePlusShipping != null;
        }

        /// <summary>
        /// Gets and sets the AvailableQuantity property.
        /// </summary>
        public decimal AvailableQuantity
        {
            get { return this._availableQuantity.GetValueOrDefault(); }
            set { this._availableQuantity = value; }
        }

        /// <summary>
        /// Sets the AvailableQuantity property.
        /// </summary>
        /// <param name="availableQuantity">AvailableQuantity property.</param>
        /// <returns>this instance.</returns>
        public AdvertisingRecommendation WithAvailableQuantity(decimal availableQuantity)
        {
            this._availableQuantity = availableQuantity;
            return this;
        }

        /// <summary>
        /// Checks if AvailableQuantity property is set.
        /// </summary>
        /// <returns>true if AvailableQuantity property is set.</returns>
        public bool IsSetAvailableQuantity()
        {
            return this._availableQuantity != null;
        }

        /// <summary>
        /// Gets and sets the SalesForTheLast30Days property.
        /// </summary>
        public decimal SalesForTheLast30Days
        {
            get { return this._salesForTheLast30Days.GetValueOrDefault(); }
            set { this._salesForTheLast30Days = value; }
        }

        /// <summary>
        /// Sets the SalesForTheLast30Days property.
        /// </summary>
        /// <param name="salesForTheLast30Days">SalesForTheLast30Days property.</param>
        /// <returns>this instance.</returns>
        public AdvertisingRecommendation WithSalesForTheLast30Days(decimal salesForTheLast30Days)
        {
            this._salesForTheLast30Days = salesForTheLast30Days;
            return this;
        }

        /// <summary>
        /// Checks if SalesForTheLast30Days property is set.
        /// </summary>
        /// <returns>true if SalesForTheLast30Days property is set.</returns>
        public bool IsSetSalesForTheLast30Days()
        {
            return this._salesForTheLast30Days != null;
        }

        /// <summary>
        /// Gets and sets the RecommendationId property.
        /// </summary>
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        /// <summary>
        /// Sets the RecommendationId property.
        /// </summary>
        /// <param name="recommendationId">RecommendationId property.</param>
        /// <returns>this instance.</returns>
        public AdvertisingRecommendation WithRecommendationId(string recommendationId)
        {
            this._recommendationId = recommendationId;
            return this;
        }

        /// <summary>
        /// Checks if RecommendationId property is set.
        /// </summary>
        /// <returns>true if RecommendationId property is set.</returns>
        public bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

        /// <summary>
        /// Gets and sets the RecommendationReason property.
        /// </summary>
        public string RecommendationReason
        {
            get { return this._recommendationReason; }
            set { this._recommendationReason = value; }
        }

        /// <summary>
        /// Sets the RecommendationReason property.
        /// </summary>
        /// <param name="recommendationReason">RecommendationReason property.</param>
        /// <returns>this instance.</returns>
        public AdvertisingRecommendation WithRecommendationReason(string recommendationReason)
        {
            this._recommendationReason = recommendationReason;
            return this;
        }

        /// <summary>
        /// Checks if RecommendationReason property is set.
        /// </summary>
        /// <returns>true if RecommendationReason property is set.</returns>
        public bool IsSetRecommendationReason()
        {
            return this._recommendationReason != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _lastUpdated = reader.Read<DateTime?>("LastUpdated");
            _itemIdentifier = reader.Read<ProductIdentifier>("ItemIdentifier");
            _itemName = reader.Read<string>("ItemName");
            _brandName = reader.Read<string>("BrandName");
            _productCategory = reader.Read<string>("ProductCategory");
            _salesRank = reader.Read<decimal?>("SalesRank");
            _yourPricePlusShipping = reader.Read<Price>("YourPricePlusShipping");
            _lowestPricePlusShipping = reader.Read<Price>("LowestPricePlusShipping");
            _availableQuantity = reader.Read<decimal?>("AvailableQuantity");
            _salesForTheLast30Days = reader.Read<decimal?>("SalesForTheLast30Days");
            _recommendationId = reader.Read<string>("RecommendationId");
            _recommendationReason = reader.Read<string>("RecommendationReason");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("LastUpdated", _lastUpdated);
            writer.Write("ItemIdentifier", _itemIdentifier);
            writer.Write("ItemName", _itemName);
            writer.Write("BrandName", _brandName);
            writer.Write("ProductCategory", _productCategory);
            writer.Write("SalesRank", _salesRank);
            writer.Write("YourPricePlusShipping", _yourPricePlusShipping);
            writer.Write("LowestPricePlusShipping", _lowestPricePlusShipping);
            writer.Write("AvailableQuantity", _availableQuantity);
            writer.Write("SalesForTheLast30Days", _salesForTheLast30Days);
            writer.Write("RecommendationId", _recommendationId);
            writer.Write("RecommendationReason", _recommendationReason);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Recommendations/2013-04-01", "AdvertisingRecommendation", this);
        }

        public AdvertisingRecommendation() : base()
        {
        }
    }
}

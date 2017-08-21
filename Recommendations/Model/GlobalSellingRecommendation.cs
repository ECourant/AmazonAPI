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
 * Global Selling Recommendation
 * API Version: 2013-04-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:29:19 GMT 2015
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model
{
    public class GlobalSellingRecommendation : AbstractMwsObject
    {

        private DateTime? _lastUpdated;
        private ProductIdentifier _itemIdentifier;
        private string _itemName;
        private string _brandName;
        private string _productCategory;
        private decimal? _salesRank;
        private Price _buyboxPrice;
        private decimal? _numberOfOffers;
        private decimal? _numberOfOffersFulfilledByAmazon;
        private decimal? _averageCustomerReview;
        private decimal? _numberOfCustomerReviews;
        private ItemDimensions _itemDimensions;
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
        public GlobalSellingRecommendation WithLastUpdated(DateTime lastUpdated)
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
        public GlobalSellingRecommendation WithItemIdentifier(ProductIdentifier itemIdentifier)
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
        public GlobalSellingRecommendation WithItemName(string itemName)
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
        public GlobalSellingRecommendation WithBrandName(string brandName)
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
        public GlobalSellingRecommendation WithProductCategory(string productCategory)
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
        public GlobalSellingRecommendation WithSalesRank(decimal salesRank)
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
        /// Gets and sets the BuyboxPrice property.
        /// </summary>
        public Price BuyboxPrice
        {
            get { return this._buyboxPrice; }
            set { this._buyboxPrice = value; }
        }

        /// <summary>
        /// Sets the BuyboxPrice property.
        /// </summary>
        /// <param name="buyboxPrice">BuyboxPrice property.</param>
        /// <returns>this instance.</returns>
        public GlobalSellingRecommendation WithBuyboxPrice(Price buyboxPrice)
        {
            this._buyboxPrice = buyboxPrice;
            return this;
        }

        /// <summary>
        /// Checks if BuyboxPrice property is set.
        /// </summary>
        /// <returns>true if BuyboxPrice property is set.</returns>
        public bool IsSetBuyboxPrice()
        {
            return this._buyboxPrice != null;
        }

        /// <summary>
        /// Gets and sets the NumberOfOffers property.
        /// </summary>
        public decimal NumberOfOffers
        {
            get { return this._numberOfOffers.GetValueOrDefault(); }
            set { this._numberOfOffers = value; }
        }

        /// <summary>
        /// Sets the NumberOfOffers property.
        /// </summary>
        /// <param name="numberOfOffers">NumberOfOffers property.</param>
        /// <returns>this instance.</returns>
        public GlobalSellingRecommendation WithNumberOfOffers(decimal numberOfOffers)
        {
            this._numberOfOffers = numberOfOffers;
            return this;
        }

        /// <summary>
        /// Checks if NumberOfOffers property is set.
        /// </summary>
        /// <returns>true if NumberOfOffers property is set.</returns>
        public bool IsSetNumberOfOffers()
        {
            return this._numberOfOffers != null;
        }

        /// <summary>
        /// Gets and sets the NumberOfOffersFulfilledByAmazon property.
        /// </summary>
        public decimal NumberOfOffersFulfilledByAmazon
        {
            get { return this._numberOfOffersFulfilledByAmazon.GetValueOrDefault(); }
            set { this._numberOfOffersFulfilledByAmazon = value; }
        }

        /// <summary>
        /// Sets the NumberOfOffersFulfilledByAmazon property.
        /// </summary>
        /// <param name="numberOfOffersFulfilledByAmazon">NumberOfOffersFulfilledByAmazon property.</param>
        /// <returns>this instance.</returns>
        public GlobalSellingRecommendation WithNumberOfOffersFulfilledByAmazon(decimal numberOfOffersFulfilledByAmazon)
        {
            this._numberOfOffersFulfilledByAmazon = numberOfOffersFulfilledByAmazon;
            return this;
        }

        /// <summary>
        /// Checks if NumberOfOffersFulfilledByAmazon property is set.
        /// </summary>
        /// <returns>true if NumberOfOffersFulfilledByAmazon property is set.</returns>
        public bool IsSetNumberOfOffersFulfilledByAmazon()
        {
            return this._numberOfOffersFulfilledByAmazon != null;
        }

        /// <summary>
        /// Gets and sets the AverageCustomerReview property.
        /// </summary>
        public decimal AverageCustomerReview
        {
            get { return this._averageCustomerReview.GetValueOrDefault(); }
            set { this._averageCustomerReview = value; }
        }

        /// <summary>
        /// Sets the AverageCustomerReview property.
        /// </summary>
        /// <param name="averageCustomerReview">AverageCustomerReview property.</param>
        /// <returns>this instance.</returns>
        public GlobalSellingRecommendation WithAverageCustomerReview(decimal averageCustomerReview)
        {
            this._averageCustomerReview = averageCustomerReview;
            return this;
        }

        /// <summary>
        /// Checks if AverageCustomerReview property is set.
        /// </summary>
        /// <returns>true if AverageCustomerReview property is set.</returns>
        public bool IsSetAverageCustomerReview()
        {
            return this._averageCustomerReview != null;
        }

        /// <summary>
        /// Gets and sets the NumberOfCustomerReviews property.
        /// </summary>
        public decimal NumberOfCustomerReviews
        {
            get { return this._numberOfCustomerReviews.GetValueOrDefault(); }
            set { this._numberOfCustomerReviews = value; }
        }

        /// <summary>
        /// Sets the NumberOfCustomerReviews property.
        /// </summary>
        /// <param name="numberOfCustomerReviews">NumberOfCustomerReviews property.</param>
        /// <returns>this instance.</returns>
        public GlobalSellingRecommendation WithNumberOfCustomerReviews(decimal numberOfCustomerReviews)
        {
            this._numberOfCustomerReviews = numberOfCustomerReviews;
            return this;
        }

        /// <summary>
        /// Checks if NumberOfCustomerReviews property is set.
        /// </summary>
        /// <returns>true if NumberOfCustomerReviews property is set.</returns>
        public bool IsSetNumberOfCustomerReviews()
        {
            return this._numberOfCustomerReviews != null;
        }

        /// <summary>
        /// Gets and sets the ItemDimensions property.
        /// </summary>
        public ItemDimensions ItemDimensions
        {
            get { return this._itemDimensions; }
            set { this._itemDimensions = value; }
        }

        /// <summary>
        /// Sets the ItemDimensions property.
        /// </summary>
        /// <param name="itemDimensions">ItemDimensions property.</param>
        /// <returns>this instance.</returns>
        public GlobalSellingRecommendation WithItemDimensions(ItemDimensions itemDimensions)
        {
            this._itemDimensions = itemDimensions;
            return this;
        }

        /// <summary>
        /// Checks if ItemDimensions property is set.
        /// </summary>
        /// <returns>true if ItemDimensions property is set.</returns>
        public bool IsSetItemDimensions()
        {
            return this._itemDimensions != null;
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
        public GlobalSellingRecommendation WithRecommendationId(string recommendationId)
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
        public GlobalSellingRecommendation WithRecommendationReason(string recommendationReason)
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
            _buyboxPrice = reader.Read<Price>("BuyboxPrice");
            _numberOfOffers = reader.Read<decimal?>("NumberOfOffers");
            _numberOfOffersFulfilledByAmazon = reader.Read<decimal?>("NumberOfOffersFulfilledByAmazon");
            _averageCustomerReview = reader.Read<decimal?>("AverageCustomerReview");
            _numberOfCustomerReviews = reader.Read<decimal?>("NumberOfCustomerReviews");
            _itemDimensions = reader.Read<ItemDimensions>("ItemDimensions");
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
            writer.Write("BuyboxPrice", _buyboxPrice);
            writer.Write("NumberOfOffers", _numberOfOffers);
            writer.Write("NumberOfOffersFulfilledByAmazon", _numberOfOffersFulfilledByAmazon);
            writer.Write("AverageCustomerReview", _averageCustomerReview);
            writer.Write("NumberOfCustomerReviews", _numberOfCustomerReviews);
            writer.Write("ItemDimensions", _itemDimensions);
            writer.Write("RecommendationId", _recommendationId);
            writer.Write("RecommendationReason", _recommendationReason);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Recommendations/2013-04-01", "GlobalSellingRecommendation", this);
        }

        public GlobalSellingRecommendation() : base()
        {
        }
    }
}

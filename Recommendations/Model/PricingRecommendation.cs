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
 * Pricing Recommendation
 * API Version: 2013-04-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:29:19 GMT 2015
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model
{
    public class PricingRecommendation : AbstractMwsObject
    {

        private DateTime? _lastUpdated;
        private ProductIdentifier _itemIdentifier;
        private string _itemName;
        private string _condition;
        private string _subCondition;
        private string _fulfillmentChannel;
        private Price _yourPricePlusShipping;
        private Price _lowestPricePlusShipping;
        private Price _priceDifferenceToLowPrice;
        private Price _medianPricePlusShipping;
        private Price _lowestMerchantFulfilledOfferPrice;
        private Price _lowestAmazonFulfilledOfferPrice;
        private decimal? _numberOfOffers;
        private decimal? _numberOfMerchantFulfilledOffers;
        private decimal? _numberOfAmazonFulfilledOffers;
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
        public PricingRecommendation WithLastUpdated(DateTime lastUpdated)
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
        public PricingRecommendation WithItemIdentifier(ProductIdentifier itemIdentifier)
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
        public PricingRecommendation WithItemName(string itemName)
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
        /// Gets and sets the Condition property.
        /// </summary>
        public string Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        /// <summary>
        /// Sets the Condition property.
        /// </summary>
        /// <param name="condition">Condition property.</param>
        /// <returns>this instance.</returns>
        public PricingRecommendation WithCondition(string condition)
        {
            this._condition = condition;
            return this;
        }

        /// <summary>
        /// Checks if Condition property is set.
        /// </summary>
        /// <returns>true if Condition property is set.</returns>
        public bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the SubCondition property.
        /// </summary>
        public string SubCondition
        {
            get { return this._subCondition; }
            set { this._subCondition = value; }
        }

        /// <summary>
        /// Sets the SubCondition property.
        /// </summary>
        /// <param name="subCondition">SubCondition property.</param>
        /// <returns>this instance.</returns>
        public PricingRecommendation WithSubCondition(string subCondition)
        {
            this._subCondition = subCondition;
            return this;
        }

        /// <summary>
        /// Checks if SubCondition property is set.
        /// </summary>
        /// <returns>true if SubCondition property is set.</returns>
        public bool IsSetSubCondition()
        {
            return this._subCondition != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentChannel property.
        /// </summary>
        public string FulfillmentChannel
        {
            get { return this._fulfillmentChannel; }
            set { this._fulfillmentChannel = value; }
        }

        /// <summary>
        /// Sets the FulfillmentChannel property.
        /// </summary>
        /// <param name="fulfillmentChannel">FulfillmentChannel property.</param>
        /// <returns>this instance.</returns>
        public PricingRecommendation WithFulfillmentChannel(string fulfillmentChannel)
        {
            this._fulfillmentChannel = fulfillmentChannel;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentChannel property is set.
        /// </summary>
        /// <returns>true if FulfillmentChannel property is set.</returns>
        public bool IsSetFulfillmentChannel()
        {
            return this._fulfillmentChannel != null;
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
        public PricingRecommendation WithYourPricePlusShipping(Price yourPricePlusShipping)
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
        public PricingRecommendation WithLowestPricePlusShipping(Price lowestPricePlusShipping)
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
        /// Gets and sets the PriceDifferenceToLowPrice property.
        /// </summary>
        public Price PriceDifferenceToLowPrice
        {
            get { return this._priceDifferenceToLowPrice; }
            set { this._priceDifferenceToLowPrice = value; }
        }

        /// <summary>
        /// Sets the PriceDifferenceToLowPrice property.
        /// </summary>
        /// <param name="priceDifferenceToLowPrice">PriceDifferenceToLowPrice property.</param>
        /// <returns>this instance.</returns>
        public PricingRecommendation WithPriceDifferenceToLowPrice(Price priceDifferenceToLowPrice)
        {
            this._priceDifferenceToLowPrice = priceDifferenceToLowPrice;
            return this;
        }

        /// <summary>
        /// Checks if PriceDifferenceToLowPrice property is set.
        /// </summary>
        /// <returns>true if PriceDifferenceToLowPrice property is set.</returns>
        public bool IsSetPriceDifferenceToLowPrice()
        {
            return this._priceDifferenceToLowPrice != null;
        }

        /// <summary>
        /// Gets and sets the MedianPricePlusShipping property.
        /// </summary>
        public Price MedianPricePlusShipping
        {
            get { return this._medianPricePlusShipping; }
            set { this._medianPricePlusShipping = value; }
        }

        /// <summary>
        /// Sets the MedianPricePlusShipping property.
        /// </summary>
        /// <param name="medianPricePlusShipping">MedianPricePlusShipping property.</param>
        /// <returns>this instance.</returns>
        public PricingRecommendation WithMedianPricePlusShipping(Price medianPricePlusShipping)
        {
            this._medianPricePlusShipping = medianPricePlusShipping;
            return this;
        }

        /// <summary>
        /// Checks if MedianPricePlusShipping property is set.
        /// </summary>
        /// <returns>true if MedianPricePlusShipping property is set.</returns>
        public bool IsSetMedianPricePlusShipping()
        {
            return this._medianPricePlusShipping != null;
        }

        /// <summary>
        /// Gets and sets the LowestMerchantFulfilledOfferPrice property.
        /// </summary>
        public Price LowestMerchantFulfilledOfferPrice
        {
            get { return this._lowestMerchantFulfilledOfferPrice; }
            set { this._lowestMerchantFulfilledOfferPrice = value; }
        }

        /// <summary>
        /// Sets the LowestMerchantFulfilledOfferPrice property.
        /// </summary>
        /// <param name="lowestMerchantFulfilledOfferPrice">LowestMerchantFulfilledOfferPrice property.</param>
        /// <returns>this instance.</returns>
        public PricingRecommendation WithLowestMerchantFulfilledOfferPrice(Price lowestMerchantFulfilledOfferPrice)
        {
            this._lowestMerchantFulfilledOfferPrice = lowestMerchantFulfilledOfferPrice;
            return this;
        }

        /// <summary>
        /// Checks if LowestMerchantFulfilledOfferPrice property is set.
        /// </summary>
        /// <returns>true if LowestMerchantFulfilledOfferPrice property is set.</returns>
        public bool IsSetLowestMerchantFulfilledOfferPrice()
        {
            return this._lowestMerchantFulfilledOfferPrice != null;
        }

        /// <summary>
        /// Gets and sets the LowestAmazonFulfilledOfferPrice property.
        /// </summary>
        public Price LowestAmazonFulfilledOfferPrice
        {
            get { return this._lowestAmazonFulfilledOfferPrice; }
            set { this._lowestAmazonFulfilledOfferPrice = value; }
        }

        /// <summary>
        /// Sets the LowestAmazonFulfilledOfferPrice property.
        /// </summary>
        /// <param name="lowestAmazonFulfilledOfferPrice">LowestAmazonFulfilledOfferPrice property.</param>
        /// <returns>this instance.</returns>
        public PricingRecommendation WithLowestAmazonFulfilledOfferPrice(Price lowestAmazonFulfilledOfferPrice)
        {
            this._lowestAmazonFulfilledOfferPrice = lowestAmazonFulfilledOfferPrice;
            return this;
        }

        /// <summary>
        /// Checks if LowestAmazonFulfilledOfferPrice property is set.
        /// </summary>
        /// <returns>true if LowestAmazonFulfilledOfferPrice property is set.</returns>
        public bool IsSetLowestAmazonFulfilledOfferPrice()
        {
            return this._lowestAmazonFulfilledOfferPrice != null;
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
        public PricingRecommendation WithNumberOfOffers(decimal numberOfOffers)
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
        /// Gets and sets the NumberOfMerchantFulfilledOffers property.
        /// </summary>
        public decimal NumberOfMerchantFulfilledOffers
        {
            get { return this._numberOfMerchantFulfilledOffers.GetValueOrDefault(); }
            set { this._numberOfMerchantFulfilledOffers = value; }
        }

        /// <summary>
        /// Sets the NumberOfMerchantFulfilledOffers property.
        /// </summary>
        /// <param name="numberOfMerchantFulfilledOffers">NumberOfMerchantFulfilledOffers property.</param>
        /// <returns>this instance.</returns>
        public PricingRecommendation WithNumberOfMerchantFulfilledOffers(decimal numberOfMerchantFulfilledOffers)
        {
            this._numberOfMerchantFulfilledOffers = numberOfMerchantFulfilledOffers;
            return this;
        }

        /// <summary>
        /// Checks if NumberOfMerchantFulfilledOffers property is set.
        /// </summary>
        /// <returns>true if NumberOfMerchantFulfilledOffers property is set.</returns>
        public bool IsSetNumberOfMerchantFulfilledOffers()
        {
            return this._numberOfMerchantFulfilledOffers != null;
        }

        /// <summary>
        /// Gets and sets the NumberOfAmazonFulfilledOffers property.
        /// </summary>
        public decimal NumberOfAmazonFulfilledOffers
        {
            get { return this._numberOfAmazonFulfilledOffers.GetValueOrDefault(); }
            set { this._numberOfAmazonFulfilledOffers = value; }
        }

        /// <summary>
        /// Sets the NumberOfAmazonFulfilledOffers property.
        /// </summary>
        /// <param name="numberOfAmazonFulfilledOffers">NumberOfAmazonFulfilledOffers property.</param>
        /// <returns>this instance.</returns>
        public PricingRecommendation WithNumberOfAmazonFulfilledOffers(decimal numberOfAmazonFulfilledOffers)
        {
            this._numberOfAmazonFulfilledOffers = numberOfAmazonFulfilledOffers;
            return this;
        }

        /// <summary>
        /// Checks if NumberOfAmazonFulfilledOffers property is set.
        /// </summary>
        /// <returns>true if NumberOfAmazonFulfilledOffers property is set.</returns>
        public bool IsSetNumberOfAmazonFulfilledOffers()
        {
            return this._numberOfAmazonFulfilledOffers != null;
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
        public PricingRecommendation WithRecommendationId(string recommendationId)
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
        public PricingRecommendation WithRecommendationReason(string recommendationReason)
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
            _condition = reader.Read<string>("Condition");
            _subCondition = reader.Read<string>("SubCondition");
            _fulfillmentChannel = reader.Read<string>("FulfillmentChannel");
            _yourPricePlusShipping = reader.Read<Price>("YourPricePlusShipping");
            _lowestPricePlusShipping = reader.Read<Price>("LowestPricePlusShipping");
            _priceDifferenceToLowPrice = reader.Read<Price>("PriceDifferenceToLowPrice");
            _medianPricePlusShipping = reader.Read<Price>("MedianPricePlusShipping");
            _lowestMerchantFulfilledOfferPrice = reader.Read<Price>("LowestMerchantFulfilledOfferPrice");
            _lowestAmazonFulfilledOfferPrice = reader.Read<Price>("LowestAmazonFulfilledOfferPrice");
            _numberOfOffers = reader.Read<decimal?>("NumberOfOffers");
            _numberOfMerchantFulfilledOffers = reader.Read<decimal?>("NumberOfMerchantFulfilledOffers");
            _numberOfAmazonFulfilledOffers = reader.Read<decimal?>("NumberOfAmazonFulfilledOffers");
            _recommendationId = reader.Read<string>("RecommendationId");
            _recommendationReason = reader.Read<string>("RecommendationReason");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("LastUpdated", _lastUpdated);
            writer.Write("ItemIdentifier", _itemIdentifier);
            writer.Write("ItemName", _itemName);
            writer.Write("Condition", _condition);
            writer.Write("SubCondition", _subCondition);
            writer.Write("FulfillmentChannel", _fulfillmentChannel);
            writer.Write("YourPricePlusShipping", _yourPricePlusShipping);
            writer.Write("LowestPricePlusShipping", _lowestPricePlusShipping);
            writer.Write("PriceDifferenceToLowPrice", _priceDifferenceToLowPrice);
            writer.Write("MedianPricePlusShipping", _medianPricePlusShipping);
            writer.Write("LowestMerchantFulfilledOfferPrice", _lowestMerchantFulfilledOfferPrice);
            writer.Write("LowestAmazonFulfilledOfferPrice", _lowestAmazonFulfilledOfferPrice);
            writer.Write("NumberOfOffers", _numberOfOffers);
            writer.Write("NumberOfMerchantFulfilledOffers", _numberOfMerchantFulfilledOffers);
            writer.Write("NumberOfAmazonFulfilledOffers", _numberOfAmazonFulfilledOffers);
            writer.Write("RecommendationId", _recommendationId);
            writer.Write("RecommendationReason", _recommendationReason);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Recommendations/2013-04-01", "PricingRecommendation", this);
        }

        public PricingRecommendation() : base()
        {
        }
    }
}

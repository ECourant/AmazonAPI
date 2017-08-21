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
 * Inventory Recommendation
 * API Version: 2013-04-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:29:19 GMT 2015
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model
{
    public class InventoryRecommendation : AbstractMwsObject
    {

        private DateTime? _lastUpdated;
        private ProductIdentifier _itemIdentifier;
        private string _itemName;
        private string _fulfillmentChannel;
        private decimal? _salesForTheLast14Days;
        private decimal? _salesForTheLast30Days;
        private decimal? _availableQuantity;
        private decimal? _daysUntilStockRunsOut;
        private decimal? _inboundQuantity;
        private decimal? _recommendedInboundQuantity;
        private decimal? _daysOutOfStockLast30Days;
        private decimal? _lostSalesInLast30Days;
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
        public InventoryRecommendation WithLastUpdated(DateTime lastUpdated)
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
        public InventoryRecommendation WithItemIdentifier(ProductIdentifier itemIdentifier)
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
        public InventoryRecommendation WithItemName(string itemName)
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
        public InventoryRecommendation WithFulfillmentChannel(string fulfillmentChannel)
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
        /// Gets and sets the SalesForTheLast14Days property.
        /// </summary>
        public decimal SalesForTheLast14Days
        {
            get { return this._salesForTheLast14Days.GetValueOrDefault(); }
            set { this._salesForTheLast14Days = value; }
        }

        /// <summary>
        /// Sets the SalesForTheLast14Days property.
        /// </summary>
        /// <param name="salesForTheLast14Days">SalesForTheLast14Days property.</param>
        /// <returns>this instance.</returns>
        public InventoryRecommendation WithSalesForTheLast14Days(decimal salesForTheLast14Days)
        {
            this._salesForTheLast14Days = salesForTheLast14Days;
            return this;
        }

        /// <summary>
        /// Checks if SalesForTheLast14Days property is set.
        /// </summary>
        /// <returns>true if SalesForTheLast14Days property is set.</returns>
        public bool IsSetSalesForTheLast14Days()
        {
            return this._salesForTheLast14Days != null;
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
        public InventoryRecommendation WithSalesForTheLast30Days(decimal salesForTheLast30Days)
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
        public InventoryRecommendation WithAvailableQuantity(decimal availableQuantity)
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
        /// Gets and sets the DaysUntilStockRunsOut property.
        /// </summary>
        public decimal DaysUntilStockRunsOut
        {
            get { return this._daysUntilStockRunsOut.GetValueOrDefault(); }
            set { this._daysUntilStockRunsOut = value; }
        }

        /// <summary>
        /// Sets the DaysUntilStockRunsOut property.
        /// </summary>
        /// <param name="daysUntilStockRunsOut">DaysUntilStockRunsOut property.</param>
        /// <returns>this instance.</returns>
        public InventoryRecommendation WithDaysUntilStockRunsOut(decimal daysUntilStockRunsOut)
        {
            this._daysUntilStockRunsOut = daysUntilStockRunsOut;
            return this;
        }

        /// <summary>
        /// Checks if DaysUntilStockRunsOut property is set.
        /// </summary>
        /// <returns>true if DaysUntilStockRunsOut property is set.</returns>
        public bool IsSetDaysUntilStockRunsOut()
        {
            return this._daysUntilStockRunsOut != null;
        }

        /// <summary>
        /// Gets and sets the InboundQuantity property.
        /// </summary>
        public decimal InboundQuantity
        {
            get { return this._inboundQuantity.GetValueOrDefault(); }
            set { this._inboundQuantity = value; }
        }

        /// <summary>
        /// Sets the InboundQuantity property.
        /// </summary>
        /// <param name="inboundQuantity">InboundQuantity property.</param>
        /// <returns>this instance.</returns>
        public InventoryRecommendation WithInboundQuantity(decimal inboundQuantity)
        {
            this._inboundQuantity = inboundQuantity;
            return this;
        }

        /// <summary>
        /// Checks if InboundQuantity property is set.
        /// </summary>
        /// <returns>true if InboundQuantity property is set.</returns>
        public bool IsSetInboundQuantity()
        {
            return this._inboundQuantity != null;
        }

        /// <summary>
        /// Gets and sets the RecommendedInboundQuantity property.
        /// </summary>
        public decimal RecommendedInboundQuantity
        {
            get { return this._recommendedInboundQuantity.GetValueOrDefault(); }
            set { this._recommendedInboundQuantity = value; }
        }

        /// <summary>
        /// Sets the RecommendedInboundQuantity property.
        /// </summary>
        /// <param name="recommendedInboundQuantity">RecommendedInboundQuantity property.</param>
        /// <returns>this instance.</returns>
        public InventoryRecommendation WithRecommendedInboundQuantity(decimal recommendedInboundQuantity)
        {
            this._recommendedInboundQuantity = recommendedInboundQuantity;
            return this;
        }

        /// <summary>
        /// Checks if RecommendedInboundQuantity property is set.
        /// </summary>
        /// <returns>true if RecommendedInboundQuantity property is set.</returns>
        public bool IsSetRecommendedInboundQuantity()
        {
            return this._recommendedInboundQuantity != null;
        }

        /// <summary>
        /// Gets and sets the DaysOutOfStockLast30Days property.
        /// </summary>
        public decimal DaysOutOfStockLast30Days
        {
            get { return this._daysOutOfStockLast30Days.GetValueOrDefault(); }
            set { this._daysOutOfStockLast30Days = value; }
        }

        /// <summary>
        /// Sets the DaysOutOfStockLast30Days property.
        /// </summary>
        /// <param name="daysOutOfStockLast30Days">DaysOutOfStockLast30Days property.</param>
        /// <returns>this instance.</returns>
        public InventoryRecommendation WithDaysOutOfStockLast30Days(decimal daysOutOfStockLast30Days)
        {
            this._daysOutOfStockLast30Days = daysOutOfStockLast30Days;
            return this;
        }

        /// <summary>
        /// Checks if DaysOutOfStockLast30Days property is set.
        /// </summary>
        /// <returns>true if DaysOutOfStockLast30Days property is set.</returns>
        public bool IsSetDaysOutOfStockLast30Days()
        {
            return this._daysOutOfStockLast30Days != null;
        }

        /// <summary>
        /// Gets and sets the LostSalesInLast30Days property.
        /// </summary>
        public decimal LostSalesInLast30Days
        {
            get { return this._lostSalesInLast30Days.GetValueOrDefault(); }
            set { this._lostSalesInLast30Days = value; }
        }

        /// <summary>
        /// Sets the LostSalesInLast30Days property.
        /// </summary>
        /// <param name="lostSalesInLast30Days">LostSalesInLast30Days property.</param>
        /// <returns>this instance.</returns>
        public InventoryRecommendation WithLostSalesInLast30Days(decimal lostSalesInLast30Days)
        {
            this._lostSalesInLast30Days = lostSalesInLast30Days;
            return this;
        }

        /// <summary>
        /// Checks if LostSalesInLast30Days property is set.
        /// </summary>
        /// <returns>true if LostSalesInLast30Days property is set.</returns>
        public bool IsSetLostSalesInLast30Days()
        {
            return this._lostSalesInLast30Days != null;
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
        public InventoryRecommendation WithRecommendationId(string recommendationId)
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
        public InventoryRecommendation WithRecommendationReason(string recommendationReason)
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
            _fulfillmentChannel = reader.Read<string>("FulfillmentChannel");
            _salesForTheLast14Days = reader.Read<decimal?>("SalesForTheLast14Days");
            _salesForTheLast30Days = reader.Read<decimal?>("SalesForTheLast30Days");
            _availableQuantity = reader.Read<decimal?>("AvailableQuantity");
            _daysUntilStockRunsOut = reader.Read<decimal?>("DaysUntilStockRunsOut");
            _inboundQuantity = reader.Read<decimal?>("InboundQuantity");
            _recommendedInboundQuantity = reader.Read<decimal?>("RecommendedInboundQuantity");
            _daysOutOfStockLast30Days = reader.Read<decimal?>("DaysOutOfStockLast30Days");
            _lostSalesInLast30Days = reader.Read<decimal?>("LostSalesInLast30Days");
            _recommendationId = reader.Read<string>("RecommendationId");
            _recommendationReason = reader.Read<string>("RecommendationReason");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("LastUpdated", _lastUpdated);
            writer.Write("ItemIdentifier", _itemIdentifier);
            writer.Write("ItemName", _itemName);
            writer.Write("FulfillmentChannel", _fulfillmentChannel);
            writer.Write("SalesForTheLast14Days", _salesForTheLast14Days);
            writer.Write("SalesForTheLast30Days", _salesForTheLast30Days);
            writer.Write("AvailableQuantity", _availableQuantity);
            writer.Write("DaysUntilStockRunsOut", _daysUntilStockRunsOut);
            writer.Write("InboundQuantity", _inboundQuantity);
            writer.Write("RecommendedInboundQuantity", _recommendedInboundQuantity);
            writer.Write("DaysOutOfStockLast30Days", _daysOutOfStockLast30Days);
            writer.Write("LostSalesInLast30Days", _lostSalesInLast30Days);
            writer.Write("RecommendationId", _recommendationId);
            writer.Write("RecommendationReason", _recommendationReason);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Recommendations/2013-04-01", "InventoryRecommendation", this);
        }

        public InventoryRecommendation() : base()
        {
        }
    }
}

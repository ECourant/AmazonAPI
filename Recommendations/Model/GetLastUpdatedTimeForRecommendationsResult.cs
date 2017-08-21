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
 * Get Last Updated Time For Recommendations Result
 * API Version: 2013-04-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:29:19 GMT 2015
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model
{
    public class GetLastUpdatedTimeForRecommendationsResult : AbstractMwsObject
    {

        private DateTime? _inventoryRecommendationsLastUpdated;
        private DateTime? _selectionRecommendationsLastUpdated;
        private DateTime? _fulfillmentRecommendationsLastUpdated;
        private DateTime? _pricingRecommendationsLastUpdated;
        private DateTime? _globalSellingRecommendationsLastUpdated;
        private DateTime? _advertisingRecommendationsLastUpdated;

        /// <summary>
        /// Gets and sets the InventoryRecommendationsLastUpdated property.
        /// </summary>
        public DateTime InventoryRecommendationsLastUpdated
        {
            get { return this._inventoryRecommendationsLastUpdated.GetValueOrDefault(); }
            set { this._inventoryRecommendationsLastUpdated = value; }
        }

        /// <summary>
        /// Sets the InventoryRecommendationsLastUpdated property.
        /// </summary>
        /// <param name="inventoryRecommendationsLastUpdated">InventoryRecommendationsLastUpdated property.</param>
        /// <returns>this instance.</returns>
        public GetLastUpdatedTimeForRecommendationsResult WithInventoryRecommendationsLastUpdated(DateTime inventoryRecommendationsLastUpdated)
        {
            this._inventoryRecommendationsLastUpdated = inventoryRecommendationsLastUpdated;
            return this;
        }

        /// <summary>
        /// Checks if InventoryRecommendationsLastUpdated property is set.
        /// </summary>
        /// <returns>true if InventoryRecommendationsLastUpdated property is set.</returns>
        public bool IsSetInventoryRecommendationsLastUpdated()
        {
            return this._inventoryRecommendationsLastUpdated != null;
        }

        /// <summary>
        /// Gets and sets the SelectionRecommendationsLastUpdated property.
        /// </summary>
        public DateTime SelectionRecommendationsLastUpdated
        {
            get { return this._selectionRecommendationsLastUpdated.GetValueOrDefault(); }
            set { this._selectionRecommendationsLastUpdated = value; }
        }

        /// <summary>
        /// Sets the SelectionRecommendationsLastUpdated property.
        /// </summary>
        /// <param name="selectionRecommendationsLastUpdated">SelectionRecommendationsLastUpdated property.</param>
        /// <returns>this instance.</returns>
        public GetLastUpdatedTimeForRecommendationsResult WithSelectionRecommendationsLastUpdated(DateTime selectionRecommendationsLastUpdated)
        {
            this._selectionRecommendationsLastUpdated = selectionRecommendationsLastUpdated;
            return this;
        }

        /// <summary>
        /// Checks if SelectionRecommendationsLastUpdated property is set.
        /// </summary>
        /// <returns>true if SelectionRecommendationsLastUpdated property is set.</returns>
        public bool IsSetSelectionRecommendationsLastUpdated()
        {
            return this._selectionRecommendationsLastUpdated != null;
        }

        /// <summary>
        /// Gets and sets the FulfillmentRecommendationsLastUpdated property.
        /// </summary>
        public DateTime FulfillmentRecommendationsLastUpdated
        {
            get { return this._fulfillmentRecommendationsLastUpdated.GetValueOrDefault(); }
            set { this._fulfillmentRecommendationsLastUpdated = value; }
        }

        /// <summary>
        /// Sets the FulfillmentRecommendationsLastUpdated property.
        /// </summary>
        /// <param name="fulfillmentRecommendationsLastUpdated">FulfillmentRecommendationsLastUpdated property.</param>
        /// <returns>this instance.</returns>
        public GetLastUpdatedTimeForRecommendationsResult WithFulfillmentRecommendationsLastUpdated(DateTime fulfillmentRecommendationsLastUpdated)
        {
            this._fulfillmentRecommendationsLastUpdated = fulfillmentRecommendationsLastUpdated;
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentRecommendationsLastUpdated property is set.
        /// </summary>
        /// <returns>true if FulfillmentRecommendationsLastUpdated property is set.</returns>
        public bool IsSetFulfillmentRecommendationsLastUpdated()
        {
            return this._fulfillmentRecommendationsLastUpdated != null;
        }

        /// <summary>
        /// Gets and sets the PricingRecommendationsLastUpdated property.
        /// </summary>
        public DateTime PricingRecommendationsLastUpdated
        {
            get { return this._pricingRecommendationsLastUpdated.GetValueOrDefault(); }
            set { this._pricingRecommendationsLastUpdated = value; }
        }

        /// <summary>
        /// Sets the PricingRecommendationsLastUpdated property.
        /// </summary>
        /// <param name="pricingRecommendationsLastUpdated">PricingRecommendationsLastUpdated property.</param>
        /// <returns>this instance.</returns>
        public GetLastUpdatedTimeForRecommendationsResult WithPricingRecommendationsLastUpdated(DateTime pricingRecommendationsLastUpdated)
        {
            this._pricingRecommendationsLastUpdated = pricingRecommendationsLastUpdated;
            return this;
        }

        /// <summary>
        /// Checks if PricingRecommendationsLastUpdated property is set.
        /// </summary>
        /// <returns>true if PricingRecommendationsLastUpdated property is set.</returns>
        public bool IsSetPricingRecommendationsLastUpdated()
        {
            return this._pricingRecommendationsLastUpdated != null;
        }

        /// <summary>
        /// Gets and sets the GlobalSellingRecommendationsLastUpdated property.
        /// </summary>
        public DateTime GlobalSellingRecommendationsLastUpdated
        {
            get { return this._globalSellingRecommendationsLastUpdated.GetValueOrDefault(); }
            set { this._globalSellingRecommendationsLastUpdated = value; }
        }

        /// <summary>
        /// Sets the GlobalSellingRecommendationsLastUpdated property.
        /// </summary>
        /// <param name="globalSellingRecommendationsLastUpdated">GlobalSellingRecommendationsLastUpdated property.</param>
        /// <returns>this instance.</returns>
        public GetLastUpdatedTimeForRecommendationsResult WithGlobalSellingRecommendationsLastUpdated(DateTime globalSellingRecommendationsLastUpdated)
        {
            this._globalSellingRecommendationsLastUpdated = globalSellingRecommendationsLastUpdated;
            return this;
        }

        /// <summary>
        /// Checks if GlobalSellingRecommendationsLastUpdated property is set.
        /// </summary>
        /// <returns>true if GlobalSellingRecommendationsLastUpdated property is set.</returns>
        public bool IsSetGlobalSellingRecommendationsLastUpdated()
        {
            return this._globalSellingRecommendationsLastUpdated != null;
        }

        /// <summary>
        /// Gets and sets the AdvertisingRecommendationsLastUpdated property.
        /// </summary>
        public DateTime AdvertisingRecommendationsLastUpdated
        {
            get { return this._advertisingRecommendationsLastUpdated.GetValueOrDefault(); }
            set { this._advertisingRecommendationsLastUpdated = value; }
        }

        /// <summary>
        /// Sets the AdvertisingRecommendationsLastUpdated property.
        /// </summary>
        /// <param name="advertisingRecommendationsLastUpdated">AdvertisingRecommendationsLastUpdated property.</param>
        /// <returns>this instance.</returns>
        public GetLastUpdatedTimeForRecommendationsResult WithAdvertisingRecommendationsLastUpdated(DateTime advertisingRecommendationsLastUpdated)
        {
            this._advertisingRecommendationsLastUpdated = advertisingRecommendationsLastUpdated;
            return this;
        }

        /// <summary>
        /// Checks if AdvertisingRecommendationsLastUpdated property is set.
        /// </summary>
        /// <returns>true if AdvertisingRecommendationsLastUpdated property is set.</returns>
        public bool IsSetAdvertisingRecommendationsLastUpdated()
        {
            return this._advertisingRecommendationsLastUpdated != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _inventoryRecommendationsLastUpdated = reader.Read<DateTime?>("InventoryRecommendationsLastUpdated");
            _selectionRecommendationsLastUpdated = reader.Read<DateTime?>("SelectionRecommendationsLastUpdated");
            _fulfillmentRecommendationsLastUpdated = reader.Read<DateTime?>("FulfillmentRecommendationsLastUpdated");
            _pricingRecommendationsLastUpdated = reader.Read<DateTime?>("PricingRecommendationsLastUpdated");
            _globalSellingRecommendationsLastUpdated = reader.Read<DateTime?>("GlobalSellingRecommendationsLastUpdated");
            _advertisingRecommendationsLastUpdated = reader.Read<DateTime?>("AdvertisingRecommendationsLastUpdated");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("InventoryRecommendationsLastUpdated", _inventoryRecommendationsLastUpdated);
            writer.Write("SelectionRecommendationsLastUpdated", _selectionRecommendationsLastUpdated);
            writer.Write("FulfillmentRecommendationsLastUpdated", _fulfillmentRecommendationsLastUpdated);
            writer.Write("PricingRecommendationsLastUpdated", _pricingRecommendationsLastUpdated);
            writer.Write("GlobalSellingRecommendationsLastUpdated", _globalSellingRecommendationsLastUpdated);
            writer.Write("AdvertisingRecommendationsLastUpdated", _advertisingRecommendationsLastUpdated);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Recommendations/2013-04-01", "GetLastUpdatedTimeForRecommendationsResult", this);
        }

        public GetLastUpdatedTimeForRecommendationsResult() : base()
        {
        }
    }
}

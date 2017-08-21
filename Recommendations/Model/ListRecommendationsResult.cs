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
 * List Recommendations Result
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
    public class ListRecommendationsResult : AbstractMwsObject
    {

        private List<InventoryRecommendation> _inventoryRecommendations;
        private List<SelectionRecommendation> _selectionRecommendations;
        private List<PricingRecommendation> _pricingRecommendations;
        private List<FulfillmentRecommendation> _fulfillmentRecommendations;
        private List<ListingQualityRecommendation> _listingQualityRecommendations;
        private List<GlobalSellingRecommendation> _globalSellingRecommendations;
        private List<AdvertisingRecommendation> _advertisingRecommendations;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the InventoryRecommendations property.
        /// </summary>
        public List<InventoryRecommendation> InventoryRecommendations
        {
            get
            {
                if(this._inventoryRecommendations == null)
                {
                    this._inventoryRecommendations = new List<InventoryRecommendation>();
                }
                return this._inventoryRecommendations;
            }
            set { this._inventoryRecommendations = value; }
        }

        /// <summary>
        /// Sets the InventoryRecommendations property.
        /// </summary>
        /// <param name="inventoryRecommendations">InventoryRecommendations property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsResult WithInventoryRecommendations(InventoryRecommendation[] inventoryRecommendations)
        {
            this._inventoryRecommendations.AddRange(inventoryRecommendations);
            return this;
        }

        /// <summary>
        /// Checks if InventoryRecommendations property is set.
        /// </summary>
        /// <returns>true if InventoryRecommendations property is set.</returns>
        public bool IsSetInventoryRecommendations()
        {
            return this.InventoryRecommendations.Count > 0;
        }

        /// <summary>
        /// Gets and sets the SelectionRecommendations property.
        /// </summary>
        public List<SelectionRecommendation> SelectionRecommendations
        {
            get
            {
                if(this._selectionRecommendations == null)
                {
                    this._selectionRecommendations = new List<SelectionRecommendation>();
                }
                return this._selectionRecommendations;
            }
            set { this._selectionRecommendations = value; }
        }

        /// <summary>
        /// Sets the SelectionRecommendations property.
        /// </summary>
        /// <param name="selectionRecommendations">SelectionRecommendations property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsResult WithSelectionRecommendations(SelectionRecommendation[] selectionRecommendations)
        {
            this._selectionRecommendations.AddRange(selectionRecommendations);
            return this;
        }

        /// <summary>
        /// Checks if SelectionRecommendations property is set.
        /// </summary>
        /// <returns>true if SelectionRecommendations property is set.</returns>
        public bool IsSetSelectionRecommendations()
        {
            return this.SelectionRecommendations.Count > 0;
        }

        /// <summary>
        /// Gets and sets the PricingRecommendations property.
        /// </summary>
        public List<PricingRecommendation> PricingRecommendations
        {
            get
            {
                if(this._pricingRecommendations == null)
                {
                    this._pricingRecommendations = new List<PricingRecommendation>();
                }
                return this._pricingRecommendations;
            }
            set { this._pricingRecommendations = value; }
        }

        /// <summary>
        /// Sets the PricingRecommendations property.
        /// </summary>
        /// <param name="pricingRecommendations">PricingRecommendations property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsResult WithPricingRecommendations(PricingRecommendation[] pricingRecommendations)
        {
            this._pricingRecommendations.AddRange(pricingRecommendations);
            return this;
        }

        /// <summary>
        /// Checks if PricingRecommendations property is set.
        /// </summary>
        /// <returns>true if PricingRecommendations property is set.</returns>
        public bool IsSetPricingRecommendations()
        {
            return this.PricingRecommendations.Count > 0;
        }

        /// <summary>
        /// Gets and sets the FulfillmentRecommendations property.
        /// </summary>
        public List<FulfillmentRecommendation> FulfillmentRecommendations
        {
            get
            {
                if(this._fulfillmentRecommendations == null)
                {
                    this._fulfillmentRecommendations = new List<FulfillmentRecommendation>();
                }
                return this._fulfillmentRecommendations;
            }
            set { this._fulfillmentRecommendations = value; }
        }

        /// <summary>
        /// Sets the FulfillmentRecommendations property.
        /// </summary>
        /// <param name="fulfillmentRecommendations">FulfillmentRecommendations property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsResult WithFulfillmentRecommendations(FulfillmentRecommendation[] fulfillmentRecommendations)
        {
            this._fulfillmentRecommendations.AddRange(fulfillmentRecommendations);
            return this;
        }

        /// <summary>
        /// Checks if FulfillmentRecommendations property is set.
        /// </summary>
        /// <returns>true if FulfillmentRecommendations property is set.</returns>
        public bool IsSetFulfillmentRecommendations()
        {
            return this.FulfillmentRecommendations.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ListingQualityRecommendations property.
        /// </summary>
        public List<ListingQualityRecommendation> ListingQualityRecommendations
        {
            get
            {
                if(this._listingQualityRecommendations == null)
                {
                    this._listingQualityRecommendations = new List<ListingQualityRecommendation>();
                }
                return this._listingQualityRecommendations;
            }
            set { this._listingQualityRecommendations = value; }
        }

        /// <summary>
        /// Sets the ListingQualityRecommendations property.
        /// </summary>
        /// <param name="listingQualityRecommendations">ListingQualityRecommendations property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsResult WithListingQualityRecommendations(ListingQualityRecommendation[] listingQualityRecommendations)
        {
            this._listingQualityRecommendations.AddRange(listingQualityRecommendations);
            return this;
        }

        /// <summary>
        /// Checks if ListingQualityRecommendations property is set.
        /// </summary>
        /// <returns>true if ListingQualityRecommendations property is set.</returns>
        public bool IsSetListingQualityRecommendations()
        {
            return this.ListingQualityRecommendations.Count > 0;
        }

        /// <summary>
        /// Gets and sets the GlobalSellingRecommendations property.
        /// </summary>
        public List<GlobalSellingRecommendation> GlobalSellingRecommendations
        {
            get
            {
                if(this._globalSellingRecommendations == null)
                {
                    this._globalSellingRecommendations = new List<GlobalSellingRecommendation>();
                }
                return this._globalSellingRecommendations;
            }
            set { this._globalSellingRecommendations = value; }
        }

        /// <summary>
        /// Sets the GlobalSellingRecommendations property.
        /// </summary>
        /// <param name="globalSellingRecommendations">GlobalSellingRecommendations property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsResult WithGlobalSellingRecommendations(GlobalSellingRecommendation[] globalSellingRecommendations)
        {
            this._globalSellingRecommendations.AddRange(globalSellingRecommendations);
            return this;
        }

        /// <summary>
        /// Checks if GlobalSellingRecommendations property is set.
        /// </summary>
        /// <returns>true if GlobalSellingRecommendations property is set.</returns>
        public bool IsSetGlobalSellingRecommendations()
        {
            return this.GlobalSellingRecommendations.Count > 0;
        }

        /// <summary>
        /// Gets and sets the AdvertisingRecommendations property.
        /// </summary>
        public List<AdvertisingRecommendation> AdvertisingRecommendations
        {
            get
            {
                if(this._advertisingRecommendations == null)
                {
                    this._advertisingRecommendations = new List<AdvertisingRecommendation>();
                }
                return this._advertisingRecommendations;
            }
            set { this._advertisingRecommendations = value; }
        }

        /// <summary>
        /// Sets the AdvertisingRecommendations property.
        /// </summary>
        /// <param name="advertisingRecommendations">AdvertisingRecommendations property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsResult WithAdvertisingRecommendations(AdvertisingRecommendation[] advertisingRecommendations)
        {
            this._advertisingRecommendations.AddRange(advertisingRecommendations);
            return this;
        }

        /// <summary>
        /// Checks if AdvertisingRecommendations property is set.
        /// </summary>
        /// <returns>true if AdvertisingRecommendations property is set.</returns>
        public bool IsSetAdvertisingRecommendations()
        {
            return this.AdvertisingRecommendations.Count > 0;
        }

        /// <summary>
        /// Gets and sets the NextToken property.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property.
        /// </summary>
        /// <param name="nextToken">NextToken property.</param>
        /// <returns>this instance.</returns>
        public ListRecommendationsResult WithNextToken(string nextToken)
        {
            this._nextToken = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if NextToken property is set.
        /// </summary>
        /// <returns>true if NextToken property is set.</returns>
        public bool IsSetNextToken()
        {
            return this._nextToken != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _inventoryRecommendations = reader.ReadList<InventoryRecommendation>("InventoryRecommendations", "member");
            _selectionRecommendations = reader.ReadList<SelectionRecommendation>("SelectionRecommendations", "member");
            _pricingRecommendations = reader.ReadList<PricingRecommendation>("PricingRecommendations", "member");
            _fulfillmentRecommendations = reader.ReadList<FulfillmentRecommendation>("FulfillmentRecommendations", "member");
            _listingQualityRecommendations = reader.ReadList<ListingQualityRecommendation>("ListingQualityRecommendations", "member");
            _globalSellingRecommendations = reader.ReadList<GlobalSellingRecommendation>("GlobalSellingRecommendations", "member");
            _advertisingRecommendations = reader.ReadList<AdvertisingRecommendation>("AdvertisingRecommendations", "member");
            _nextToken = reader.Read<string>("NextToken");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("InventoryRecommendations", "member", _inventoryRecommendations);
            writer.WriteList("SelectionRecommendations", "member", _selectionRecommendations);
            writer.WriteList("PricingRecommendations", "member", _pricingRecommendations);
            writer.WriteList("FulfillmentRecommendations", "member", _fulfillmentRecommendations);
            writer.WriteList("ListingQualityRecommendations", "member", _listingQualityRecommendations);
            writer.WriteList("GlobalSellingRecommendations", "member", _globalSellingRecommendations);
            writer.WriteList("AdvertisingRecommendations", "member", _advertisingRecommendations);
            writer.Write("NextToken", _nextToken);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Recommendations/2013-04-01", "ListRecommendationsResult", this);
        }

        public ListRecommendationsResult() : base()
        {
        }
    }
}

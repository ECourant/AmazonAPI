/*******************************************************************************
 * Copyright 2009-2017 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Lowest Price Type
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Xml;
using System.Xml.Serialization;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Products.MarketplaceWebServiceProducts.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class LowestPriceType : AbstractMwsObject
    {

        private string _condition;
        private string _fulfillmentChannel;
        private MoneyType _landedPrice;
        private MoneyType _listingPrice;
        private MoneyType _shipping;
        private Points _points;

        /// <summary>
        /// Gets and sets the condition property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "condition")]
        public string condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        /// <summary>
        /// Sets the condition property.
        /// </summary>
        /// <param name="condition">condition property.</param>
        /// <returns>this instance.</returns>
        public LowestPriceType Withcondition(string condition)
        {
            this._condition = condition;
            return this;
        }

        /// <summary>
        /// Checks if condition property is set.
        /// </summary>
        /// <returns>true if condition property is set.</returns>
        public bool IsSetcondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the fulfillmentChannel property.
        /// </summary>
        [XmlAttributeAttribute(AttributeName = "fulfillmentChannel")]
        public string fulfillmentChannel
        {
            get { return this._fulfillmentChannel; }
            set { this._fulfillmentChannel = value; }
        }

        /// <summary>
        /// Sets the fulfillmentChannel property.
        /// </summary>
        /// <param name="fulfillmentChannel">fulfillmentChannel property.</param>
        /// <returns>this instance.</returns>
        public LowestPriceType WithfulfillmentChannel(string fulfillmentChannel)
        {
            this._fulfillmentChannel = fulfillmentChannel;
            return this;
        }

        /// <summary>
        /// Checks if fulfillmentChannel property is set.
        /// </summary>
        /// <returns>true if fulfillmentChannel property is set.</returns>
        public bool IsSetfulfillmentChannel()
        {
            return this._fulfillmentChannel != null;
        }

        /// <summary>
        /// Gets and sets the LandedPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LandedPrice")]
        public MoneyType LandedPrice
        {
            get { return this._landedPrice; }
            set { this._landedPrice = value; }
        }

        /// <summary>
        /// Sets the LandedPrice property.
        /// </summary>
        /// <param name="landedPrice">LandedPrice property.</param>
        /// <returns>this instance.</returns>
        public LowestPriceType WithLandedPrice(MoneyType landedPrice)
        {
            this._landedPrice = landedPrice;
            return this;
        }

        /// <summary>
        /// Checks if LandedPrice property is set.
        /// </summary>
        /// <returns>true if LandedPrice property is set.</returns>
        public bool IsSetLandedPrice()
        {
            return this._landedPrice != null;
        }

        /// <summary>
        /// Gets and sets the ListingPrice property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ListingPrice")]
        public MoneyType ListingPrice
        {
            get { return this._listingPrice; }
            set { this._listingPrice = value; }
        }

        /// <summary>
        /// Sets the ListingPrice property.
        /// </summary>
        /// <param name="listingPrice">ListingPrice property.</param>
        /// <returns>this instance.</returns>
        public LowestPriceType WithListingPrice(MoneyType listingPrice)
        {
            this._listingPrice = listingPrice;
            return this;
        }

        /// <summary>
        /// Checks if ListingPrice property is set.
        /// </summary>
        /// <returns>true if ListingPrice property is set.</returns>
        public bool IsSetListingPrice()
        {
            return this._listingPrice != null;
        }

        /// <summary>
        /// Gets and sets the Shipping property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Shipping")]
        public MoneyType Shipping
        {
            get { return this._shipping; }
            set { this._shipping = value; }
        }

        /// <summary>
        /// Sets the Shipping property.
        /// </summary>
        /// <param name="shipping">Shipping property.</param>
        /// <returns>this instance.</returns>
        public LowestPriceType WithShipping(MoneyType shipping)
        {
            this._shipping = shipping;
            return this;
        }

        /// <summary>
        /// Checks if Shipping property is set.
        /// </summary>
        /// <returns>true if Shipping property is set.</returns>
        public bool IsSetShipping()
        {
            return this._shipping != null;
        }

        /// <summary>
        /// Gets and sets the Points property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Points")]
        public Points Points
        {
            get { return this._points; }
            set { this._points = value; }
        }

        /// <summary>
        /// Sets the Points property.
        /// </summary>
        /// <param name="points">Points property.</param>
        /// <returns>this instance.</returns>
        public LowestPriceType WithPoints(Points points)
        {
            this._points = points;
            return this;
        }

        /// <summary>
        /// Checks if Points property is set.
        /// </summary>
        /// <returns>true if Points property is set.</returns>
        public bool IsSetPoints()
        {
            return this._points != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _condition = reader.ReadAttribute<string>("condition");
            _fulfillmentChannel = reader.ReadAttribute<string>("fulfillmentChannel");
            _landedPrice = reader.Read<MoneyType>("LandedPrice");
            _listingPrice = reader.Read<MoneyType>("ListingPrice");
            _shipping = reader.Read<MoneyType>("Shipping");
            _points = reader.Read<Points>("Points");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteAttribute("condition",_condition);
            writer.WriteAttribute("fulfillmentChannel",_fulfillmentChannel);
            writer.Write("LandedPrice", _landedPrice);
            writer.Write("ListingPrice", _listingPrice);
            writer.Write("Shipping", _shipping);
            writer.Write("Points", _points);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "LowestPriceType", this);
        }

    public LowestPriceType (string condition,string fulfillmentChannel,MoneyType landedPrice,MoneyType listingPrice,MoneyType shipping) : base() {
        this._condition = condition;
        this._fulfillmentChannel = fulfillmentChannel;
        this._landedPrice = landedPrice;
        this._listingPrice = listingPrice;
        this._shipping = shipping;
    }

        public LowestPriceType() : base()
        {
        }
    }
}

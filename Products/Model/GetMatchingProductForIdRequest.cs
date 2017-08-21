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
 * Get Matching Product For Id Request
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
    public class GetMatchingProductForIdRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private string _marketplaceId;
        private string _idType;
        private IdListType _idList;

        /// <summary>
        /// Gets and sets the SellerId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SellerId")]
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
        public GetMatchingProductForIdRequest WithSellerId(string sellerId)
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
        /// Gets and sets the MWSAuthToken property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MWSAuthToken")]
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
        public GetMatchingProductForIdRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the MarketplaceId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MarketplaceId")]
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
        public GetMatchingProductForIdRequest WithMarketplaceId(string marketplaceId)
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
        /// Gets and sets the IdType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IdType")]
        public string IdType
        {
            get { return this._idType; }
            set { this._idType = value; }
        }

        /// <summary>
        /// Sets the IdType property.
        /// </summary>
        /// <param name="idType">IdType property.</param>
        /// <returns>this instance.</returns>
        public GetMatchingProductForIdRequest WithIdType(string idType)
        {
            this._idType = idType;
            return this;
        }

        /// <summary>
        /// Checks if IdType property is set.
        /// </summary>
        /// <returns>true if IdType property is set.</returns>
        public bool IsSetIdType()
        {
            return this._idType != null;
        }

        /// <summary>
        /// Gets and sets the IdList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "IdList")]
        public IdListType IdList
        {
            get { return this._idList; }
            set { this._idList = value; }
        }

        /// <summary>
        /// Sets the IdList property.
        /// </summary>
        /// <param name="idList">IdList property.</param>
        /// <returns>this instance.</returns>
        public GetMatchingProductForIdRequest WithIdList(IdListType idList)
        {
            this._idList = idList;
            return this;
        }

        /// <summary>
        /// Checks if IdList property is set.
        /// </summary>
        /// <returns>true if IdList property is set.</returns>
        public bool IsSetIdList()
        {
            return this._idList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _marketplaceId = reader.Read<string>("MarketplaceId");
            _idType = reader.Read<string>("IdType");
            _idList = reader.Read<IdListType>("IdList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("MarketplaceId", _marketplaceId);
            writer.Write("IdType", _idType);
            writer.Write("IdList", _idList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "GetMatchingProductForIdRequest", this);
        }

    public GetMatchingProductForIdRequest (string sellerId,string marketplaceId,string idType,IdListType idList) : base() {
        this._sellerId = sellerId;
        this._marketplaceId = marketplaceId;
        this._idType = idType;
        this._idList = idList;
    }

        public GetMatchingProductForIdRequest() : base()
        {
        }
    }
}

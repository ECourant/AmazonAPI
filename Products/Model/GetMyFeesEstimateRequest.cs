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
 * Get My Fees Estimate Request
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
    public class GetMyFeesEstimateRequest : AbstractMwsObject
    {

        private string _sellerId;
        private string _mwsAuthToken;
        private FeesEstimateRequestList _feesEstimateRequestList;

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
        public GetMyFeesEstimateRequest WithSellerId(string sellerId)
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
        public GetMyFeesEstimateRequest WithMWSAuthToken(string mwsAuthToken)
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
        /// Gets and sets the FeesEstimateRequestList property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeesEstimateRequestList")]
        public FeesEstimateRequestList FeesEstimateRequestList
        {
            get { return this._feesEstimateRequestList; }
            set { this._feesEstimateRequestList = value; }
        }

        /// <summary>
        /// Sets the FeesEstimateRequestList property.
        /// </summary>
        /// <param name="feesEstimateRequestList">FeesEstimateRequestList property.</param>
        /// <returns>this instance.</returns>
        public GetMyFeesEstimateRequest WithFeesEstimateRequestList(FeesEstimateRequestList feesEstimateRequestList)
        {
            this._feesEstimateRequestList = feesEstimateRequestList;
            return this;
        }

        /// <summary>
        /// Checks if FeesEstimateRequestList property is set.
        /// </summary>
        /// <returns>true if FeesEstimateRequestList property is set.</returns>
        public bool IsSetFeesEstimateRequestList()
        {
            return this._feesEstimateRequestList != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _sellerId = reader.Read<string>("SellerId");
            _mwsAuthToken = reader.Read<string>("MWSAuthToken");
            _feesEstimateRequestList = reader.Read<FeesEstimateRequestList>("FeesEstimateRequestList");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("SellerId", _sellerId);
            writer.Write("MWSAuthToken", _mwsAuthToken);
            writer.Write("FeesEstimateRequestList", _feesEstimateRequestList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "GetMyFeesEstimateRequest", this);
        }


        public GetMyFeesEstimateRequest() : base()
        {
        }
    }
}

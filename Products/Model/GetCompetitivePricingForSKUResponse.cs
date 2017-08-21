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
 * Get Competitive Pricing For SKU Response
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */


using System;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Products.MarketplaceWebServiceProducts.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01")]
    [XmlRootAttribute(Namespace = "http://mws.amazonservices.com/schema/Products/2011-10-01", IsNullable = false)]
    public class GetCompetitivePricingForSKUResponse : AbstractMwsObject, IMWSResponse
    {

        private List<GetCompetitivePricingForSKUResult> _getCompetitivePricingForSKUResult;
        private ResponseMetadata _responseMetadata;
        private ResponseHeaderMetadata _responseHeaderMetadata;

        /// <summary>
        /// Gets and sets the GetCompetitivePricingForSKUResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "GetCompetitivePricingForSKUResult")]
        public List<GetCompetitivePricingForSKUResult> GetCompetitivePricingForSKUResult
        {
            get
            {
                if(this._getCompetitivePricingForSKUResult == null)
                {
                    this._getCompetitivePricingForSKUResult = new List<GetCompetitivePricingForSKUResult>();
                }
                return this._getCompetitivePricingForSKUResult;
            }
            set { this._getCompetitivePricingForSKUResult = value; }
        }

        /// <summary>
        /// Sets the GetCompetitivePricingForSKUResult property.
        /// </summary>
        /// <param name="getCompetitivePricingForSKUResult">GetCompetitivePricingForSKUResult property.</param>
        /// <returns>this instance.</returns>
        public GetCompetitivePricingForSKUResponse WithGetCompetitivePricingForSKUResult(GetCompetitivePricingForSKUResult[] getCompetitivePricingForSKUResult)
        {
            this._getCompetitivePricingForSKUResult.AddRange(getCompetitivePricingForSKUResult);
            return this;
        }

        /// <summary>
        /// Checks if GetCompetitivePricingForSKUResult property is set.
        /// </summary>
        /// <returns>true if GetCompetitivePricingForSKUResult property is set.</returns>
        public bool IsSetGetCompetitivePricingForSKUResult()
        {
            return this.GetCompetitivePricingForSKUResult.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this._responseMetadata; }
            set { this._responseMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property.
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property.</param>
        /// <returns>this instance.</returns>
        public GetCompetitivePricingForSKUResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this._responseMetadata = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseMetadata property is set.</returns>
        public bool IsSetResponseMetadata()
        {
            return this._responseMetadata != null;
        }

        /// <summary>
        /// Gets and sets the ResponseHeaderMetadata property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseHeaderMetadata")]
        public ResponseHeaderMetadata ResponseHeaderMetadata
        {
            get { return this._responseHeaderMetadata; }
            set { this._responseHeaderMetadata = value; }
        }

        /// <summary>
        /// Sets the ResponseHeaderMetadata property.
        /// </summary>
        /// <param name="responseHeaderMetadata">ResponseHeaderMetadata property.</param>
        /// <returns>this instance.</returns>
        public GetCompetitivePricingForSKUResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
        {
            this._responseHeaderMetadata = responseHeaderMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseHeaderMetadata property is set.
        /// </summary>
        /// <returns>true if ResponseHeaderMetadata property is set.</returns>
        public bool IsSetResponseHeaderMetadata()
        {
            return this._responseHeaderMetadata != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _getCompetitivePricingForSKUResult = reader.ReadList<GetCompetitivePricingForSKUResult>("GetCompetitivePricingForSKUResult");
            _responseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("GetCompetitivePricingForSKUResult", _getCompetitivePricingForSKUResult);
            writer.Write("ResponseMetadata", _responseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "GetCompetitivePricingForSKUResponse", this);
        }


        public GetCompetitivePricingForSKUResponse() : base()
        {
        }
    }
}

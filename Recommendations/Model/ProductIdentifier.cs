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
 * Product Identifier
 * API Version: 2013-04-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:29:19 GMT 2015
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model
{
    public class ProductIdentifier : AbstractMwsObject
    {

        private string _asin;
        private string _sku;
        private string _upc;

        /// <summary>
        /// Gets and sets the Asin property.
        /// </summary>
        public string Asin
        {
            get { return this._asin; }
            set { this._asin = value; }
        }

        /// <summary>
        /// Sets the Asin property.
        /// </summary>
        /// <param name="asin">Asin property.</param>
        /// <returns>this instance.</returns>
        public ProductIdentifier WithAsin(string asin)
        {
            this._asin = asin;
            return this;
        }

        /// <summary>
        /// Checks if Asin property is set.
        /// </summary>
        /// <returns>true if Asin property is set.</returns>
        public bool IsSetAsin()
        {
            return this._asin != null;
        }

        /// <summary>
        /// Gets and sets the Sku property.
        /// </summary>
        public string Sku
        {
            get { return this._sku; }
            set { this._sku = value; }
        }

        /// <summary>
        /// Sets the Sku property.
        /// </summary>
        /// <param name="sku">Sku property.</param>
        /// <returns>this instance.</returns>
        public ProductIdentifier WithSku(string sku)
        {
            this._sku = sku;
            return this;
        }

        /// <summary>
        /// Checks if Sku property is set.
        /// </summary>
        /// <returns>true if Sku property is set.</returns>
        public bool IsSetSku()
        {
            return this._sku != null;
        }

        /// <summary>
        /// Gets and sets the Upc property.
        /// </summary>
        public string Upc
        {
            get { return this._upc; }
            set { this._upc = value; }
        }

        /// <summary>
        /// Sets the Upc property.
        /// </summary>
        /// <param name="upc">Upc property.</param>
        /// <returns>this instance.</returns>
        public ProductIdentifier WithUpc(string upc)
        {
            this._upc = upc;
            return this;
        }

        /// <summary>
        /// Checks if Upc property is set.
        /// </summary>
        /// <returns>true if Upc property is set.</returns>
        public bool IsSetUpc()
        {
            return this._upc != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _asin = reader.Read<string>("Asin");
            _sku = reader.Read<string>("Sku");
            _upc = reader.Read<string>("Upc");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Asin", _asin);
            writer.Write("Sku", _sku);
            writer.Write("Upc", _upc);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Recommendations/2013-04-01", "ProductIdentifier", this);
        }

        public ProductIdentifier() : base()
        {
        }
    }
}

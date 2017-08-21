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
 * List Financial Event Groups By Next Token Response
 * API Version: 2015-05-01
 * Library Version: 2017-03-15
 * Generated: Tue Mar 14 13:45:20 PDT 2017
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Finances.MWSFinancesService.Model
{
    public class ListFinancialEventGroupsByNextTokenResponse : AbstractMwsObject, IMWSResponse
    {

        private ListFinancialEventGroupsByNextTokenResult _listFinancialEventGroupsByNextTokenResult;
        private ResponseMetadata _responseMetadata;
        private ResponseHeaderMetadata _responseHeaderMetadata;

        /// <summary>
        /// Gets and sets the ListFinancialEventGroupsByNextTokenResult property.
        /// </summary>
        public ListFinancialEventGroupsByNextTokenResult ListFinancialEventGroupsByNextTokenResult
        {
            get { return this._listFinancialEventGroupsByNextTokenResult; }
            set { this._listFinancialEventGroupsByNextTokenResult = value; }
        }

        /// <summary>
        /// Sets the ListFinancialEventGroupsByNextTokenResult property.
        /// </summary>
        /// <param name="listFinancialEventGroupsByNextTokenResult">ListFinancialEventGroupsByNextTokenResult property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventGroupsByNextTokenResponse WithListFinancialEventGroupsByNextTokenResult(ListFinancialEventGroupsByNextTokenResult listFinancialEventGroupsByNextTokenResult)
        {
            this._listFinancialEventGroupsByNextTokenResult = listFinancialEventGroupsByNextTokenResult;
            return this;
        }

        /// <summary>
        /// Checks if ListFinancialEventGroupsByNextTokenResult property is set.
        /// </summary>
        /// <returns>true if ListFinancialEventGroupsByNextTokenResult property is set.</returns>
        public bool IsSetListFinancialEventGroupsByNextTokenResult()
        {
            return this._listFinancialEventGroupsByNextTokenResult != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
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
        public ListFinancialEventGroupsByNextTokenResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
        public ListFinancialEventGroupsByNextTokenResponse WithResponseHeaderMetadata(ResponseHeaderMetadata responseHeaderMetadata)
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
            _listFinancialEventGroupsByNextTokenResult = reader.Read<ListFinancialEventGroupsByNextTokenResult>("ListFinancialEventGroupsByNextTokenResult");
            _responseMetadata = reader.Read<ResponseMetadata>("ResponseMetadata");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("ListFinancialEventGroupsByNextTokenResult", _listFinancialEventGroupsByNextTokenResult);
            writer.Write("ResponseMetadata", _responseMetadata);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ListFinancialEventGroupsByNextTokenResponse", this);
        }


        public ListFinancialEventGroupsByNextTokenResponse() : base()
        {
        }
    }
}

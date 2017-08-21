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
 * Currency
 * API Version: 2015-05-01
 * Library Version: 2017-03-15
 * Generated: Tue Mar 14 13:45:20 PDT 2017
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Finances.MWSFinancesService.Model
{
    public class Currency : AbstractMwsObject
    {

        private string _currencyCode;
        private decimal? _currencyAmount;

        /// <summary>
        /// Gets and sets the CurrencyCode property.
        /// </summary>
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        /// <summary>
        /// Sets the CurrencyCode property.
        /// </summary>
        /// <param name="currencyCode">CurrencyCode property.</param>
        /// <returns>this instance.</returns>
        public Currency WithCurrencyCode(string currencyCode)
        {
            this._currencyCode = currencyCode;
            return this;
        }

        /// <summary>
        /// Checks if CurrencyCode property is set.
        /// </summary>
        /// <returns>true if CurrencyCode property is set.</returns>
        public bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the CurrencyAmount property.
        /// </summary>
        public decimal CurrencyAmount
        {
            get { return this._currencyAmount.GetValueOrDefault(); }
            set { this._currencyAmount = value; }
        }

        /// <summary>
        /// Sets the CurrencyAmount property.
        /// </summary>
        /// <param name="currencyAmount">CurrencyAmount property.</param>
        /// <returns>this instance.</returns>
        public Currency WithCurrencyAmount(decimal currencyAmount)
        {
            this._currencyAmount = currencyAmount;
            return this;
        }

        /// <summary>
        /// Checks if CurrencyAmount property is set.
        /// </summary>
        /// <returns>true if CurrencyAmount property is set.</returns>
        public bool IsSetCurrencyAmount()
        {
            return this._currencyAmount != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _currencyCode = reader.Read<string>("CurrencyCode");
            _currencyAmount = reader.Read<decimal?>("CurrencyAmount");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("CurrencyCode", _currencyCode);
            writer.Write("CurrencyAmount", _currencyAmount);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "Currency", this);
        }


        public Currency() : base()
        {
        }
    }
}

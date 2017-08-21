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
 * List Financial Events Result
 * API Version: 2015-05-01
 * Library Version: 2017-03-15
 * Generated: Tue Mar 14 13:45:20 PDT 2017
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Finances.MWSFinancesService.Model
{
    public class ListFinancialEventsResult : AbstractMwsObject
    {

        private string _nextToken;
        private FinancialEvents _financialEvents;

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
        public ListFinancialEventsResult WithNextToken(string nextToken)
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

        /// <summary>
        /// Gets and sets the FinancialEvents property.
        /// </summary>
        public FinancialEvents FinancialEvents
        {
            get { return this._financialEvents; }
            set { this._financialEvents = value; }
        }

        /// <summary>
        /// Sets the FinancialEvents property.
        /// </summary>
        /// <param name="financialEvents">FinancialEvents property.</param>
        /// <returns>this instance.</returns>
        public ListFinancialEventsResult WithFinancialEvents(FinancialEvents financialEvents)
        {
            this._financialEvents = financialEvents;
            return this;
        }

        /// <summary>
        /// Checks if FinancialEvents property is set.
        /// </summary>
        /// <returns>true if FinancialEvents property is set.</returns>
        public bool IsSetFinancialEvents()
        {
            return this._financialEvents != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _nextToken = reader.Read<string>("NextToken");
            _financialEvents = reader.Read<FinancialEvents>("FinancialEvents");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("NextToken", _nextToken);
            writer.Write("FinancialEvents", _financialEvents);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "ListFinancialEventsResult", this);
        }


        public ListFinancialEventsResult() : base()
        {
        }
    }
}

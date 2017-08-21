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
 * Get Service Status Result
 * API Version: 2015-05-01
 * Library Version: 2017-03-15
 * Generated: Tue Mar 14 13:45:20 PDT 2017
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Finances.MWSFinancesService.Model
{
    public class GetServiceStatusResult : AbstractMwsObject
    {

        private string _status;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the Status property.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        /// <summary>
        /// Sets the Status property.
        /// </summary>
        /// <param name="status">Status property.</param>
        /// <returns>this instance.</returns>
        public GetServiceStatusResult WithStatus(string status)
        {
            this._status = status;
            return this;
        }

        /// <summary>
        /// Checks if Status property is set.
        /// </summary>
        /// <returns>true if Status property is set.</returns>
        public bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the Timestamp property.
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        /// <summary>
        /// Sets the Timestamp property.
        /// </summary>
        /// <param name="timestamp">Timestamp property.</param>
        /// <returns>this instance.</returns>
        public GetServiceStatusResult WithTimestamp(DateTime timestamp)
        {
            this._timestamp = timestamp;
            return this;
        }

        /// <summary>
        /// Checks if Timestamp property is set.
        /// </summary>
        /// <returns>true if Timestamp property is set.</returns>
        public bool IsSetTimestamp()
        {
            return this._timestamp != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _status = reader.Read<string>("Status");
            _timestamp = reader.Read<DateTime?>("Timestamp");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Status", _status);
            writer.Write("Timestamp", _timestamp);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "GetServiceStatusResult", this);
        }


        public GetServiceStatusResult() : base()
        {
        }
    }
}

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
 * Points
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
    public class Points : AbstractMwsObject
    {

        private decimal? _pointsNumber;
        private MoneyType _pointsMonetaryValue;

        /// <summary>
        /// Gets and sets the PointsNumber property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PointsNumber")]
        public decimal PointsNumber
        {
            get { return this._pointsNumber.GetValueOrDefault(); }
            set { this._pointsNumber = value; }
        }

        /// <summary>
        /// Sets the PointsNumber property.
        /// </summary>
        /// <param name="pointsNumber">PointsNumber property.</param>
        /// <returns>this instance.</returns>
        public Points WithPointsNumber(decimal pointsNumber)
        {
            this._pointsNumber = pointsNumber;
            return this;
        }

        /// <summary>
        /// Checks if PointsNumber property is set.
        /// </summary>
        /// <returns>true if PointsNumber property is set.</returns>
        public bool IsSetPointsNumber()
        {
            return this._pointsNumber != null;
        }

        /// <summary>
        /// Gets and sets the PointsMonetaryValue property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PointsMonetaryValue")]
        public MoneyType PointsMonetaryValue
        {
            get { return this._pointsMonetaryValue; }
            set { this._pointsMonetaryValue = value; }
        }

        /// <summary>
        /// Sets the PointsMonetaryValue property.
        /// </summary>
        /// <param name="pointsMonetaryValue">PointsMonetaryValue property.</param>
        /// <returns>this instance.</returns>
        public Points WithPointsMonetaryValue(MoneyType pointsMonetaryValue)
        {
            this._pointsMonetaryValue = pointsMonetaryValue;
            return this;
        }

        /// <summary>
        /// Checks if PointsMonetaryValue property is set.
        /// </summary>
        /// <returns>true if PointsMonetaryValue property is set.</returns>
        public bool IsSetPointsMonetaryValue()
        {
            return this._pointsMonetaryValue != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _pointsNumber = reader.Read<decimal?>("PointsNumber");
            _pointsMonetaryValue = reader.Read<MoneyType>("PointsMonetaryValue");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("PointsNumber", _pointsNumber);
            writer.Write("PointsMonetaryValue", _pointsMonetaryValue);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/schema/Products/2011-10-01", "Points", this);
        }


        public Points() : base()
        {
        }
    }
}

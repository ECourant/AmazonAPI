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
 * Item Dimensions
 * API Version: 2013-04-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:29:19 GMT 2015
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model
{
    public class ItemDimensions : AbstractMwsObject
    {

        private DimensionMeasure _height;
        private DimensionMeasure _width;
        private DimensionMeasure _length;
        private WeightMeasure _weight;

        /// <summary>
        /// Gets and sets the Height property.
        /// </summary>
        public DimensionMeasure Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        /// <summary>
        /// Sets the Height property.
        /// </summary>
        /// <param name="height">Height property.</param>
        /// <returns>this instance.</returns>
        public ItemDimensions WithHeight(DimensionMeasure height)
        {
            this._height = height;
            return this;
        }

        /// <summary>
        /// Checks if Height property is set.
        /// </summary>
        /// <returns>true if Height property is set.</returns>
        public bool IsSetHeight()
        {
            return this._height != null;
        }

        /// <summary>
        /// Gets and sets the Width property.
        /// </summary>
        public DimensionMeasure Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        /// <summary>
        /// Sets the Width property.
        /// </summary>
        /// <param name="width">Width property.</param>
        /// <returns>this instance.</returns>
        public ItemDimensions WithWidth(DimensionMeasure width)
        {
            this._width = width;
            return this;
        }

        /// <summary>
        /// Checks if Width property is set.
        /// </summary>
        /// <returns>true if Width property is set.</returns>
        public bool IsSetWidth()
        {
            return this._width != null;
        }

        /// <summary>
        /// Gets and sets the Length property.
        /// </summary>
        public DimensionMeasure Length
        {
            get { return this._length; }
            set { this._length = value; }
        }

        /// <summary>
        /// Sets the Length property.
        /// </summary>
        /// <param name="length">Length property.</param>
        /// <returns>this instance.</returns>
        public ItemDimensions WithLength(DimensionMeasure length)
        {
            this._length = length;
            return this;
        }

        /// <summary>
        /// Checks if Length property is set.
        /// </summary>
        /// <returns>true if Length property is set.</returns>
        public bool IsSetLength()
        {
            return this._length != null;
        }

        /// <summary>
        /// Gets and sets the Weight property.
        /// </summary>
        public WeightMeasure Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        /// <summary>
        /// Sets the Weight property.
        /// </summary>
        /// <param name="weight">Weight property.</param>
        /// <returns>this instance.</returns>
        public ItemDimensions WithWeight(WeightMeasure weight)
        {
            this._weight = weight;
            return this;
        }

        /// <summary>
        /// Checks if Weight property is set.
        /// </summary>
        /// <returns>true if Weight property is set.</returns>
        public bool IsSetWeight()
        {
            return this._weight != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _height = reader.Read<DimensionMeasure>("Height");
            _width = reader.Read<DimensionMeasure>("Width");
            _length = reader.Read<DimensionMeasure>("Length");
            _weight = reader.Read<WeightMeasure>("Weight");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("Height", _height);
            writer.Write("Width", _width);
            writer.Write("Length", _length);
            writer.Write("Weight", _weight);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Recommendations/2013-04-01", "ItemDimensions", this);
        }

        public ItemDimensions() : base()
        {
        }
    }
}

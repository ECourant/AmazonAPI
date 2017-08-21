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
 * Listing Quality Recommendation
 * API Version: 2013-04-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:29:19 GMT 2015
 */


using System;
using System.Xml;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model
{
    public class ListingQualityRecommendation : AbstractMwsObject
    {

        private string _qualitySet;
        private string _defectGroup;
        private string _defectAttribute;
        private ProductIdentifier _itemIdentifier;
        private string _itemName;
        private string _recommendationId;
        private string _recommendationReason;

        /// <summary>
        /// Gets and sets the QualitySet property.
        /// </summary>
        public string QualitySet
        {
            get { return this._qualitySet; }
            set { this._qualitySet = value; }
        }

        /// <summary>
        /// Sets the QualitySet property.
        /// </summary>
        /// <param name="qualitySet">QualitySet property.</param>
        /// <returns>this instance.</returns>
        public ListingQualityRecommendation WithQualitySet(string qualitySet)
        {
            this._qualitySet = qualitySet;
            return this;
        }

        /// <summary>
        /// Checks if QualitySet property is set.
        /// </summary>
        /// <returns>true if QualitySet property is set.</returns>
        public bool IsSetQualitySet()
        {
            return this._qualitySet != null;
        }

        /// <summary>
        /// Gets and sets the DefectGroup property.
        /// </summary>
        public string DefectGroup
        {
            get { return this._defectGroup; }
            set { this._defectGroup = value; }
        }

        /// <summary>
        /// Sets the DefectGroup property.
        /// </summary>
        /// <param name="defectGroup">DefectGroup property.</param>
        /// <returns>this instance.</returns>
        public ListingQualityRecommendation WithDefectGroup(string defectGroup)
        {
            this._defectGroup = defectGroup;
            return this;
        }

        /// <summary>
        /// Checks if DefectGroup property is set.
        /// </summary>
        /// <returns>true if DefectGroup property is set.</returns>
        public bool IsSetDefectGroup()
        {
            return this._defectGroup != null;
        }

        /// <summary>
        /// Gets and sets the DefectAttribute property.
        /// </summary>
        public string DefectAttribute
        {
            get { return this._defectAttribute; }
            set { this._defectAttribute = value; }
        }

        /// <summary>
        /// Sets the DefectAttribute property.
        /// </summary>
        /// <param name="defectAttribute">DefectAttribute property.</param>
        /// <returns>this instance.</returns>
        public ListingQualityRecommendation WithDefectAttribute(string defectAttribute)
        {
            this._defectAttribute = defectAttribute;
            return this;
        }

        /// <summary>
        /// Checks if DefectAttribute property is set.
        /// </summary>
        /// <returns>true if DefectAttribute property is set.</returns>
        public bool IsSetDefectAttribute()
        {
            return this._defectAttribute != null;
        }

        /// <summary>
        /// Gets and sets the ItemIdentifier property.
        /// </summary>
        public ProductIdentifier ItemIdentifier
        {
            get { return this._itemIdentifier; }
            set { this._itemIdentifier = value; }
        }

        /// <summary>
        /// Sets the ItemIdentifier property.
        /// </summary>
        /// <param name="itemIdentifier">ItemIdentifier property.</param>
        /// <returns>this instance.</returns>
        public ListingQualityRecommendation WithItemIdentifier(ProductIdentifier itemIdentifier)
        {
            this._itemIdentifier = itemIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if ItemIdentifier property is set.
        /// </summary>
        /// <returns>true if ItemIdentifier property is set.</returns>
        public bool IsSetItemIdentifier()
        {
            return this._itemIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the ItemName property.
        /// </summary>
        public string ItemName
        {
            get { return this._itemName; }
            set { this._itemName = value; }
        }

        /// <summary>
        /// Sets the ItemName property.
        /// </summary>
        /// <param name="itemName">ItemName property.</param>
        /// <returns>this instance.</returns>
        public ListingQualityRecommendation WithItemName(string itemName)
        {
            this._itemName = itemName;
            return this;
        }

        /// <summary>
        /// Checks if ItemName property is set.
        /// </summary>
        /// <returns>true if ItemName property is set.</returns>
        public bool IsSetItemName()
        {
            return this._itemName != null;
        }

        /// <summary>
        /// Gets and sets the RecommendationId property.
        /// </summary>
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        /// <summary>
        /// Sets the RecommendationId property.
        /// </summary>
        /// <param name="recommendationId">RecommendationId property.</param>
        /// <returns>this instance.</returns>
        public ListingQualityRecommendation WithRecommendationId(string recommendationId)
        {
            this._recommendationId = recommendationId;
            return this;
        }

        /// <summary>
        /// Checks if RecommendationId property is set.
        /// </summary>
        /// <returns>true if RecommendationId property is set.</returns>
        public bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

        /// <summary>
        /// Gets and sets the RecommendationReason property.
        /// </summary>
        public string RecommendationReason
        {
            get { return this._recommendationReason; }
            set { this._recommendationReason = value; }
        }

        /// <summary>
        /// Sets the RecommendationReason property.
        /// </summary>
        /// <param name="recommendationReason">RecommendationReason property.</param>
        /// <returns>this instance.</returns>
        public ListingQualityRecommendation WithRecommendationReason(string recommendationReason)
        {
            this._recommendationReason = recommendationReason;
            return this;
        }

        /// <summary>
        /// Checks if RecommendationReason property is set.
        /// </summary>
        /// <returns>true if RecommendationReason property is set.</returns>
        public bool IsSetRecommendationReason()
        {
            return this._recommendationReason != null;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _qualitySet = reader.Read<string>("QualitySet");
            _defectGroup = reader.Read<string>("DefectGroup");
            _defectAttribute = reader.Read<string>("DefectAttribute");
            _itemIdentifier = reader.Read<ProductIdentifier>("ItemIdentifier");
            _itemName = reader.Read<string>("ItemName");
            _recommendationId = reader.Read<string>("RecommendationId");
            _recommendationReason = reader.Read<string>("RecommendationReason");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("QualitySet", _qualitySet);
            writer.Write("DefectGroup", _defectGroup);
            writer.Write("DefectAttribute", _defectAttribute);
            writer.Write("ItemIdentifier", _itemIdentifier);
            writer.Write("ItemName", _itemName);
            writer.Write("RecommendationId", _recommendationId);
            writer.Write("RecommendationReason", _recommendationReason);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Recommendations/2013-04-01", "ListingQualityRecommendation", this);
        }

        public ListingQualityRecommendation() : base()
        {
        }
    }
}

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
 * Category Query
 * API Version: 2013-04-01
 * Library Version: 2015-06-18
 * Generated: Thu Jun 18 19:29:19 GMT 2015
 */


using System;
using System.Xml;
using System.Collections.Generic;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Recommendations.MWSRecommendationsSectionService.Model
{
    public class CategoryQuery : AbstractMwsObject
    {

        private string _recommendationCategory;
        private List<string> _filterOptions;

        /// <summary>
        /// Gets and sets the RecommendationCategory property.
        /// </summary>
        public string RecommendationCategory
        {
            get { return this._recommendationCategory; }
            set { this._recommendationCategory = value; }
        }

        /// <summary>
        /// Sets the RecommendationCategory property.
        /// </summary>
        /// <param name="recommendationCategory">RecommendationCategory property.</param>
        /// <returns>this instance.</returns>
        public CategoryQuery WithRecommendationCategory(string recommendationCategory)
        {
            this._recommendationCategory = recommendationCategory;
            return this;
        }

        /// <summary>
        /// Checks if RecommendationCategory property is set.
        /// </summary>
        /// <returns>true if RecommendationCategory property is set.</returns>
        public bool IsSetRecommendationCategory()
        {
            return this._recommendationCategory != null;
        }

        /// <summary>
        /// Gets and sets the FilterOptions property.
        /// </summary>
        public List<string> FilterOptions
        {
            get
            {
                if(this._filterOptions == null)
                {
                    this._filterOptions = new List<string>();
                }
                return this._filterOptions;
            }
            set { this._filterOptions = value; }
        }

        /// <summary>
        /// Sets the FilterOptions property.
        /// </summary>
        /// <param name="filterOptions">FilterOptions property.</param>
        /// <returns>this instance.</returns>
        public CategoryQuery WithFilterOptions(string[] filterOptions)
        {
            this._filterOptions.AddRange(filterOptions);
            return this;
        }

        /// <summary>
        /// Checks if FilterOptions property is set.
        /// </summary>
        /// <returns>true if FilterOptions property is set.</returns>
        public bool IsSetFilterOptions()
        {
            return this.FilterOptions.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _recommendationCategory = reader.Read<string>("RecommendationCategory");
            _filterOptions = reader.ReadList<string>("FilterOptions", "FilterOption");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.Write("RecommendationCategory", _recommendationCategory);
            writer.WriteList("FilterOptions", "FilterOption", _filterOptions);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Recommendations/2013-04-01", "CategoryQuery", this);
        }

        public CategoryQuery() : base()
        {
        }
    }
}

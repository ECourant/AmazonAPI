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
 * SAFET Reimbursement Item
 * API Version: 2015-05-01
 * Library Version: 2017-03-15
 * Generated: Tue Mar 14 13:45:20 PDT 2017
 */


using System;
using System.Xml;
using System.Collections.Generic;
using AmazonAPI.MWSClientRuntime;

namespace AmazonAPI.Finances.MWSFinancesService.Model
{
    public class SAFETReimbursementItem : AbstractMwsObject
    {

        private List<ChargeComponent> _itemChargeList;

        /// <summary>
        /// Gets and sets the ItemChargeList property.
        /// </summary>
        public List<ChargeComponent> ItemChargeList
        {
            get
            {
                if(this._itemChargeList == null)
                {
                    this._itemChargeList = new List<ChargeComponent>();
                }
                return this._itemChargeList;
            }
            set { this._itemChargeList = value; }
        }

        /// <summary>
        /// Sets the ItemChargeList property.
        /// </summary>
        /// <param name="itemChargeList">ItemChargeList property.</param>
        /// <returns>this instance.</returns>
        public SAFETReimbursementItem WithItemChargeList(ChargeComponent[] itemChargeList)
        {
            this._itemChargeList.AddRange(itemChargeList);
            return this;
        }

        /// <summary>
        /// Checks if ItemChargeList property is set.
        /// </summary>
        /// <returns>true if ItemChargeList property is set.</returns>
        public bool IsSetItemChargeList()
        {
            return this.ItemChargeList.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _itemChargeList = reader.ReadList<ChargeComponent>("itemChargeList", "ChargeComponent");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("itemChargeList", "ChargeComponent", _itemChargeList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "SAFETReimbursementItem", this);
        }


        public SAFETReimbursementItem() : base()
        {
        }
    }
}

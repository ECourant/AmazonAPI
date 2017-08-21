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
 * Financial Events
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
    public class FinancialEvents : AbstractMwsObject
    {

        private List<ShipmentEvent> _shipmentEventList;
        private List<ShipmentEvent> _refundEventList;
        private List<ShipmentEvent> _guaranteeClaimEventList;
        private List<ShipmentEvent> _chargebackEventList;
        private List<PayWithAmazonEvent> _payWithAmazonEventList;
        private List<SolutionProviderCreditEvent> _serviceProviderCreditEventList;
        private List<RetrochargeEvent> _retrochargeEventList;
        private List<RentalTransactionEvent> _rentalTransactionEventList;
        private List<PerformanceBondRefundEvent> _performanceBondRefundEventList;
        private List<ServiceFeeEvent> _serviceFeeEventList;
        private List<DebtRecoveryEvent> _debtRecoveryEventList;
        private List<LoanServicingEvent> _loanServicingEventList;
        private List<AdjustmentEvent> _adjustmentEventList;
        private List<SAFETReimbursementEvent> _safetReimbursementEventList;

        /// <summary>
        /// Gets and sets the ShipmentEventList property.
        /// </summary>
        public List<ShipmentEvent> ShipmentEventList
        {
            get
            {
                if(this._shipmentEventList == null)
                {
                    this._shipmentEventList = new List<ShipmentEvent>();
                }
                return this._shipmentEventList;
            }
            set { this._shipmentEventList = value; }
        }

        /// <summary>
        /// Sets the ShipmentEventList property.
        /// </summary>
        /// <param name="shipmentEventList">ShipmentEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithShipmentEventList(ShipmentEvent[] shipmentEventList)
        {
            this._shipmentEventList.AddRange(shipmentEventList);
            return this;
        }

        /// <summary>
        /// Checks if ShipmentEventList property is set.
        /// </summary>
        /// <returns>true if ShipmentEventList property is set.</returns>
        public bool IsSetShipmentEventList()
        {
            return this.ShipmentEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the RefundEventList property.
        /// </summary>
        public List<ShipmentEvent> RefundEventList
        {
            get
            {
                if(this._refundEventList == null)
                {
                    this._refundEventList = new List<ShipmentEvent>();
                }
                return this._refundEventList;
            }
            set { this._refundEventList = value; }
        }

        /// <summary>
        /// Sets the RefundEventList property.
        /// </summary>
        /// <param name="refundEventList">RefundEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithRefundEventList(ShipmentEvent[] refundEventList)
        {
            this._refundEventList.AddRange(refundEventList);
            return this;
        }

        /// <summary>
        /// Checks if RefundEventList property is set.
        /// </summary>
        /// <returns>true if RefundEventList property is set.</returns>
        public bool IsSetRefundEventList()
        {
            return this.RefundEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the GuaranteeClaimEventList property.
        /// </summary>
        public List<ShipmentEvent> GuaranteeClaimEventList
        {
            get
            {
                if(this._guaranteeClaimEventList == null)
                {
                    this._guaranteeClaimEventList = new List<ShipmentEvent>();
                }
                return this._guaranteeClaimEventList;
            }
            set { this._guaranteeClaimEventList = value; }
        }

        /// <summary>
        /// Sets the GuaranteeClaimEventList property.
        /// </summary>
        /// <param name="guaranteeClaimEventList">GuaranteeClaimEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithGuaranteeClaimEventList(ShipmentEvent[] guaranteeClaimEventList)
        {
            this._guaranteeClaimEventList.AddRange(guaranteeClaimEventList);
            return this;
        }

        /// <summary>
        /// Checks if GuaranteeClaimEventList property is set.
        /// </summary>
        /// <returns>true if GuaranteeClaimEventList property is set.</returns>
        public bool IsSetGuaranteeClaimEventList()
        {
            return this.GuaranteeClaimEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ChargebackEventList property.
        /// </summary>
        public List<ShipmentEvent> ChargebackEventList
        {
            get
            {
                if(this._chargebackEventList == null)
                {
                    this._chargebackEventList = new List<ShipmentEvent>();
                }
                return this._chargebackEventList;
            }
            set { this._chargebackEventList = value; }
        }

        /// <summary>
        /// Sets the ChargebackEventList property.
        /// </summary>
        /// <param name="chargebackEventList">ChargebackEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithChargebackEventList(ShipmentEvent[] chargebackEventList)
        {
            this._chargebackEventList.AddRange(chargebackEventList);
            return this;
        }

        /// <summary>
        /// Checks if ChargebackEventList property is set.
        /// </summary>
        /// <returns>true if ChargebackEventList property is set.</returns>
        public bool IsSetChargebackEventList()
        {
            return this.ChargebackEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the PayWithAmazonEventList property.
        /// </summary>
        public List<PayWithAmazonEvent> PayWithAmazonEventList
        {
            get
            {
                if(this._payWithAmazonEventList == null)
                {
                    this._payWithAmazonEventList = new List<PayWithAmazonEvent>();
                }
                return this._payWithAmazonEventList;
            }
            set { this._payWithAmazonEventList = value; }
        }

        /// <summary>
        /// Sets the PayWithAmazonEventList property.
        /// </summary>
        /// <param name="payWithAmazonEventList">PayWithAmazonEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithPayWithAmazonEventList(PayWithAmazonEvent[] payWithAmazonEventList)
        {
            this._payWithAmazonEventList.AddRange(payWithAmazonEventList);
            return this;
        }

        /// <summary>
        /// Checks if PayWithAmazonEventList property is set.
        /// </summary>
        /// <returns>true if PayWithAmazonEventList property is set.</returns>
        public bool IsSetPayWithAmazonEventList()
        {
            return this.PayWithAmazonEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ServiceProviderCreditEventList property.
        /// </summary>
        public List<SolutionProviderCreditEvent> ServiceProviderCreditEventList
        {
            get
            {
                if(this._serviceProviderCreditEventList == null)
                {
                    this._serviceProviderCreditEventList = new List<SolutionProviderCreditEvent>();
                }
                return this._serviceProviderCreditEventList;
            }
            set { this._serviceProviderCreditEventList = value; }
        }

        /// <summary>
        /// Sets the ServiceProviderCreditEventList property.
        /// </summary>
        /// <param name="serviceProviderCreditEventList">ServiceProviderCreditEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithServiceProviderCreditEventList(SolutionProviderCreditEvent[] serviceProviderCreditEventList)
        {
            this._serviceProviderCreditEventList.AddRange(serviceProviderCreditEventList);
            return this;
        }

        /// <summary>
        /// Checks if ServiceProviderCreditEventList property is set.
        /// </summary>
        /// <returns>true if ServiceProviderCreditEventList property is set.</returns>
        public bool IsSetServiceProviderCreditEventList()
        {
            return this.ServiceProviderCreditEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the RetrochargeEventList property.
        /// </summary>
        public List<RetrochargeEvent> RetrochargeEventList
        {
            get
            {
                if(this._retrochargeEventList == null)
                {
                    this._retrochargeEventList = new List<RetrochargeEvent>();
                }
                return this._retrochargeEventList;
            }
            set { this._retrochargeEventList = value; }
        }

        /// <summary>
        /// Sets the RetrochargeEventList property.
        /// </summary>
        /// <param name="retrochargeEventList">RetrochargeEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithRetrochargeEventList(RetrochargeEvent[] retrochargeEventList)
        {
            this._retrochargeEventList.AddRange(retrochargeEventList);
            return this;
        }

        /// <summary>
        /// Checks if RetrochargeEventList property is set.
        /// </summary>
        /// <returns>true if RetrochargeEventList property is set.</returns>
        public bool IsSetRetrochargeEventList()
        {
            return this.RetrochargeEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the RentalTransactionEventList property.
        /// </summary>
        public List<RentalTransactionEvent> RentalTransactionEventList
        {
            get
            {
                if(this._rentalTransactionEventList == null)
                {
                    this._rentalTransactionEventList = new List<RentalTransactionEvent>();
                }
                return this._rentalTransactionEventList;
            }
            set { this._rentalTransactionEventList = value; }
        }

        /// <summary>
        /// Sets the RentalTransactionEventList property.
        /// </summary>
        /// <param name="rentalTransactionEventList">RentalTransactionEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithRentalTransactionEventList(RentalTransactionEvent[] rentalTransactionEventList)
        {
            this._rentalTransactionEventList.AddRange(rentalTransactionEventList);
            return this;
        }

        /// <summary>
        /// Checks if RentalTransactionEventList property is set.
        /// </summary>
        /// <returns>true if RentalTransactionEventList property is set.</returns>
        public bool IsSetRentalTransactionEventList()
        {
            return this.RentalTransactionEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the PerformanceBondRefundEventList property.
        /// </summary>
        public List<PerformanceBondRefundEvent> PerformanceBondRefundEventList
        {
            get
            {
                if(this._performanceBondRefundEventList == null)
                {
                    this._performanceBondRefundEventList = new List<PerformanceBondRefundEvent>();
                }
                return this._performanceBondRefundEventList;
            }
            set { this._performanceBondRefundEventList = value; }
        }

        /// <summary>
        /// Sets the PerformanceBondRefundEventList property.
        /// </summary>
        /// <param name="performanceBondRefundEventList">PerformanceBondRefundEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithPerformanceBondRefundEventList(PerformanceBondRefundEvent[] performanceBondRefundEventList)
        {
            this._performanceBondRefundEventList.AddRange(performanceBondRefundEventList);
            return this;
        }

        /// <summary>
        /// Checks if PerformanceBondRefundEventList property is set.
        /// </summary>
        /// <returns>true if PerformanceBondRefundEventList property is set.</returns>
        public bool IsSetPerformanceBondRefundEventList()
        {
            return this.PerformanceBondRefundEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the ServiceFeeEventList property.
        /// </summary>
        public List<ServiceFeeEvent> ServiceFeeEventList
        {
            get
            {
                if(this._serviceFeeEventList == null)
                {
                    this._serviceFeeEventList = new List<ServiceFeeEvent>();
                }
                return this._serviceFeeEventList;
            }
            set { this._serviceFeeEventList = value; }
        }

        /// <summary>
        /// Sets the ServiceFeeEventList property.
        /// </summary>
        /// <param name="serviceFeeEventList">ServiceFeeEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithServiceFeeEventList(ServiceFeeEvent[] serviceFeeEventList)
        {
            this._serviceFeeEventList.AddRange(serviceFeeEventList);
            return this;
        }

        /// <summary>
        /// Checks if ServiceFeeEventList property is set.
        /// </summary>
        /// <returns>true if ServiceFeeEventList property is set.</returns>
        public bool IsSetServiceFeeEventList()
        {
            return this.ServiceFeeEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the DebtRecoveryEventList property.
        /// </summary>
        public List<DebtRecoveryEvent> DebtRecoveryEventList
        {
            get
            {
                if(this._debtRecoveryEventList == null)
                {
                    this._debtRecoveryEventList = new List<DebtRecoveryEvent>();
                }
                return this._debtRecoveryEventList;
            }
            set { this._debtRecoveryEventList = value; }
        }

        /// <summary>
        /// Sets the DebtRecoveryEventList property.
        /// </summary>
        /// <param name="debtRecoveryEventList">DebtRecoveryEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithDebtRecoveryEventList(DebtRecoveryEvent[] debtRecoveryEventList)
        {
            this._debtRecoveryEventList.AddRange(debtRecoveryEventList);
            return this;
        }

        /// <summary>
        /// Checks if DebtRecoveryEventList property is set.
        /// </summary>
        /// <returns>true if DebtRecoveryEventList property is set.</returns>
        public bool IsSetDebtRecoveryEventList()
        {
            return this.DebtRecoveryEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the LoanServicingEventList property.
        /// </summary>
        public List<LoanServicingEvent> LoanServicingEventList
        {
            get
            {
                if(this._loanServicingEventList == null)
                {
                    this._loanServicingEventList = new List<LoanServicingEvent>();
                }
                return this._loanServicingEventList;
            }
            set { this._loanServicingEventList = value; }
        }

        /// <summary>
        /// Sets the LoanServicingEventList property.
        /// </summary>
        /// <param name="loanServicingEventList">LoanServicingEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithLoanServicingEventList(LoanServicingEvent[] loanServicingEventList)
        {
            this._loanServicingEventList.AddRange(loanServicingEventList);
            return this;
        }

        /// <summary>
        /// Checks if LoanServicingEventList property is set.
        /// </summary>
        /// <returns>true if LoanServicingEventList property is set.</returns>
        public bool IsSetLoanServicingEventList()
        {
            return this.LoanServicingEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the AdjustmentEventList property.
        /// </summary>
        public List<AdjustmentEvent> AdjustmentEventList
        {
            get
            {
                if(this._adjustmentEventList == null)
                {
                    this._adjustmentEventList = new List<AdjustmentEvent>();
                }
                return this._adjustmentEventList;
            }
            set { this._adjustmentEventList = value; }
        }

        /// <summary>
        /// Sets the AdjustmentEventList property.
        /// </summary>
        /// <param name="adjustmentEventList">AdjustmentEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithAdjustmentEventList(AdjustmentEvent[] adjustmentEventList)
        {
            this._adjustmentEventList.AddRange(adjustmentEventList);
            return this;
        }

        /// <summary>
        /// Checks if AdjustmentEventList property is set.
        /// </summary>
        /// <returns>true if AdjustmentEventList property is set.</returns>
        public bool IsSetAdjustmentEventList()
        {
            return this.AdjustmentEventList.Count > 0;
        }

        /// <summary>
        /// Gets and sets the SAFETReimbursementEventList property.
        /// </summary>
        public List<SAFETReimbursementEvent> SAFETReimbursementEventList
        {
            get
            {
                if(this._safetReimbursementEventList == null)
                {
                    this._safetReimbursementEventList = new List<SAFETReimbursementEvent>();
                }
                return this._safetReimbursementEventList;
            }
            set { this._safetReimbursementEventList = value; }
        }

        /// <summary>
        /// Sets the SAFETReimbursementEventList property.
        /// </summary>
        /// <param name="safetReimbursementEventList">SAFETReimbursementEventList property.</param>
        /// <returns>this instance.</returns>
        public FinancialEvents WithSAFETReimbursementEventList(SAFETReimbursementEvent[] safetReimbursementEventList)
        {
            this._safetReimbursementEventList.AddRange(safetReimbursementEventList);
            return this;
        }

        /// <summary>
        /// Checks if SAFETReimbursementEventList property is set.
        /// </summary>
        /// <returns>true if SAFETReimbursementEventList property is set.</returns>
        public bool IsSetSAFETReimbursementEventList()
        {
            return this.SAFETReimbursementEventList.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _shipmentEventList = reader.ReadList<ShipmentEvent>("ShipmentEventList", "ShipmentEvent");
            _refundEventList = reader.ReadList<ShipmentEvent>("RefundEventList", "ShipmentEvent");
            _guaranteeClaimEventList = reader.ReadList<ShipmentEvent>("GuaranteeClaimEventList", "ShipmentEvent");
            _chargebackEventList = reader.ReadList<ShipmentEvent>("ChargebackEventList", "ShipmentEvent");
            _payWithAmazonEventList = reader.ReadList<PayWithAmazonEvent>("PayWithAmazonEventList", "PayWithAmazonEvent");
            _serviceProviderCreditEventList = reader.ReadList<SolutionProviderCreditEvent>("ServiceProviderCreditEventList", "SolutionProviderCreditEvent");
            _retrochargeEventList = reader.ReadList<RetrochargeEvent>("RetrochargeEventList", "RetrochargeEvent");
            _rentalTransactionEventList = reader.ReadList<RentalTransactionEvent>("RentalTransactionEventList", "RentalTransactionEvent");
            _performanceBondRefundEventList = reader.ReadList<PerformanceBondRefundEvent>("PerformanceBondRefundEventList", "PerformanceBondRefundEvent");
            _serviceFeeEventList = reader.ReadList<ServiceFeeEvent>("ServiceFeeEventList", "ServiceFeeEvent");
            _debtRecoveryEventList = reader.ReadList<DebtRecoveryEvent>("DebtRecoveryEventList", "DebtRecoveryEvent");
            _loanServicingEventList = reader.ReadList<LoanServicingEvent>("LoanServicingEventList", "LoanServicingEvent");
            _adjustmentEventList = reader.ReadList<AdjustmentEvent>("AdjustmentEventList", "AdjustmentEvent");
            _safetReimbursementEventList = reader.ReadList<SAFETReimbursementEvent>("SAFETReimbursementEventList", "SAFETReimbursementEvent");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("ShipmentEventList", "ShipmentEvent", _shipmentEventList);
            writer.WriteList("RefundEventList", "ShipmentEvent", _refundEventList);
            writer.WriteList("GuaranteeClaimEventList", "ShipmentEvent", _guaranteeClaimEventList);
            writer.WriteList("ChargebackEventList", "ShipmentEvent", _chargebackEventList);
            writer.WriteList("PayWithAmazonEventList", "PayWithAmazonEvent", _payWithAmazonEventList);
            writer.WriteList("ServiceProviderCreditEventList", "SolutionProviderCreditEvent", _serviceProviderCreditEventList);
            writer.WriteList("RetrochargeEventList", "RetrochargeEvent", _retrochargeEventList);
            writer.WriteList("RentalTransactionEventList", "RentalTransactionEvent", _rentalTransactionEventList);
            writer.WriteList("PerformanceBondRefundEventList", "PerformanceBondRefundEvent", _performanceBondRefundEventList);
            writer.WriteList("ServiceFeeEventList", "ServiceFeeEvent", _serviceFeeEventList);
            writer.WriteList("DebtRecoveryEventList", "DebtRecoveryEvent", _debtRecoveryEventList);
            writer.WriteList("LoanServicingEventList", "LoanServicingEvent", _loanServicingEventList);
            writer.WriteList("AdjustmentEventList", "AdjustmentEvent", _adjustmentEventList);
            writer.WriteList("SAFETReimbursementEventList", "SAFETReimbursementEvent", _safetReimbursementEventList);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("http://mws.amazonservices.com/Finances/2015-05-01", "FinancialEvents", this);
        }


        public FinancialEvents() : base()
        {
        }
    }
}

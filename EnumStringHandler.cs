using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAPI
{
    internal static class EnumStringHandler
    {
        private static readonly Dictionary<Type, Dictionary<object, string>> EnumsToStrings = new Dictionary<Type, Dictionary<object, string>>()
        {
            {
                typeof(EFeedType), new Dictionary<object, string>()
                {
                    { EFeedType.ACESData, "_POST_STD_ACES_DATA_" },
                    { EFeedType.FBACreateRemoval, "_POST_FLAT_FILE_FBA_CREATE_REMOVAL_" },
                    { EFeedType.FBAFlatCreateInboundShipmentPlan, "_POST_FLAT_FILE_FBA_CREATE_INBOUND_PLAN_" },
                    { EFeedType.FBAFlatFulfillmentOrder, "_POST_FLAT_FILE_FULFILLMENT_ORDER_REQUEST_DATA_" },
                    { EFeedType.FBAFlatOrderCancellation, "_POST_FLAT_FILE_FULFILLMENT_ORDER_CANCELLATION_REQUEST_DATA_" },
                    { EFeedType.FBAFlatUpdateInboundShipmentPlan, "_POST_FLAT_FILE_FBA_UPDATE_INBOUND_PLAN_" },
                    { EFeedType.FBAFulfillmentCancellation, "_POST_FULFILLMENT_ORDER_CANCELLATION_REQUEST_DATA_" },
                    { EFeedType.FBAFulfillmentOrder, "_POST_FULFILLMENT_ORDER_REQUEST_DATA_" },
                    { EFeedType.FBAInboundShipmentCartonInformation, "_POST_FBA_INBOUND_CARTON_CONTENTS_" },
                    { EFeedType.FlatBook, "_POST_FLAT_FILE_BOOKLOADER_DATA_" },
                    { EFeedType.FlatInventory, "_POST_FLAT_FILE_INVLOADER_DATA_" },
                    { EFeedType.FlatListing, "_POST_FLAT_FILE_LISTINGS_DATA_" },
                    { EFeedType.FlatMusic, "_POST_FLAT_FILE_CONVERGENCE_LISTINGS_DATA_" },
                    { EFeedType.FlatOrderAcknowledgement, "_POST_FLAT_FILE_ORDER_ACKNOWLEDGEMENT_DATA_" },
                    { EFeedType.FlatOrderAdjustments, "_POST_FLAT_FILE_PAYMENT_ADJUSTMENT_DATA_" },
                    { EFeedType.FlatOrderFulfillment, "_POST_FLAT_FILE_FULFILLMENT_DATA_" },
                    { EFeedType.FlatPriceAndQuantity, "_POST_FLAT_FILE_PRICEANDQUANTITYONLY_UPDATE_DATA_" },
                    { EFeedType.FlatVideo, "_POST_FLAT_FILE_LISTINGS_DATA_" },
                    { EFeedType.Inventory, "_POST_INVENTORY_AVAILABILITY_DATA_" },
                    { EFeedType.OrderAcknowledgement, "_POST_ORDER_ACKNOWLEDGEMENT_DATA_" },
                    { EFeedType.OrderAdjustments, "_POST_PAYMENT_ADJUSTMENT_DATA_" },
                    { EFeedType.OrderFulfillment, "_POST_ORDER_FULFILLMENT_DATA_" },
                    { EFeedType.Overrides, "_POST_PRODUCT_OVERRIDES_DATA_" },
                    { EFeedType.Pricing, "_POST_PRODUCT_PRICING_DATA_" },
                    { EFeedType.Product, "_POST_PRODUCT_DATA_" },
                    { EFeedType.ProductImages, "_POST_PRODUCT_IMAGE_DATA_" },
                    { EFeedType.Relationships, "_POST_PRODUCT_RELATIONSHIP_DATA_" },
                    { EFeedType.UIEEInventory, "_POST_UIEE_BOOKLOADER_DATA_" },
                }
            },
            {
                typeof(EFeedProcessingStatus), new Dictionary<object, string>()
                {
                    { EFeedProcessingStatus.AwaitingAsynchronousReply, "_AWAITING_ASYNCHRONOUS_REPLY_" },
                    { EFeedProcessingStatus.Cancelled, "_CANCELLED_" },
                    { EFeedProcessingStatus.Done, "_DONE_" },
                    { EFeedProcessingStatus.InProgress, "_IN_PROGRESS_" },
                    { EFeedProcessingStatus.InSafetyNet, "_IN_SAFETY_NET_" },
                    { EFeedProcessingStatus.Submitted, "_SUBMITTED_" },
                    { EFeedProcessingStatus.Unconfirmed, "_UNCONFIRMED_" }
                }
            },
            {
                typeof(EReportType), new Dictionary<object, string>()
                {
                    { EReportType.ActiveListings, "_GET_MERCHANT_LISTINGS_DATA_" },
                    { EReportType.AllListings, "_GET_MERCHANT_LISTINGS_ALL_DATA_" },
                    { EReportType.BrowseTree, "_GET_XML_BROWSE_TREE_DATA_" },
                    { EReportType.CanceledListings, "_GET_MERCHANT_CANCELLED_LISTINGS_DATA_" },
                    { EReportType.ConvergedFlatPendingOrders, "_GET_CONVERGED_FLAT_FILE_PENDING_ORDERS_DATA_" },
                    { EReportType.FBABulkFixStrandedInventory, "_GET_STRANDED_INVENTORY_LOADER_DATA_" },
                    { EReportType.FBACrossBorderInventoryMovement, "_GET_FBA_FULFILLMENT_CROSS_BORDER_INVENTORY_MOVEMENT_DATA_" },
                    { EReportType.FBACustomerShipmentSales, "_GET_FBA_FULFILLMENT_CUSTOMER_SHIPMENT_SALES_DATA_" },
                    { EReportType.FBACustomerTaxes, "_GET_FBA_FULFILLMENT_CUSTOMER_TAXES_DATA_" },
                    { EReportType.FBADailyInventoryHistory, "_GET_FBA_FULFILLMENT_CURRENT_INVENTORY_DATA_" },
                    { EReportType.FBAFeePreview, "_GET_FBA_ESTIMATED_FBA_FEES_TXT_DATA_" },
                    { EReportType.FBAFlatAllOrdersByLastUpdate, "_GET_FLAT_FILE_ALL_ORDERS_DATA_BY_LAST_UPDATE_" },
                    { EReportType.FBAFlatAllOrdersByOrderDate, "_GET_FLAT_FILE_ALL_ORDERS_DATA_BY_ORDER_DATE_" },
                    { EReportType.FBAFulfilledInventory, "_GET_AFN_INVENTORY_DATA_" },
                    { EReportType.FBAFulfilledShipments, "_GET_AMAZON_FULFILLED_SHIPMENTS_DATA_" },
                    { EReportType.FBAInboundPerformance, "_GET_FBA_FULFILLMENT_INBOUND_NONCOMPLIANCE_DATA_" },
                    { EReportType.FBAInventoryAdjustments, "_GET_FBA_FULFILLMENT_INVENTORY_ADJUSTMENTS_DATA_" },
                    { EReportType.FBAInventoryAge, "_GET_FBA_INVENTORY_AGED_DATA_" },
                    { EReportType.FBAInventoryEventDetail, "_GET_FBA_FULFILLMENT_INVENTORY_SUMMARY_DATA_" },
                    { EReportType.FBAInventoryHealth, "_GET_FBA_FULFILLMENT_INVENTORY_HEALTH_DATA_" },
                    { EReportType.FBAManageExcessInventory, "_GET_EXCESS_INVENTORY_DATA_" },
                    { EReportType.FBAManageInventory, "_GET_FBA_MYI_UNSUPPRESSED_INVENTORY_DATA_" },
                    { EReportType.FBAManageInventoryArchived, "_GET_FBA_MYI_ALL_INVENTORY_DATA_" },
                    { EReportType.FBAMonthlyInventoryHistory, "_GET_FBA_FULFILLMENT_MONTHLY_INVENTORY_DATA_" },
                    { EReportType.FBAMultiCountryInventory, "_GET_AFN_INVENTORY_DATA_BY_COUNTRY_" },
                    { EReportType.FBAPromotions, "_GET_FBA_FULFILLMENT_CUSTOMER_SHIPMENT_PROMOTION_DATA_" },
                    { EReportType.FBAReceivedInventory, "_GET_FBA_FULFILLMENT_INVENTORY_RECEIPTS_DATA_" },
                    { EReportType.FBARecommendedRemoval, "_GET_FBA_RECOMMENDED_REMOVAL_DATA_" },
                    { EReportType.FBAReimbursments, "_GET_FBA_REIMBURSEMENTS_DATA_" },
                    { EReportType.FBARemovalOrderDetail, "_GET_FBA_FULFILLMENT_REMOVAL_ORDER_DETAIL_DATA_" },
                    { EReportType.FBARemovalShipmentDetail, "_GET_FBA_FULFILLMENT_REMOVAL_SHIPMENT_DETAIL_DATA_" },
                    { EReportType.FBAReplacements, "_GET_FBA_FULFILLMENT_CUSTOMER_SHIPMENT_REPLACEMENT_DATA_" },
                    { EReportType.FBAReservedInventory, "_GET_RESERVED_INVENTORY_DATA_" },
                    { EReportType.FBAReturns, "_GET_FBA_FULFILLMENT_CUSTOMER_RETURNS_DATA_" },
                    { EReportType.FBAStrandedInventory, "_GET_STRANDED_INVENTORY_UI_DATA_" },
                    { EReportType.FBAXMLAllOrdersByLastUpdate, "_GET_XML_ALL_ORDERS_DATA_BY_LAST_UPDATE_" },
                    { EReportType.FBAXMLAllOrdersByOrderDate, "_GET_XML_ALL_ORDERS_DATA_BY_ORDER_DATE_" },
                    { EReportType.FlatFeedback, "_GET_SELLER_FEEDBACK_DATA_" },
                    { EReportType.FlatOrder, "_GET_CONVERGED_FLAT_FILE_ORDER_REPORT_DATA_" },
                    { EReportType.FlatOrderByLastUpdate, "_GET_FLAT_FILE_ALL_ORDERS_DATA_BY_LAST_UPDATE_" },
                    { EReportType.FlatOrderByOrderDate, "_GET_FLAT_FILE_ALL_ORDERS_DATA_BY_ORDER_DATE_" },
                    { EReportType.FlatPendingOrders, "_GET_FLAT_FILE_PENDING_ORDERS_DATA_" },
                    { EReportType.FlatSettlement, "_GET_V2_SETTLEMENT_REPORT_DATA_FLAT_FILE_" },
                    { EReportType.FlatV2Settlement, "_GET_V2_SETTLEMENT_REPORT_DATA_FLAT_FILE_V2_" },
                    { EReportType.InactiveListings, "_GET_MERCHANT_LISTINGS_INACTIVE_DATA_" },
                    { EReportType.Inventory, "_GET_FLAT_FILE_OPEN_LISTINGS_DATA_" },
                    { EReportType.ListingQualityAndSuppressedListing, "_GET_MERCHANT_LISTINGS_DEFECT_DATA_" },
                    { EReportType.OpenListings, "_GET_MERCHANT_LISTINGS_DATA_BACK_COMPAT_" },
                    { EReportType.OpenListingsLite, "_GET_MERCHANT_LISTINGS_DATA_LITE_" },
                    { EReportType.OpenListingsLiter, "_GET_MERCHANT_LISTINGS_DATA_LITER_" },
                    { EReportType.RequestedOrScheduledFlatOrder, "_GET_FLAT_FILE_ORDERS_DATA_" },
                    { EReportType.RestockInventory, "_GET_RESTOCK_INVENTORY_RECOMMENDATIONS_REPORT_" },
                    { EReportType.SalesTax, "_GET_FLAT_FILE_SALES_TAX_DATA_" },
                    { EReportType.ScheduledXMLOrderReport, "_GET_ORDERS_DATA_" },
                    { EReportType.SoldListings, "_GET_CONVERGED_FLAT_FILE_SOLD_LISTINGS_DATA_" },
                    { EReportType.UnshippedOrders, "_GET_FLAT_FILE_ACTIONABLE_ORDER_DATA_" },
                    { EReportType.XMLCustomerMetrics, "_GET_V1_SELLER_PERFORMANCE_REPORT_" },
                    { EReportType.XMLOrderByLastUpdate, "_GET_XML_ALL_ORDERS_DATA_BY_LAST_UPDATE_" },
                    { EReportType.XMLOrderByOrderDate, "_GET_XML_ALL_ORDERS_DATA_BY_ORDER_DATE_" },
                    { EReportType.XMLPendingOrders, "_GET_PENDING_ORDERS_DATA_" },
                    { EReportType.XMLSettlement, "_GET_V2_SETTLEMENT_REPORT_DATA_XML_" }
                }
            },
            {
                typeof(EReportProcessingStatus), new Dictionary<object, string>()
                {
                    { EReportProcessingStatus.Cancelled, "_CANCELLED_" },
                    { EReportProcessingStatus.Done, "_DONE_" },
                    { EReportProcessingStatus.DoneNoData, "_DONE_NO_DATA_" },
                    { EReportProcessingStatus.InProgress, "_IN_PROGRESS_" },
                    { EReportProcessingStatus.Submitted, "_SUBMITTED_" }
                }
            }
        };


        internal static string GetEnumString<E>(E Enum)
        {
            if (EnumsToStrings.ContainsKey(typeof(E)))
                if (EnumsToStrings[typeof(E)].ContainsKey(Enum))
                    return EnumsToStrings[typeof(E)][Enum];
                else
                    throw new KeyNotFoundException($"The enum of type [{typeof(E).Name}] does not have a value associated with [{Enum.ToString()}]");
            else
                throw new KeyNotFoundException($"The enum of type [{typeof(E).Name}] is not a recorded enum.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAPI
{
    public enum EFeedType
    {
        Product,
        Inventory,
        Overrides,
        Pricing,
        ProductImages,
        Relationships,
        FlatInventory,
        FlatListing,
        FlatBook,
        FlatMusic,
        FlatVideo,
        FlatPriceAndQuantity,
        UIEEInventory,
        ACESData,
        OrderAcknowledgement,
        OrderAdjustments,
        OrderFulfillment,
        FlatOrderAcknowledgement,
        FlatOrderAdjustments,
        FlatOrderFulfillment,
        FBAFulfillmentOrder,
        FBAFulfillmentCancellation,
        FBAInboundShipmentCartonInformation,
        FBAFlatFulfillmentOrder,
        FBAFlatOrderCancellation,
        FBAFlatCreateInboundShipmentPlan,
        FBAFlatUpdateInboundShipmentPlan,
        FBACreateRemoval,
    }
}

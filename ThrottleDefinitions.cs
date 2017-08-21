using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAPI
{
    internal static class ThrottleDefinitions
    {
        internal static readonly Dictionary<ERequestType, ThrottleBucket> Timings = new Dictionary<ERequestType, ThrottleBucket>()
        {
            { ERequestType.CancelFeedSubmissions,               new ThrottleBucket(10, 1, 45000) },
            { ERequestType.CancelFulfillmentOrder,              new ThrottleBucket(30, 2, 1000) },
            { ERequestType.CancelReportRequests,                new ThrottleBucket(10, 1, 45000) },
            { ERequestType.CancelShipment,                      new ThrottleBucket(10, 5, 1000) },
            { ERequestType.ConfirmPreorder,                     new ThrottleBucket(30, 2, 1000) },
            { ERequestType.ConfirmTransportRequest,             new ThrottleBucket(30, 1, 1000) },
            { ERequestType.CreateFulfillmentOrder,              new ThrottleBucket(30, 2, 1000) },
            { ERequestType.CreateFulfillmentReturn,             new ThrottleBucket(30, 2, 1000) },
            { ERequestType.CreateInboundShipment,               new ThrottleBucket(30, 2, 1000) },
            { ERequestType.CreateInvoundShipmentPlan,           new ThrottleBucket(30, 2, 1000) },
            { ERequestType.CreateShipment,                      new ThrottleBucket(10, 5, 1000) },
            { ERequestType.CreateSubscription,                  new ThrottleBucket(25, 2, 1000) },
            { ERequestType.DeleteSubscription,                  new ThrottleBucket(25, 2, 1000) },
            { ERequestType.DeregisterDestination,               new ThrottleBucket(25, 2, 1000) },
            { ERequestType.EstimateTransportRequest,            new ThrottleBucket(30, 2, 1000) },
            { ERequestType.GetBillOfLading,                     new ThrottleBucket(30, 2, 1000) },
            { ERequestType.GetCompetitivePricingForASIN,        new ThrottleBucket(20, 10, 1000) },
            { ERequestType.GetCompetitivePricingForSKU,         new ThrottleBucket(20, 10, 1000) },
            { ERequestType.GetEligibleShippingServices,         new ThrottleBucket(10, 5, 1000) },
            { ERequestType.GetFeedSubmissionCount,              new ThrottleBucket(10, 1, 45000) },
            { ERequestType.GetFeedSubmissionList,               new ThrottleBucket(10, 1, 45000) },
            { ERequestType.GetFeedSubmissionListByNextToken,    new ThrottleBucket(30, 1, 2000) },
            { ERequestType.GetFeedSubmissionResult,             new ThrottleBucket(15, 1, 60000) },
            { ERequestType.GetFulfillmentOrder,                 new ThrottleBucket(30, 2, 1000) },
            { ERequestType.GetFulfillmentPreview,               new ThrottleBucket(30, 2, 1000) },
            { ERequestType.GetInboundGuidanceForASIN,           new ThrottleBucket(200, 200, 1000) },

            { ERequestType.GetReport,                           new ThrottleBucket(15, 1, 60000) },

            { ERequestType.ListOrders,                          new ThrottleBucket(6, 1, 60000) },
            { ERequestType.ListOrdersByNextToken,               new ThrottleBucket(6, 1, 60000) },

            { ERequestType.RequestReport,                       new ThrottleBucket(15, 1, 60000) },


            { ERequestType.SubmitFeed,                          new ThrottleBucket(15, 1, 120000) },
            { ERequestType.SubmitFeedPurgeAndReplace,           new ThrottleBucket(1, 1, 86400000) }
        };
    }
}

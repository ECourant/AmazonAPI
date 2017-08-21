using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonAPI.Orders.MarketplaceWebServiceOrders;
using AmazonAPI.Orders.MarketplaceWebServiceOrders.Model;
namespace AmazonAPI.Pipelines
{
    public class OrdersPipeline : IPipeline<MarketplaceWebServiceOrdersConfig, MarketplaceWebServiceOrdersClient>
    {
        internal OrdersPipeline(Delegates.GetAmazonCredentialDelegate GetCredentialDelegate, Delegates.ThrottleRequestDelegate ThrottleDelegate) : base(GetCredentialDelegate, ThrottleDelegate)
        {

        }


        public Order[] ListOrdersCreated(DateTime CreatedAfter) => ListOrders(CreatedAfter, DateTime.Now.AddMinutes(-2), default(DateTime), default(DateTime), null);
        public Order[] ListOrdersCreated(DateTime CreatedAfter, EOrderStatus[] OrderStatus) => ListOrders(CreatedAfter, DateTime.Now.AddMinutes(-2), default(DateTime), default(DateTime), OrderStatus);
        public Order[] ListOrdersCreated(DateTime CreatedAfter, DateTime CreatedBefore) => ListOrders(CreatedAfter, CreatedBefore, default(DateTime), default(DateTime), null);
        public Order[] ListOrdersUpdated(DateTime LastUpdatedAfter) => ListOrders(default(DateTime), default(DateTime), LastUpdatedAfter, DateTime.Now.AddMinutes(-2), null);
        public Order[] ListOrdersUpdated(DateTime LastUpdatedAfter, DateTime LastUpdatedBefore) => ListOrders(default(DateTime), default(DateTime), LastUpdatedAfter, LastUpdatedBefore, null);
        private Order[] ListOrders(DateTime CreatedAfter, DateTime CreatedBefore, DateTime LastUpdatedAfter, DateTime LastUpdatedBefore, EOrderStatus[] OrderStatus)
        {
            string NextToken = string.Empty;
            AmazonCredential Credentials = this.GetCredential();
            MarketplaceWebServiceOrdersClient Client = this.GetClient(Credentials);
            ListOrdersRequest Request = new ListOrdersRequest()
            {
                SellerId = Credentials.SellerID,
                MarketplaceId = new List<string>() { Credentials.MarketplaceID },
            };
            if (CreatedAfter != default(DateTime) && CreatedBefore != default(DateTime))
            {
                Request.CreatedAfter = CreatedAfter;
                Request.CreatedBefore = CreatedBefore;
            }
            if (LastUpdatedAfter != default(DateTime) && LastUpdatedBefore != default(DateTime))
            {
                Request.LastUpdatedAfter = LastUpdatedAfter;
                Request.LastUpdatedBefore = LastUpdatedBefore;
            }
            if (OrderStatus != null)
                Request.OrderStatus = OrderStatus.Select(Item => Item.ToString()).ToList();

            List<Order> Orders = new List<Order>();
            Task ListOrdersTask = new Task(() =>
            {
                while (true)
                {
                    switch (string.IsNullOrWhiteSpace(NextToken))
                    {
                        case true:
                            this.Throttle(ERequestType.ListOrders);
                            ListOrdersResponse Response = Client.ListOrders(Request);
                            if (Response.IsSetListOrdersResult())
                            {
                                ListOrdersResult Result = Response.ListOrdersResult;
                                if (Result.IsSetOrders())
                                    foreach (var Order in Result.Orders)
                                        Orders.Add(Order);

                                if (Result.IsSetNextToken())
                                    NextToken = Result.NextToken;
                                else
                                    goto EndOfLoop;
                            }
                            break;
                        case false:
                            this.Throttle(ERequestType.ListOrders);
                            ListOrdersByNextTokenRequest RequestNextToken = new ListOrdersByNextTokenRequest()
                            {
                                SellerId = Credentials.SellerID,
                                NextToken = NextToken
                            };
                            ListOrdersByNextTokenResponse ResponseNextToken = Client.ListOrdersByNextToken(RequestNextToken);
                            if (ResponseNextToken.IsSetListOrdersByNextTokenResult())
                            {
                                ListOrdersByNextTokenResult ResultNextToken = ResponseNextToken.ListOrdersByNextTokenResult;
                                if (ResultNextToken.IsSetOrders())
                                    foreach (var Order in ResultNextToken.Orders)
                                        Orders.Add(Order);

                                if (ResultNextToken.IsSetNextToken())
                                    NextToken = ResultNextToken.NextToken;
                                else
                                    goto EndOfLoop;
                            }
                            break;
                    }
                }
                EndOfLoop:
                Console.Write("");
            });
            ListOrdersTask.Start();
            ListOrdersTask.Wait((int)Math.Ceiling(TimeSpan.FromMinutes(Definitions.Timeout_Minutes).Add(TimeSpan.FromHours(Definitions.Timeout_Hours)).TotalMilliseconds));
            return Orders.ToArray();
        }
    }
}

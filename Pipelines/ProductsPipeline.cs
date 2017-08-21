using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAPI.Pipelines
{
    public class ProductsPipeline : IPipeline<Products.MarketplaceWebServiceProducts.MarketplaceWebServiceProductsConfig, Products.MarketplaceWebServiceProducts.MarketplaceWebServiceProductsClient>
    {
        internal ProductsPipeline(Delegates.GetAmazonCredentialDelegate GetCredentialDelegate, Delegates.ThrottleRequestDelegate ThrottleDelegate) : base(GetCredentialDelegate, ThrottleDelegate)
        {

        }
       



        [AmazonCall(ERequestType.ListMatchingProducts)]
        public Products.MarketplaceWebServiceProducts.Model.Product[] ListMatchingProducts(string Query)
        {
            throw new NotImplementedException();
        }
        [AmazonCall(ERequestType.ListMatchingProducts)]
        public Products.MarketplaceWebServiceProducts.Model.Product[] ListMatchingProducts(string Query, string MarketplaceID)
        {
            throw new NotImplementedException();
        }


        [AmazonCall(ERequestType.GetMatchingProduct)]
        public Products.MarketplaceWebServiceProducts.Model.Product GetMatchingProduct(params string[] ASINList)
        {
            throw new NotImplementedException();
        }
        [AmazonCall(ERequestType.GetMatchingProduct)]
        public Products.MarketplaceWebServiceProducts.Model.Product GetMatchingProduct(string[] ASINList, string MarketplaceID)
        {
            throw new NotImplementedException();
        }

    }
}

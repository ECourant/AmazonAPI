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
 * Marketplace Web Service Products
 * API Version: 2011-10-01
 * Library Version: 2017-03-22
 * Generated: Wed Mar 22 23:24:36 UTC 2017
 */

using System;
using System.IO;
using System.Reflection;
using AmazonAPI.MWSClientRuntime;
using AmazonAPI.Products.MarketplaceWebServiceProducts.Model;

namespace AmazonAPI.Products.MarketplaceWebServiceProducts.Mock
{

    /// <summary>
    /// MarketplaceWebServiceProductsMock is the implementation of MarketplaceWebServiceProducts based
    /// on the pre-populated set of XML files that serve local data. It simulates
    /// responses from MWS.
    /// </summary>
    /// <remarks>
    /// Use this to test your application without making a call to MWS
    ///
    /// Note, current Mock Service implementation does not validate requests
    /// </remarks>
    public class MarketplaceWebServiceProductsMock : MarketplaceWebServiceProducts
    {

        public GetCompetitivePricingForASINResponse GetCompetitivePricingForASIN(GetCompetitivePricingForASINRequest request)
        {
            return newResponse<GetCompetitivePricingForASINResponse>();
        }

        public GetCompetitivePricingForSKUResponse GetCompetitivePricingForSKU(GetCompetitivePricingForSKURequest request)
        {
            return newResponse<GetCompetitivePricingForSKUResponse>();
        }

        public GetLowestOfferListingsForASINResponse GetLowestOfferListingsForASIN(GetLowestOfferListingsForASINRequest request)
        {
            return newResponse<GetLowestOfferListingsForASINResponse>();
        }

        public GetLowestOfferListingsForSKUResponse GetLowestOfferListingsForSKU(GetLowestOfferListingsForSKURequest request)
        {
            return newResponse<GetLowestOfferListingsForSKUResponse>();
        }

        public GetLowestPricedOffersForASINResponse GetLowestPricedOffersForASIN(GetLowestPricedOffersForASINRequest request)
        {
            return newResponse<GetLowestPricedOffersForASINResponse>();
        }

        public GetLowestPricedOffersForSKUResponse GetLowestPricedOffersForSKU(GetLowestPricedOffersForSKURequest request)
        {
            return newResponse<GetLowestPricedOffersForSKUResponse>();
        }

        public GetMatchingProductResponse GetMatchingProduct(GetMatchingProductRequest request)
        {
            return newResponse<GetMatchingProductResponse>();
        }

        public GetMatchingProductForIdResponse GetMatchingProductForId(GetMatchingProductForIdRequest request)
        {
            return newResponse<GetMatchingProductForIdResponse>();
        }

        public GetMyFeesEstimateResponse GetMyFeesEstimate(GetMyFeesEstimateRequest request)
        {
            return newResponse<GetMyFeesEstimateResponse>();
        }

        public GetMyPriceForASINResponse GetMyPriceForASIN(GetMyPriceForASINRequest request)
        {
            return newResponse<GetMyPriceForASINResponse>();
        }

        public GetMyPriceForSKUResponse GetMyPriceForSKU(GetMyPriceForSKURequest request)
        {
            return newResponse<GetMyPriceForSKUResponse>();
        }

        public GetProductCategoriesForASINResponse GetProductCategoriesForASIN(GetProductCategoriesForASINRequest request)
        {
            return newResponse<GetProductCategoriesForASINResponse>();
        }

        public GetProductCategoriesForSKUResponse GetProductCategoriesForSKU(GetProductCategoriesForSKURequest request)
        {
            return newResponse<GetProductCategoriesForSKUResponse>();
        }

        public GetServiceStatusResponse GetServiceStatus(GetServiceStatusRequest request)
        {
            return newResponse<GetServiceStatusResponse>();
        }

        public ListMatchingProductsResponse ListMatchingProducts(ListMatchingProductsRequest request)
        {
            return newResponse<ListMatchingProductsResponse>();
        }

        private T newResponse<T>() where T : IMWSResponse {
            Stream xmlIn = null;
            try {
                xmlIn = Assembly.GetAssembly(this.GetType()).GetManifestResourceStream(typeof(T).FullName + ".xml");
                StreamReader xmlInReader = new StreamReader(xmlIn);
                string xmlStr = xmlInReader.ReadToEnd();

                MwsXmlReader reader = new MwsXmlReader(xmlStr);
                T obj = (T) Activator.CreateInstance(typeof(T));
                obj.ReadFragmentFrom(reader);
                obj.ResponseHeaderMetadata = new ResponseHeaderMetadata("mockRequestId", "A,B,C", "mockTimestamp", 0d, 0d, new DateTime());
                return obj;
            }
            catch (Exception e)
            {
                throw MwsUtil.Wrap(e);
            }
            finally
            {
                if (xmlIn != null) { xmlIn.Close(); }
            }
        }
    }
}

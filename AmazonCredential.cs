using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAPI
{
    public class AmazonCredential
    {
        public string AccessKeyID { get; set; }
        public string SecretAccessKey { get; set; }
        public string MerchantID { get; set; }
        public string MarketplaceID { get; set; }
        public string SellerID { get; set; }
    }
}

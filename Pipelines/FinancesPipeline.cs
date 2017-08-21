using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAPI.Pipelines
{
    public class FinancesPipeline : IPipeline<Finances.MWSFinancesService.MWSFinancesServiceConfig, Finances.MWSFinancesService.MWSFinancesServiceClient>
    {
        internal FinancesPipeline(Delegates.GetAmazonCredentialDelegate GetCredentialDelegate, Delegates.ThrottleRequestDelegate ThrottleDelegate) : base(GetCredentialDelegate, ThrottleDelegate)
        {

        }

    }
}

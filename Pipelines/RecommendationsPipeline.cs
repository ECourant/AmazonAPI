using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAPI.Pipelines
{
    public class RecommendationsPipeline : IPipeline<Recommendations.MWSRecommendationsSectionService.MWSRecommendationsSectionServiceConfig, Recommendations.MWSRecommendationsSectionService.MWSRecommendationsSectionServiceClient>
    {
        internal RecommendationsPipeline(Delegates.GetAmazonCredentialDelegate GetCredentialDelegate, Delegates.ThrottleRequestDelegate ThrottleDelegate) : base(GetCredentialDelegate, ThrottleDelegate)
        {

        }
    }
}

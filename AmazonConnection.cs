using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAPI
{
    public class AmazonConnection
    {
        private AmazonCredential Credentials { get; set; }
        private Pipelines.FeedsPipeline _Feeds { get; set; }
        private Pipelines.FinancesPipeline _Finances { get; set; }
        private Pipelines.OrdersPipeline _Orders { get; set; }
        private Pipelines.ProductsPipeline _Products { get; set; }
        private Pipelines.RecommendationsPipeline _Recommendations { get; set; }
        private Pipelines.ReportsPipeline _Reports { get; set; }
        
        private UnauthorizedAccessException _NoCredentials = new UnauthorizedAccessException($"Error, you cannot make calls to Amazon without credentials!");


        public AmazonConnection()
        {
            this.Timings = ThrottleDefinitions.Timings;
#if DEBUG
            this.OnCallThrottle += this.OnCallThrottleLog;
#endif
        }
        public AmazonConnection(AmazonCredential Credentials) : this()
        {
            this.Authenticate(Credentials);
        }

        public void Authenticate(AmazonCredential Credentials)
        {
            if (this.Credentials == default(AmazonCredential))
                Init(Credentials);
            else
                throw new InvalidOperationException("Error, you are already authenticated to amazon in this AmazonConnection, dispose of this connection and create a new one to connect to a different account.");
        }


        public Pipelines.FeedsPipeline Feeds => this._Feeds ?? throw _NoCredentials;
        public Pipelines.ProductsPipeline Products => this._Products ?? throw _NoCredentials;
        public Pipelines.RecommendationsPipeline Recommendations => this._Recommendations ?? throw _NoCredentials;
        public Pipelines.ReportsPipeline Reports => this._Reports ?? throw _NoCredentials;
        public Pipelines.FinancesPipeline Finances => this._Finances ?? throw _NoCredentials;
        public Pipelines.OrdersPipeline Orders => this._Orders ?? throw _NoCredentials;

        public Delegates.ThrottleEvent OnCallThrottle;

#if DEBUG
        private void OnCallThrottleLog(ERequestType RequestType, DateTime CurrentTimestamp, int BucketCount, int MaxRequestQuota, int RestoreCount, int RestorePeriod)
        {
            Console.WriteLine($"Throttle Request: {RequestType,20}\tTimestamp: {CurrentTimestamp.ToString(),10}\tBucket/Quota: {BucketCount}/{MaxRequestQuota}\tRestore Count/Period: {RestoreCount}/{RestorePeriod}ms");
        }
#endif


        private Dictionary<ERequestType, ThrottleBucket> Timings { get; set; }
        private void Throttle(ERequestType RequestType)
        {
            DateTime Timestamp = DateTime.Now;
            if (this.Timings.ContainsKey(RequestType))
            {
                Tuple<int, int, int, int> Response = this.Timings[RequestType].Pour();
                Task.Run(() =>
                {
                    this.OnCallThrottle(RequestType, Timestamp, Response.Item1, Response.Item2, Response.Item3, Response.Item4);
                });
            }
            else
                throw new NotImplementedException($"Error, the request type [{RequestType}] has not yet been implemented properly into the leaky bucket system!");
        }
        private AmazonCredential GetCredentials()
        {
            return this.Credentials;
        }

        private void Init(AmazonCredential Credentials)
        {
            this.Credentials = Credentials;
            this._Feeds = new Pipelines.FeedsPipeline(this.GetCredentials, this.Throttle);
            this._Finances = new Pipelines.FinancesPipeline(this.GetCredentials, this.Throttle);
            this._Products = new Pipelines.ProductsPipeline(this.GetCredentials, this.Throttle);
            this._Recommendations = new Pipelines.RecommendationsPipeline(this.GetCredentials, this.Throttle);
            this._Reports = new Pipelines.ReportsPipeline(this.GetCredentials, this.Throttle);
            this._Orders = new Pipelines.OrdersPipeline(this.GetCredentials, this.Throttle);
        }
    }
}

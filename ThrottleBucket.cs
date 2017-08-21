using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace AmazonAPI
{
    internal class ThrottleBucket
    {
        internal int MaximumRequestQuota { get; set; }
        internal int RestoreRateCount { get; set; }
        internal int RestoreRatePeriod { get; set; }

        internal DateTime LastRequest { get; set; }
        internal int BucketCount { get; set; }

        internal int RequestsSent { get; set; }

        internal ThrottleBucket(int MaxRequestQuota, int RestoreCount, int RestorePeriod)
        {
            this.MaximumRequestQuota = MaxRequestQuota - 1;
            this.RestoreRateCount = RestoreCount;
            this.RestoreRatePeriod = RestorePeriod;
            this.LastRequest = DateTime.Now;
            this.BucketCount = 0;
            this.RequestsSent = 0;
        }


        internal Tuple<int, int, int, int> Pour()
        {
            if (BucketCount < 0)
                BucketCount = 0;
            DateTime Last = LastRequest;
            if (BucketCount > 0)
            {
                while (true)
                {
                    Last = Last.AddMilliseconds(RestoreRatePeriod);
                    if (Last > DateTime.Now)
                        break;
                    else
                        BucketCount -= RestoreRateCount;
                }
            }
            if (BucketCount < 0)
                BucketCount = 0;

            if (BucketCount >= MaximumRequestQuota)
            {
                
                LastRequest = LastRequest.AddMilliseconds(RestoreRatePeriod);
                while (LastRequest >= DateTime.Now)
                    Thread.Sleep(100);
            }
            if (BucketCount + 1 <= MaximumRequestQuota)
                BucketCount += 1;
            LastRequest = DateTime.Now;
            RequestsSent++;
            return new Tuple<int, int, int, int>(BucketCount, MaximumRequestQuota, RestoreRateCount, RestoreRatePeriod);
        }
    }
}

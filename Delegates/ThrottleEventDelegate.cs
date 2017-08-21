using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAPI.Delegates
{
    public delegate void ThrottleEvent(ERequestType RequestType, DateTime CurrentTimestamp, int BucketCount, int MaxRequestQuota, int RestoreCount, int RestorePeriod);
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAPI
{
    public enum EFeedProcessingStatus
    {
        AwaitingAsynchronousReply,
        Cancelled,
        Done,
        InProgress,
        InSafetyNet,
        Submitted,
        Unconfirmed
    }
}

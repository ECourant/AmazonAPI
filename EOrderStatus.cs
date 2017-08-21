using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAPI
{
    public enum EOrderStatus
    {
        PendingAvailability,
        Pending,
        Unshipped,
        PartiallyShipped,
        Shipped,
        InvoiceUnconfirmed,
        Canceled,
        Unfulfillable
    }
}

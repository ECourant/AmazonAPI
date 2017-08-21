using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmazonAPI
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    internal class AmazonCallAttribute : Attribute
    {
        internal ERequestType RequestType { get; private set; }

        internal AmazonCallAttribute(ERequestType RequestType)
        {
            this.RequestType = RequestType;
        }
    }
}

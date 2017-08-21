using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonAPI.Reports.MarketplaceWebService;
using AmazonAPI.Reports.MarketplaceWebService.Model;
using System.IO;
namespace AmazonAPI.Pipelines
{
    public class ReportsPipeline : IPipeline<MarketplaceWebServiceConfig, MarketplaceWebServiceClient>
    {
        internal ReportsPipeline(Delegates.GetAmazonCredentialDelegate GetCredentialDelegate, Delegates.ThrottleRequestDelegate ThrottleDelegate) : base(GetCredentialDelegate, ThrottleDelegate)
        {

        }




        public ReportRequestInfo RequestReport(EReportType ReportType) => this.RequestReport(ReportType, default(DateTime), default(DateTime));
        [AmazonCall(ERequestType.RequestReport)]
        public ReportRequestInfo RequestReport(EReportType ReportType, DateTime StartDate, DateTime EndDate)
        {
            this.Throttle();
            AmazonCredential Credentials = this.GetCredential();
            MarketplaceWebServiceClient Client = this.GetClient(Credentials);

            RequestReportRequest Request = new RequestReportRequest()
            {
                Merchant = Credentials.MerchantID,
                ReportType = EnumStringHandler.GetEnumString<EReportType>(ReportType)
            };
            if (StartDate != default(DateTime))
                Request.StartDate = StartDate;
            if (EndDate != default(DateTime))
                Request.EndDate = EndDate;

            RequestReportResponse Response = Client.RequestReport(Request);
            if (Response.IsSetRequestReportResult())
            {
                RequestReportResult Result = Response.RequestReportResult;
                if (Result.IsSetReportRequestInfo())
                    return Result.ReportRequestInfo;
                else
                    return null;
            }
            else
                return null;
        }



        [AmazonCall(ERequestType.GetReport)]
        public Stream GetReport(string ReportId)
        {
            this.Throttle();
            AmazonCredential Credentials = this.GetCredential();
            MarketplaceWebServiceClient Client = this.GetClient(Credentials);
            MemoryStream ReportStream = new MemoryStream();
            GetReportRequest Request = new GetReportRequest()
            {
                Merchant = Credentials.MerchantID,
                ReportId = ReportId,
                Report = ReportStream
            };
            GetReportResponse Response = Client.GetReport(Request);
            if (Response.IsSetGetReportResult())
                return ReportStream;
            else
                return null;
        }


        public ReportRequestInfo[] GetReportRequestList() => this.GetReportRequestList(null, null, null, default(DateTime), default(DateTime));
        public ReportRequestInfo[] GetReportRequestList(string[] ReportRequestIdList) => this.GetReportRequestList(ReportRequestIdList, null, null, default(DateTime), default(DateTime));
        [AmazonCall(ERequestType.GetReportList)]
        private ReportRequestInfo[] GetReportRequestList(string[] ReportRequestIdList, EReportType[] ReportTypeList, EReportProcessingStatus[] ReportProcessingStatusList, DateTime RequestedFromDate, DateTime RequestedToDate)
        {
            return null;
        }
    }
}

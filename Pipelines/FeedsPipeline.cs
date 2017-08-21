using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmazonAPI.MWSClientRuntime;
using AmazonAPI.Feeds.MarketplaceWebService;
using AmazonAPI.Feeds.MarketplaceWebService.Model;
using System.IO;
namespace AmazonAPI.Pipelines
{
    public class FeedsPipeline : IPipeline<Feeds.MarketplaceWebService.MarketplaceWebServiceConfig, Feeds.MarketplaceWebService.MarketplaceWebServiceClient>
    {
        internal FeedsPipeline(Delegates.GetAmazonCredentialDelegate GetCredentialDelegate, Delegates.ThrottleRequestDelegate ThrottleDelegate) : base(GetCredentialDelegate, ThrottleDelegate)
        {

        }

        #region Cancel Feed Submissions
        public FeedSubmissionInfo[] CancelFeedSubmissions(string[] FeedSubmissionIds) => this.CancelFeedSubmissions(FeedSubmissionIds, null, default(DateTime), default(DateTime));
        public FeedSubmissionInfo[] CancelFeedSubmissions(EFeedType[] FeedTypeList) => this.CancelFeedSubmissions(null, FeedTypeList, default(DateTime), default(DateTime));
        public FeedSubmissionInfo[] CancelFeedSubmissions(DateTime SubmittedFromDate, DateTime SubmittedToDate) => this.CancelFeedSubmissions(null, null, SubmittedFromDate, SubmittedToDate);
        [AmazonCall(ERequestType.CancelFeedSubmissions)]
        private FeedSubmissionInfo[] CancelFeedSubmissions(string[] FeedSubmissionIds, EFeedType[] FeedTypeList, DateTime SubmittedFromDate, DateTime SubmittedToDate)
        {
            this.Throttle();
            AmazonCredential Credentials = this.GetCredential();
            MarketplaceWebServiceClient Client = this.GetClient(Credentials);
            CancelFeedSubmissionsRequest Request = default(CancelFeedSubmissionsRequest);

            if (FeedSubmissionIds != null)
                Request = new CancelFeedSubmissionsRequest()
                {
                    Merchant = Credentials.MerchantID,
                    FeedSubmissionIdList = new IdList()
                    {
                        Id = FeedSubmissionIds.ToList()
                    }
                };
            else if (FeedTypeList != null)
                Request = new CancelFeedSubmissionsRequest()
                {
                    Merchant = Credentials.MerchantID,
                    FeedTypeList = new TypeList()
                    {
                        Type = FeedTypeList.Select(Item => EnumStringHandler.GetEnumString<EFeedType>(Item)).ToList()
                    }
                };
            else if (SubmittedFromDate != default(DateTime) && SubmittedFromDate != default(DateTime))
                Request = new CancelFeedSubmissionsRequest()
                {
                    Merchant = Credentials.MerchantID,
                    SubmittedFromDate = SubmittedFromDate,
                    SubmittedToDate = SubmittedToDate
                };
            else
                throw new ArgumentException("Error, invalid arguments provided!");
            CancelFeedSubmissionsResponse Response = Client.CancelFeedSubmissions(Request);
            if (Response.IsSetCancelFeedSubmissionsResult())
            {
                CancelFeedSubmissionsResult Result = Response.CancelFeedSubmissionsResult;
                if (Result.IsSetCount())
                    if (Result.Count > 0)
                        Console.WriteLine($"Successfully canceled [{Result.Count}] feeds!");

                if (Result.IsSetFeedSubmissionInfo())
                    return Result.FeedSubmissionInfo.ToArray();
                else
                    return null;
            }
            else
                return null;
        }
        #endregion

        public FeedSubmissionInfo[] GetFeedSubmissionList() => this._GetFeedSubmissionList(null, null, null, default(DateTime), default(DateTime));
        public FeedSubmissionInfo[] GetFeedSubmissionList(string[] FeedSubmissionIdList) => this._GetFeedSubmissionList(FeedSubmissionIdList, null, null, default(DateTime), default(DateTime));
        public FeedSubmissionInfo[] GetFeedSubmissionList(EFeedType[] FeedTypeList) => this._GetFeedSubmissionList(null, FeedTypeList, null, default(DateTime), default(DateTime));
        public FeedSubmissionInfo[] GetFeedSubmissionList(EFeedProcessingStatus[] FeedProcessingStatusList) => this._GetFeedSubmissionList(null, null, FeedProcessingStatusList, default(DateTime), default(DateTime));
        public FeedSubmissionInfo[] GetFeedSubmissionList(DateTime SubmittedFromDate, DateTime SubmittedToDate) => this._GetFeedSubmissionList(null, null, null, SubmittedFromDate, SubmittedToDate);
        [AmazonCall(ERequestType.GetFeedSubmissionList)]
        private FeedSubmissionInfo[] _GetFeedSubmissionList(string[] FeedSubmissionIdList, EFeedType[] FeedTypeList, EFeedProcessingStatus[] FeedProcessingStatusList, DateTime SubmittedFromDate, DateTime SubmittedToDate)
        {
            string NextToken = string.Empty;
            AmazonCredential Credentials = this.GetCredential();
            MarketplaceWebServiceClient Client = this.GetClient(Credentials);
            GetFeedSubmissionListRequest Request = new GetFeedSubmissionListRequest()
            {
                Merchant = Credentials.MerchantID,
                MaxCount = 100
            };
            if (FeedSubmissionIdList != null)
                Request.FeedSubmissionIdList = new IdList()
                {
                    Id = FeedSubmissionIdList.ToList()
                };
            else if (FeedTypeList != null)
                Request.FeedTypeList = new TypeList()
                {
                    Type = FeedTypeList.Select(Item => EnumStringHandler.GetEnumString<EFeedType>(Item)).ToList()
                };
            else if (FeedProcessingStatusList != null)
                Request.FeedProcessingStatusList = new StatusList()
                {
                    Status = FeedProcessingStatusList.Select(Item => EnumStringHandler.GetEnumString<EFeedProcessingStatus>(Item)).ToList()
                };
            else if (SubmittedFromDate != default(DateTime) && SubmittedToDate != default(DateTime))
            {
                Request.SubmittedFromDate = SubmittedFromDate;
                Request.SubmittedToDate = SubmittedToDate;
            }

            List<FeedSubmissionInfo> Info = new List<FeedSubmissionInfo>();
            Task GetFeedSubmissionListTask = new Task(() => 
            {
                while (true)
                {
                    switch(NextToken == string.Empty)
                    {
                        case true:
                            this.Throttle(ERequestType.GetFeedSubmissionList);
                            GetFeedSubmissionListResponse Response = Client.GetFeedSubmissionList(Request);
                            if (Response.IsSetGetFeedSubmissionListResult())
                            {
                                GetFeedSubmissionListResult Result = Response.GetFeedSubmissionListResult;
                                if (Result.IsSetFeedSubmissionInfo())
                                    foreach (var FeedInfo in Result.FeedSubmissionInfo)
                                        Info.Add(FeedInfo);

                                if (Result.HasNext)
                                    NextToken = Result.NextToken;
                                else
                                    goto EndOfLoop;
                            }
                            break;
                        case false:
                            this.Throttle(ERequestType.GetFeedSubmissionListByNextToken);
                            GetFeedSubmissionListByNextTokenRequest RequestNextToken = new GetFeedSubmissionListByNextTokenRequest()
                            {
                                Merchant = Credentials.MerchantID,
                                NextToken = NextToken,
                            };
                            GetFeedSubmissionListByNextTokenResponse ResponseNextToken = Client.GetFeedSubmissionListByNextToken(RequestNextToken);
                            if (ResponseNextToken.IsSetGetFeedSubmissionListByNextTokenResult())
                            {
                                GetFeedSubmissionListByNextTokenResult ResultNextToken = ResponseNextToken.GetFeedSubmissionListByNextTokenResult;
                                if (ResultNextToken.IsSetFeedSubmissionInfo())
                                    foreach (var FeedInfo in ResultNextToken.FeedSubmissionInfo)
                                        Info.Add(FeedInfo);

                                if (ResultNextToken.HasNext)
                                    NextToken = ResultNextToken.NextToken;
                                else
                                    goto EndOfLoop;
                            }
                            break;
                    }
                }
                EndOfLoop:
                Console.Write("");
            });
            GetFeedSubmissionListTask.Start();
            GetFeedSubmissionListTask.Wait((int)Math.Ceiling(TimeSpan.FromMinutes(Definitions.Timeout_Minutes).Add(TimeSpan.FromHours(Definitions.Timeout_Hours)).TotalMilliseconds));
            return Info.ToArray();
        }

        #region Submit Feed
        public FeedSubmissionInfo SubmitFeed(EFeedType FeedType, string FeedContent) => this.SubmitFeed(FeedType, FeedContent, false);
        [AmazonCall(ERequestType.SubmitFeed)]
        public FeedSubmissionInfo SubmitFeed(EFeedType FeedType, string FeedContent, bool PurgeAndReplace)
        {
            switch (PurgeAndReplace)
            {
                case true:
                    this.Throttle(ERequestType.SubmitFeedPurgeAndReplace);
                    break;
                case false:
                    this.Throttle();
                    break;
            }

            AmazonCredential Credentials = this.GetCredential();
            MarketplaceWebServiceClient Client = this.GetClient(Credentials);
            SubmitFeedRequest Request = new SubmitFeedRequest()
            {
                Merchant = Credentials.MerchantID,
                FeedType = EnumStringHandler.GetEnumString<EFeedType>(FeedType),
                FeedContent = new MemoryStream(Encoding.ASCII.GetBytes(FeedContent)),
                PurgeAndReplace = PurgeAndReplace
            };
            SubmitFeedResponse Response = Client.SubmitFeed(Request);
            if (Response.IsSetSubmitFeedResult())
            {
                SubmitFeedResult Result = Response.SubmitFeedResult;
                if (Result.IsSetFeedSubmissionInfo())
                    return Result.FeedSubmissionInfo;
                else
                    return null;
            }
            else
                return null;
        }
        #endregion
    }
}

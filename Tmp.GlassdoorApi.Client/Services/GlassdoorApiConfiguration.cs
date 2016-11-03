using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using Tmp.GlassdoorApi.Client.Models;

namespace Tmp.GlassdoorApi.Client
{
    public class GlassdoorApiConfiguration
    {
        public string BasicUrl { get; private set; }
        public int PartnerID { get; private set; }
        public string APIKey { get; private set; }
        public string UserIP { get; private set; }
        public int Version { get; private set; }
        public string Format { get; private set; }
        public string UserAgent { get; private set; }

        public GlassdoorApiConfiguration(
            string baseUrl,
            int partnerId,
            string apiKey,
            int version = 1,
            string format = "json",            
            string userIp = "0.0.0.0",
            string userAgent = ""
            )
        {
            this.BasicUrl = baseUrl;
            this.PartnerID = partnerId;
            this.APIKey = apiKey;
            this.UserIP = userIp;
            this.Version = version;
            this.Format = format;
            this.UserAgent = userAgent;
        }

        public Task<CompanySearchResponse> GetCompaniesAsync(string keyword = "",
            string location = "",
            string city = "",
            string state = "",
            string country = "",
            string callBack = ""
            )
        {           
            var parameters = GetBasicQueryCollection();
            parameters.Add(GlassdoorQueryParameters.Action, GlassdoorQueryActions.Action_Company);
            parameters.Add(GlassdoorQueryParameters.CallBack, callBack);
            parameters.Add(GlassdoorQueryParameters.Keyword, keyword);
            parameters.Add(GlassdoorQueryParameters.Location, location);
            parameters.Add(GlassdoorQueryParameters.City, city);
            parameters.Add(GlassdoorQueryParameters.State, state);
            parameters.Add(GlassdoorQueryParameters.Country, country);

            return GetResponseAsync<CompanySearchResponse>(parameters);
        }


        public Task<CompanyReviewResponse> GetCompanyReviewAsync(int employerId,
			string jobTitle = "",            
            string employerName = "",
            string ticker = "",            
            string callBack = "",
			int? filterReviewRating = null,
            bool? includeReviewText = null
            )
        {
            var parameters = GetBasicQueryCollection();
            parameters.Add(GlassdoorQueryParameters.Action, GlassdoorQueryActions.Action_Company_Review);
            parameters.Add(GlassdoorQueryParameters.CallBack, callBack);
            parameters.Add(GlassdoorQueryParameters.EmployerName, employerName);
            parameters.Add(GlassdoorQueryParameters.EmployerID, employerId.ToString());
            parameters.Add(GlassdoorQueryParameters.Ticker, ticker);
            parameters.Add(GlassdoorQueryParameters.JobTitle, jobTitle);
            parameters.Add(GlassdoorQueryParameters.FilterReviewRating, filterReviewRating.HasValue ? filterReviewRating.ToString() : string.Empty);
            parameters.Add(GlassdoorQueryParameters.IncludeReviewText, includeReviewText.HasValue ? includeReviewText.ToString() : string.Empty);

            return GetResponseAsync<CompanyReviewResponse>(parameters);
        }


        public Task<CompanyInterviewResponse> GetCompanyInterviewsAsync(int employerId,
            string jobTitle = "",
            string employerName = "",
            string ticker = "",
            bool? includeReviewText = null,
            string callBack = ""
            )
        {
            var parameters = GetBasicQueryCollection();
            parameters.Add(GlassdoorQueryParameters.Action, GlassdoorQueryActions.Action_Company_Interview);
            parameters.Add(GlassdoorQueryParameters.CallBack, callBack);
            parameters.Add(GlassdoorQueryParameters.EmployerName, employerName);
            parameters.Add(GlassdoorQueryParameters.EmployerID, employerId.ToString());
            parameters.Add(GlassdoorQueryParameters.Ticker, ticker);
            parameters.Add(GlassdoorQueryParameters.JobTitle, jobTitle);
            parameters.Add(GlassdoorQueryParameters.IncludeReviewText, includeReviewText.HasValue ? includeReviewText.ToString() : string.Empty);

            return GetResponseAsync<CompanyInterviewResponse>(parameters);
        }

        #region Overview and Rating - Missing API parameter list from glassdoor offical doc
        public Task<CompanyOverviewResponse> GetCompanyOverviewsAsync(int employerId,
            string callBack = ""
            )
        {
            var parameters = GetBasicQueryCollection();
            parameters.Add(GlassdoorQueryParameters.Action, GlassdoorQueryActions.Action_Company_Overview);
            parameters.Add(GlassdoorQueryParameters.CallBack, callBack);
            parameters.Add(GlassdoorQueryParameters.EmployerID, employerId.ToString());

            return GetResponseAsync<CompanyOverviewResponse>(parameters);
        }

        public Task<CompanyRatingResponse> GetCompanyRatingsAsync(int employerId,
            string callBack = ""
            )
        {
            var parameters = GetBasicQueryCollection();
            parameters.Add(GlassdoorQueryParameters.Action, GlassdoorQueryActions.Action_Company_Rating);
            parameters.Add(GlassdoorQueryParameters.CallBack, callBack);
            parameters.Add(GlassdoorQueryParameters.EmployerID, employerId.ToString());

            return GetResponseAsync<CompanyRatingResponse>(parameters);
        }
        #endregion




        //public Task<> GetCompanySalariesAsync(int employerId,
        //	string jobTitle = "",
        //	string employerName = "",
        //	string ticker = "",
        //	string payType = "",
        //	string callBack = ""
        //          )
        //      {
        //          var parameters = GetBasicQueryCollection();
        //          parameters.Add(GlassdoorQueryParameters.Action, GlassdoorQueryActions.Action_Company_Salary);
        //          parameters.Add(GlassdoorQueryParameters.CallBack, callBack);
        //	parameters.Add(GlassdoorQueryParameters.EmployerName, employerName);
        //          parameters.Add(GlassdoorQueryParameters.EmployerID, employerId.ToString());
        //	parameters.Add(GlassdoorQueryParameters.Ticker, ticker);
        //	parameters.Add(GlassdoorQueryParameters.JobTitle, jobTitle);
        //	parameters.Add(GlassdoorQueryParameters.PayType, payType);

        //          return GetResponseAsync<>(parameters);
        //      }

        //public Task<> GetJobScopeSalariesAsync(int employerId,
        //	string locationType,
        //	int locationId,
        //	string jobTitle = "",
        //	string callBack = ""
        //          )
        //      {
        //          var parameters = GetBasicQueryCollection();
        //          parameters.Add(GlassdoorQueryParameters.Action, GlassdoorQueryActions.Action_JobScope_Salary);
        //          parameters.Add(GlassdoorQueryParameters.CallBack, callBack);
        //	parameters.Add(GlassdoorQueryParameters.EmployerID, employerId.ToString());
        //	parameters.Add(GlassdoorQueryParameters.LocationType, locationType);
        //	parameters.Add(GlassdoorQueryParameters.LocationID, locationId.ToString());
        //	parameters.Add(GlassdoorQueryParameters.JobTitle, jobTitle);

        //          return GetResponseAsync<>(parameters);
        //      }

        #region HELPER
        private Task<T> GetResponseAsync<T>(NameValueCollection parameters) where T : class
        {
            var url = this.BasicUrl.Parameters(parameters);

            var result = HttpRequester.GetAsync<T>(url);

            return result;
        }

        private NameValueCollection GetBasicQueryCollection()
        {
            var parameters = new NameValueCollection();
            parameters.Add(GlassdoorQueryParameters.PartnerID, this.PartnerID.ToString());
            parameters.Add(GlassdoorQueryParameters.Key, this.APIKey);
            parameters.Add(GlassdoorQueryParameters.UserIP, this.UserIP);
            parameters.Add(GlassdoorQueryParameters.UserAgent, this.UserAgent);
            parameters.Add(GlassdoorQueryParameters.Format, this.Format);
            parameters.Add(GlassdoorQueryParameters.Version, this.Version.ToString());
            return parameters;
        }
        #endregion
    }
}

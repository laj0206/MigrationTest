using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmp.GlassdoorApi.Client.Models;

namespace Tmp.GlassdoorApi.Client
{
    public interface ICompanyReviewApiClient
    {
        Task<CompanyReviewResponse> GetCompanyReview(int companyId,
            string jobTitle = "",
            string companyName = "",
            string ticker = "",
            int? filterReviewRating = null,
            bool? includeReviewText = null);
    }
}

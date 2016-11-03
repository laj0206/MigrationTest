using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client
{
    public static class GlassdoorQueryActions
    {
        public static string Action_Company = "employers";
        public static string Action_Company_Review = "employer-review";
        public static string Action_Company_SingleReview = "employer-single-review";
        public static string Action_Company_Interview= "employer-interview";
        public static string Action_Company_Overview = "employer-overview";
        public static string Action_Company_Rating = "employer-ratings";
		
		public static string Action_Salary = "salaries";
		public static string Action_Company_Salary = "employer-salaries";
		public static string Action_JobScope_Salary = "js-salary";
		
		public static string Action_Interview = "interviews";
		public static string Action_Interview_Questions = "interview-questions";
    }
}

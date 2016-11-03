using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client
{
    public static class GlassdoorCategories
    {
        public static Dictionary<int, string> Categories {
            get {
                var categories = new Dictionary<int, string>();
                categories.Add(1, "Accounting / Finance");
                categories.Add(2, "Administrative");
                categories.Add(3, "Analyst");
                categories.Add(4, "Architecture / Drafting");
                categories.Add(5, "Art / Design / Entertainment");
                categories.Add(6, "Banking / Loan / Insurance");
                categories.Add(7, "Beauty / Wellness");
                categories.Add(8, "Business / Development / Consulting");
                categories.Add(9, "Education");
                categories.Add(10, "Engineering (Non-software)");
				categories.Add(11, "Facilities / General Labor");
				categories.Add(12, "Hospitality");
				categories.Add(13, "Human Resources");
				categories.Add(14, "Installation / Maintenance / Repair");
				categories.Add(15, "Legal");
				categories.Add(16, "Manufacturing / Production / Construction");
				categories.Add(17, "Marketing / Advertising /PR");
				categories.Add(18, "Medical / Healthcare");
				categories.Add(19, "Non-profit / Volunteering");				
				categories.Add(20, "Product / Project Management");
				categories.Add(21, "Real Estate");
				categories.Add(22, "Restaurant / Food Service");
				categories.Add(23, "Retail");
				categories.Add(24, "Sales / Customer Care");
				categories.Add(25, "Science / Research");
				categories.Add(26, "Security / Law Enforcement");
				categories.Add(27, "Senior Management");
				categories.Add(28, "Skilled trade");
				categories.Add(29, "Software Development / IT");
				categories.Add(30, "Sports / Fitness");
				categories.Add(31, "Travel / Transportation");
				categories.Add(32, "Writing / Editing / Publishing");
				categories.Add(33, "Other");
                return categories;
            }
        }
    }

    public enum JobCategory
    {
        None = 0,
        AccountingFinance = 1,
        Administrative = 2,
        Analyst = 3,
        ArchitectureDrafting = 4,
        ArtDesignEntertainment = 5,
        BankingLoanInsurance = 6,
        BeautyWellness = 7,
        BusinessDevelopmentConsulting = 8,
        Education = 9,
        EngineeringNonSoftware = 10,
        FacilitiesGeneralLabor = 11,
        Hospitality = 12,
        HumanResources = 13,
        InstallationMaintenanceRepair = 14,
        Legal = 15,
        ManufacturingProductionConstruction = 16,
        MarketingAdvertisingPR = 17,
        MedicalHealthcare = 18,
        NonProfitVolunteering = 19,
        ProductProjectManagement = 20,
        RealEstate = 21,
        RestaurantFoodServices = 22,
        Retail = 23,
        SalesCustomerCare = 24,
        ScienceResearch = 25,
        SecurityLawEnforcement = 26,
        SeniorManagement = 27,
        SkilledTrade = 28,
        SoftwareDevelopmentIT = 29,
        SportsFitness = 30,
        TravelTransportation = 31,
        WritingEditingPublishing = 32,
        Other = 33,
    }
}

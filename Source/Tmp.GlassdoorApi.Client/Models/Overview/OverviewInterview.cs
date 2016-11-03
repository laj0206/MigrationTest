using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmp.GlassdoorApi.Client.Models
{
    public class OverviewInterview
    {
        [JsonProperty("overallDifficultyCount")]
        public int OverallDifficultyCount { get; private set; }

        [JsonProperty("overallDifficultySum")]
        public int OverallDifficultySum { get; private set; }

        [JsonProperty("averageOverallDifficulty")]
        public double AverageOverallDifficulty { get; private set; }

        [JsonProperty("overallExperienceCount")]
        public int OverallExperienceCount { get; private set; }

        [JsonProperty("overallPosExperienceCount")]
        public int OverallPosExperienceCount { get; private set; }

        [JsonProperty("overallPosExperiencePercent")]
        public double OverallPosExperiencePercent { get; private set; }

        [JsonProperty("overallNeutExperienceCount")]
        public int OverallNeutExperienceCount { get; private set; }

        [JsonProperty("overallNeutExperiencePercent")]
        public double OverallNeutExperiencePercent { get; private set; }

        [JsonProperty("overallNegexperienceCount")]
        public int OverallNegexperienceCount { get; private set; }

        [JsonProperty("overallNegExperiencePercent")]
        public double OverallNegExperiencePercent { get; private set; }

        [JsonProperty("attributionURL")]
        public string AttributionURL { get; private set; }

        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("reviewDateTime")]
        public DateTime ReviewDateTime { get; private set; }

        [JsonProperty("newReviewFlag")]
        public bool NewReviewFlag { get; private set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; private set; }

        [JsonProperty("outcome")]
        public string Outcome { get; private set; }

        [JsonProperty("location")]
        public string Location { get; private set; }

        [JsonProperty("interviewDate")]
        public DateTime InterviewDate { get; private set; }

        [JsonProperty("processDifficulty")]
        public string ProcessDifficulty { get; private set; }

        [JsonProperty("processInterviewOutcome")]
        public string ProcessInterviewOutcome { get; private set; }

        [JsonProperty("processOverallExperience")]
        public string ProcessOverallExperience { get; private set; }

        [JsonProperty("processAnswer")]
        public string ProcessAnswer { get; private set; }

        [JsonProperty("processLength")]
        public int ProcessLength { get; private set; }

        [JsonProperty("interviewSource")]
        public string InterviewSource { get; private set; }

        [JsonProperty("negotiationDetails")]
        public string NegotiationDetails { get; private set; }

        [JsonProperty("reasonForDeclining")]
        public string ReasonForDeclining { get; private set; }

        [JsonProperty("helpfulCount")]
        public int HelpfulCount { get; private set; }

        [JsonProperty("notHelpfulCount")]
        public int NotHelpfulCount { get; private set; }

        [JsonProperty("totalHelpfulCount")]
        public int TotalHelpfulCount { get; private set; }

        [JsonProperty("interviewSteps")]
        public string[] InterviewSteps { get; private set; }

        [JsonProperty("testSteps")]
        public string[] TestSteps { get; private set; }

        [JsonProperty("otherSteps")]
        public string[] OtherSteps { get; private set; }

        [JsonProperty("questions")]
        public InterviewQuestion[] InterviewQuestions { get; private set; }
    }
}

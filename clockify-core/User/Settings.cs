using Newtonsoft.Json;

namespace clockify_core
{
    public partial class Settings
    {
        [JsonProperty("weekStart")]
        public string WeekStart { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("timeFormat")]
        public string TimeFormat { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("sendNewsletter")]
        public bool SendNewsletter { get; set; }

        [JsonProperty("weeklyUpdates")]
        public bool WeeklyUpdates { get; set; }

        [JsonProperty("longRunning")]
        public bool LongRunning { get; set; }

        [JsonProperty("summaryReportSettings")]
        public SummaryReportSettings SummaryReportSettings { get; set; }

        [JsonProperty("isCompactViewOn")]
        public bool IsCompactViewOn { get; set; }

        [JsonProperty("dashboardSelection")]
        public string DashboardSelection { get; set; }

        [JsonProperty("dashboardViewType")]
        public string DashboardViewType { get; set; }

        [JsonProperty("dashboardPinToTop")]
        public bool DashboardPinToTop { get; set; }

        [JsonProperty("projectListCollapse")]
        public long? ProjectListCollapse { get; set; }

        [JsonProperty("collapseAllProjectLists")]
        public bool CollapseAllProjectLists { get; set; }

        [JsonProperty("groupSimilarEntriesDisabled")]
        public bool GroupSimilarEntriesDisabled { get; set; }

        [JsonProperty("myStartOfDay")]
        public string MyStartOfDay { get; set; }

        [JsonProperty("timeTrackingManual")]
        public bool TimeTrackingManual { get; set; }
    }
}
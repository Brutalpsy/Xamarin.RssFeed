using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedditRss.Helpers
{
    public static class AppCenterHelper
    {
        public static async Task TrackEvent(Dictionary<string, string> properties)
        {
            if (await Analytics.IsEnabledAsync())
            {
                Analytics.TrackEvent("feed post opened", properties);
            }
        }
        public static async Task TrackError(Exception ex, Dictionary<string, string> properties)
        {
            if (await Crashes.IsEnabledAsync())
            {
                Analytics.TrackEvent("feed post opened", properties);
            }
        }
    }
}

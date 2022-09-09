using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace SauceProject.Models
{
    public enum Browser
    {
        Chrome,
        Firefox,
        Chromium,
        WebKit
    }

    public enum RunTypeBrowser
    {
        Local,
        Wss
    }

    public class PlaywrightConfig
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Browser Browser { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public RunTypeBrowser RunTypeBrowser { get; set; }
        public Dictionary<string, string>? BrowserArgs { get; set; }
        public string? WssUrl { get; set; }
        public string? PlaywrightVersion { get; set; }
    }
}

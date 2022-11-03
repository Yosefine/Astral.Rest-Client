using Newtonsoft.Json;
using System;

namespace AstralRest
{
    public class Models
    {
        public class Welcome
        {
            [JsonProperty("results")]
            public Result[] Results { get; set; }

            [JsonProperty("alert")]
            public string Alert { get; set; }
        }

        public class Result
        {
            [JsonProperty("_index")]
            public string Index { get; set; }

            [JsonProperty("_type")]
            public string Type { get; set; }

            [JsonProperty("_id")]
            public string Id { get; set; }

            [JsonProperty("_score")]
            public double Score { get; set; }

            [JsonProperty("_source")]
            public Source Source { get; set; }

            [JsonProperty("_ignored", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Ignored { get; set; }
        }

        public class Source
        {
            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("data")]
            public string Data { get; set; }

            [JsonProperty("date_added")]
            public DateTimeOffset DateAdded { get; set; }
        }
    }
}

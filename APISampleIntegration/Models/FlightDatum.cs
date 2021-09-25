using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISampleIntegration.Models
{
    public class FlightDatum
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Datum
        {
            [JsonProperty("value")]
            public int Value { get; set; }

            [JsonProperty("trip_class")]
            public int TripClass { get; set; }

            [JsonProperty("show_to_affiliates")]
            public bool ShowToAffiliates { get; set; }

            [JsonProperty("origin")]
            public string Origin { get; set; }

            [JsonProperty("destination")]
            public string Destination { get; set; }

            [JsonProperty("gate")]
            public string Gate { get; set; }

            [JsonProperty("depart_date")]
            public string DepartDate { get; set; }

            [JsonProperty("return_date")]
            public string ReturnDate { get; set; }

            [JsonProperty("number_of_changes")]
            public int NumberOfChanges { get; set; }

            [JsonProperty("found_at")]
            public DateTime FoundAt { get; set; }

            [JsonProperty("duration")]
            public int Duration { get; set; }

            [JsonProperty("distance")]
            public int Distance { get; set; }

            [JsonProperty("actual")]
            public bool Actual { get; set; }
        }
    }
}

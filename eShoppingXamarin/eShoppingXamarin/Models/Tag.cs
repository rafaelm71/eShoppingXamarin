using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;


namespace eShopping.Models
{
    public class Tag
    {

        [JsonProperty("known")]
        public int Known { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("products")]
        public int Products { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sameAs")]
        public IList<string> SameAs { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShoppingXamarin.Services
{
    public class States
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("known")]
        public int Known { get; set; }

        [JsonProperty("products")]
        public int Products { get; set; }
    }

    public class StateInfo
    {

        [JsonProperty("tags")]
        public ObservableCollection<States> Tags { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}


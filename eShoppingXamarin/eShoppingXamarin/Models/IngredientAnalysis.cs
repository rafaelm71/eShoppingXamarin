
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.Json.Serialization;

namespace eShoppingXamarin.Models
{
    public class Name
    {

        public class IngredientTag
        {

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }

            [JsonPropertyName("products")]
            public int Products { get; set; }

            [JsonPropertyName("known")]
            public int Known { get; set; }

            [JsonPropertyName("id")]
            public string Id { get; set; }
        }

        public class IngredientAnalysis
        {

            [JsonPropertyName("count")]
            public int Count { get; set; }

            [JsonPropertyName("tags")]
            public ObservableCollection<IngredientTag> Tags { get; set; }
         

        }


    }
}
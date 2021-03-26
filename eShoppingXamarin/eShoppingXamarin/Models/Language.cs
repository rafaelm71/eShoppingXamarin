using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace eShopping.Models
{
    public class Language
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("tags")]
        public ObservableCollection<Tag> Tags { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class Data
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("gender")]
        public string gender { get; set; }

        [JsonProperty("age")]
        public int age { get; set; }

        [JsonProperty("hobbies")]
        public List<String> hobbies { get; set; }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_design.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Event
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string StartTime { get; set; }
        [JsonProperty]
        public string EndTime { get; set; }
        [JsonProperty]
        public string Description { get; set; }
        [JsonProperty]
        public string Category { get; set; }
        [JsonProperty]
        public int Prioritize { get; set; }
        [JsonProperty]
        public byte[] Picture { get; set; }
        [JsonProperty]
        public int VenueId { get; set; }
    }
}

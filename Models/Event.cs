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
        //public int Date { get; set; }
        //public int StartTime { get; set; }
        //public int EndTime { get; set; }
        //public string Location { get; set; }
        //public string City { get; set; }
        [JsonProperty]
        public string Description { get; set; }
        //public int Price { get; set; }
        //public string Category { get; set; }
        [JsonProperty]
        public string Priority { get; set; }
        [JsonProperty]
        public byte[] Picture { get; set; }
        [JsonProperty]
        public int VenueId { get; set; }
    }
}

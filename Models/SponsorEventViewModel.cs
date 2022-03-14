using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_design.Models
{
    public class SponsorEventViewModel
    {
        public List<Event> Events { get; set; } = new List<Event>();
        public List<Sponsor> Sponsors { get; set; } = new List<Sponsor>();

    }
}

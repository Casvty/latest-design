using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_design.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int LoginDetailsId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_design.Models
{
    public class LoginDetails
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int AccessLevel { get; set; }
        public int UserId { get; set; }
    }
}

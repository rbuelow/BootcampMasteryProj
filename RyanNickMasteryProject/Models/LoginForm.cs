using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RyanNickMasteryProject.Models
{
    public class LoginForm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public byte GradeLevel { get; set; }
    }
}
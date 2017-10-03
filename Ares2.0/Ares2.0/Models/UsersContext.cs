using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ares2.Models
{
    public class UsersContext
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserAge { get; set; }
        public bool isCertified { get; set; }
        public string MentorFirstName { get; set; }
        public string MentorLastName { get; set; }
        public string MentorExperience { get; set; }
        public int MentorExperienceYrs { get; set; }
    }
}

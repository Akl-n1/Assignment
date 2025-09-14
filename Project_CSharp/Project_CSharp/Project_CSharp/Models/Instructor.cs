using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class Instructor : User
    {
        public List<Guid> CreatedExams { get; set; } = new();
        public Instructor() { Role = UserRole.Instructor; }
        public Instructor(string username, string passwordHash, string fullName)
            : base(username, passwordHash, fullName, UserRole.Instructor) { }
    }

}

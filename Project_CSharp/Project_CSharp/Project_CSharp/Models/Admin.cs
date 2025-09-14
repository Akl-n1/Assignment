using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class Admin : User
    {
        public Admin()
        {
            Role = UserRole.Admin;
        }
        public Admin(string username, string passwordHash, string fullName)
            : base(username, passwordHash, fullName, UserRole.Admin) { }
    }
}

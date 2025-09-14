using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{


    public abstract class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public UserRole Role { get; protected set; }

        protected User() { }
        protected User(string username, string passwordHash, string fullName, UserRole role)
        {
            Username = username;
            PasswordHash = passwordHash;
            FullName = fullName;
            Role = role;
        }

        public override string ToString() => $"{FullName} ({Role})";
    }
}

using Project_CSharp.Models;
using Project_CSharp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Services
{
    public class AuthService
    {
        private readonly UserRepository _users;
        public AuthService(UserRepository users) { _users = users; }

        public User RegisterStudent(string username, string password, string fullName)
        {
            if (_users.GetByUsername(username) != null) throw new InvalidOperationException("Username exists");
            var hash = PasswordHasher.Hash(password);
            var student = new Student(username, hash, fullName);
            _users.Add(student); _users.SaveChanges();
            return student;
        }

        public User RegisterInstructor(string username, string password, string fullName)
        {
            if (_users.GetByUsername(username) != null) throw new InvalidOperationException("Username exists");
            var hash = PasswordHasher.Hash(password);
            var inst = new Instructor(username, hash, fullName);
            _users.Add(inst); _users.SaveChanges();
            return inst;
        }

        public User RegisterAdmin(string username, string password, string fullName)
        {
            if (_users.GetByUsername(username) != null) throw new InvalidOperationException("Username exists");
            var hash = PasswordHasher.Hash(password);
            var adm = new Admin(username, hash, fullName);
            _users.Add(adm); _users.SaveChanges();
            return adm;
        }

        public User? Login(string username, string password)
        {
            var user = _users.GetByUsername(username);
            if (user == null) return null;
            return PasswordHasher.Verify(password, user.PasswordHash) ? user : null;
        }
    }
}

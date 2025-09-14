using ExaminationSystem;
using Project_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Repositories
{
    public class UserRepository : IGenericRepository<User>
    {
        private readonly AppDbContext _db;
        public UserRepository(AppDbContext db) { _db = db; }

        public IEnumerable<User> GetAll() => _db.Users.ToList();
        public User? GetById(Guid id) => _db.Users.Find(id);
        public void Add(User entity) { _db.Users.Add(entity); }
        public void Remove(User entity) { _db.Users.Remove(entity); }
        public void SaveChanges() => _db.SaveChanges();

        public User? GetByUsername(string username) => _db.Users.SingleOrDefault(u => u.Username == username);
    }
}

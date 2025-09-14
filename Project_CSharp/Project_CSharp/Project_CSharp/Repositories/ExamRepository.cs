using ExaminationSystem;
using Microsoft.EntityFrameworkCore;
using Project_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Repositories
{
    public class ExamRepository : IGenericRepository<Exam>
    {
        private readonly AppDbContext _db;
        public ExamRepository(AppDbContext db) { _db = db; }

        public Exam? GetById(Guid id) => _db.Exams.Include(e => e.Questions).ThenInclude(q => q.Answers).SingleOrDefault(e => e.Id == id);
        public void Add(Exam entity) { _db.Exams.Add(entity); }
        public IEnumerable<Exam> GetAll() => _db.Exams.Include(e => e.Questions).ThenInclude(q => q.Answers).ToList();
        public void Remove(Exam entity) { _db.Exams.Remove(entity); }
        public void SaveChanges() => _db.SaveChanges();
    }
}

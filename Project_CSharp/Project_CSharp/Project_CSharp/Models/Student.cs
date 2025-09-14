using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class Student : User
    {
        public List<Guid> SubscribedExamIds { get; set; } = new();
        public Student() { Role = UserRole.Student; }
        public Student(string username, string passwordHash, string fullName)
            : base(username, passwordHash, fullName, UserRole.Student) { }

        public void OnExamStarted(object sender, ExamEventArgs e)
        {
            Console.WriteLine($"[Notify -> {FullName}] Exam started: {e.Exam.Title} (Subject: {e.Exam.Subject?.Name}) at {e.Time}");
        }
    }

}

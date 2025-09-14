using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public abstract class Question
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Header { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public double Marks { get; set; } = 1;
        public List<Answer> Answers { get; set; } = new();
        public Guid ExamId { get; set; }
        public Exam? Exam { get; set; }
        public abstract void Validate();
        public abstract Question Clone();
        public override string ToString() => $"[{GetType().Name}] {Header} ({Marks} pts)";
    }
}

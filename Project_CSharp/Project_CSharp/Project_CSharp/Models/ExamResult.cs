using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class ExamResult
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid StudentId { get; set; }
        public Student? Student { get; set; }
        public Guid ExamId { get; set; }
        public Exam? Exam { get; set; }
        public double Score { get; set; }
        public DateTime TakenAt { get; set; } = DateTime.UtcNow;
        public string StudentAnswersJson { get; set; } = string.Empty;
    }
}

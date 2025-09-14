using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class FinalExamResultApprovalService
    {
        private readonly Dictionary<Guid, List<ExamResult>> _examResults = new();

        // Student submits FinalExam result
        public void SubmitResult(Student student, Exam exam, double score)
        {
            var result = new ExamResult
            {
                StudentId = student.Id,
                Student = student,
                ExamId = exam.Id,
                Exam = exam,
                Score = score,
                TakenAt = DateTime.UtcNow
            };

            if (!_examResults.ContainsKey(exam.Id))
                _examResults[exam.Id] = new List<ExamResult>();
            _examResults[exam.Id].Add(result);

            Console.WriteLine($"[System] Final Exam '{exam.Title}' result submitted for instructor review.");
        }

        // Instructor approves
        public void ApproveResult(Instructor instructor, Exam exam)
        {
            if (!_examResults.ContainsKey(exam.Id)) return;

            foreach (var res in _examResults[exam.Id])
            {
                Console.WriteLine($"Instructor {instructor.FullName} approves result of {res.Student.FullName}: {res.Score}/{exam.Questions.Sum(q => q.Marks)}");
            }
        }

        // Get approved results for student
        public List<ExamResult> GetApprovedResults(Student student, Exam exam)
        {
            if (!_examResults.ContainsKey(exam.Id)) return new List<ExamResult>();
            return _examResults[exam.Id].Where(r => r.StudentId == student.Id).ToList();
        }
    }
}

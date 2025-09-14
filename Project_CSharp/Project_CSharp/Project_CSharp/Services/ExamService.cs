using Project_CSharp.Models;
using Project_CSharp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Services
{
    public class ExamService
    {
        private readonly ExamRepository _examRepo;
        private readonly FileLogger _logger;

        public ExamService(ExamRepository repo, FileLogger logger)
        {
            _examRepo = repo;
            _logger = logger;
        }

        public List<Exam> GetExams() => _examRepo.GetAll().ToList();

        public IEnumerable<Exam> GetExamById() => _examRepo.GetAll();

        public void AddExam(Exam exam) => _examRepo.Add(exam);

        public void LogQuestionToFile(Question q, string path)
        {
            var record = new
            {
                Timestamp = DateTime.UtcNow,
                QuestionId = q.Id,
                Type = q.GetType().Name,
                Header = q.Header,
                Body = q.Body,
                Marks = q.Marks,
                Answers = q.Answers
            };
            _logger.AppendJsonLine(path, record);
        }
    }


}

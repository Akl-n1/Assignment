using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class QuestionList : List<Question>
    {
        private readonly object _fileLock = new();
        public string LogFilePath { get; set; }

        public QuestionList(string logFilePath)
        {
            LogFilePath = logFilePath ?? throw new ArgumentNullException(nameof(logFilePath));
            if (!File.Exists(LogFilePath)) File.WriteAllText(LogFilePath, "");
        }

        public new void Add(Question q)
        {
            q.Validate();
            base.Add(q);
            LogQuestion(q);
        }

        private void LogQuestion(Question q)
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
            var json = JsonSerializer.Serialize(record);
            lock (_fileLock)
                File.AppendAllText(LogFilePath, json + Environment.NewLine);
        }
    }
}

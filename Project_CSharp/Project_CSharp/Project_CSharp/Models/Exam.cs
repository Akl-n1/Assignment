using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public enum ExamMode { Queued, Starting, Finished }

    public class ExamEventArgs : EventArgs
    {
        public Exam Exam { get; }
        public DateTime Time { get; }
        public ExamEventArgs(Exam exam)
        {
            Exam = exam;
            Time = DateTime.UtcNow;
        }
    }
    public abstract class Exam
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public Subject? Subject { get; set; }
        public TimeSpan TimeLimit { get; set; } = TimeSpan.FromMinutes(30);
        public List<Question> Questions { get; set; } = new();

        private ExamMode _mode = ExamMode.Queued;
        public ExamMode Mode
        {
            get => _mode;
            set
            {
                var prev = _mode;
                _mode = value;
                if (prev != value && value == ExamMode.Starting)
                    OnExamStarted();
            }
        }

        public event EventHandler<ExamEventArgs>? ExamStarted;

        protected virtual void OnExamStarted()
        {
            ExamStarted?.Invoke(this, new ExamEventArgs(this));
        }

        public abstract void ShowExam();

        public virtual double Evaluate(Dictionary<Guid, List<Guid>> studentResponses)
        {
            double total = 0;
            foreach (var q in Questions)
            {
                var correctIds = q.Answers.Where(a => a.IsCorrect).Select(a => a.Id).ToList();
                studentResponses.TryGetValue(q.Id, out var chosenIds);
                chosenIds ??= new List<Guid>();
                if (new HashSet<Guid>(correctIds).SetEquals(chosenIds))
                    total += q.Marks;
            }
            return total;
        }
    }
}

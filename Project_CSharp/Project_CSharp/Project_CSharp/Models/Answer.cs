using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class Answer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Text { get; set; } = string.Empty;
        public bool IsCorrect { get; set; } = false;
        public double MarksDelta { get; set; } = 0;
        public Guid QuestionId { get; set; }
        public Question? Question { get; set; }
        public override string ToString() => $"{Text} {(IsCorrect ? "(Correct)" : "")}";
    }
}

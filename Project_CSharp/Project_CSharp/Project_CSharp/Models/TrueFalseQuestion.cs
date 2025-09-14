using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class TrueFalseQuestion : Question
    {

        public TrueFalseQuestion() { }
        public TrueFalseQuestion(string header, string body, double marks)
        {
            Header = header; Body = body; Marks = marks;
            Answers = new List<Answer>
        {
            new Answer { Text = "True", IsCorrect = false },
            new Answer { Text = "False", IsCorrect = false }
        };
        }

        public TrueFalseQuestion(string questionText, double marks)
        {
            Header = questionText;
            Marks = marks;
        }

        public override void Validate()
        {
            if (Marks < 0) throw new InvalidOperationException("Marks must be >= 0");
            if (Answers.Count != 2) throw new InvalidOperationException("TrueFalse requires exactly two answers.");
            if (Answers.Count(a => a.IsCorrect) != 1) throw new InvalidOperationException("TrueFalse requires exactly one correct answer.");
        }

        public override Question Clone()
        {
            var cl = new TrueFalseQuestion(Header, Body, Marks);
            for (int i = 0; i < Answers.Count; i++)
            {
                cl.Answers[i].Id = Guid.NewGuid();
                cl.Answers[i].IsCorrect = Answers[i].IsCorrect;
                cl.Answers[i].Text = Answers[i].Text;
            }
            return cl;
        }
    }
}

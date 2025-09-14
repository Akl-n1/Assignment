using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class ChooseOneQuestion : Question
    {

        public ChooseOneQuestion() { }
        public ChooseOneQuestion(string header, string body, double marks)
        {
            Header = header; Body = body; Marks = marks;
        }

        public ChooseOneQuestion(string questionText, double marks)
        {
            Header = questionText;
            Marks = marks;
        }

        public override void Validate()
        {
            if (Marks < 0) throw new InvalidOperationException("Marks must be >= 0");
            if (Answers.Count < 2) throw new InvalidOperationException("ChooseOne requires at least two answers.");
            if (Answers.Count(a => a.IsCorrect) != 1) throw new InvalidOperationException("ChooseOne requires exactly one correct answer.");
        }

        public override Question Clone()
        {
            var cl = new ChooseOneQuestion(Header, Body, Marks);
            cl.Id = Guid.NewGuid();
            cl.Answers = Answers.ConvertAll(a => new Answer
            {
                Text = a.Text,
                IsCorrect = a.IsCorrect,
                MarksDelta = a.MarksDelta,
                Id = Guid.NewGuid()
            });
            return cl;
        }
    }

}

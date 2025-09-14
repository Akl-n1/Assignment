using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class AnswerList : List<Answer>
    {
        public AnswerList() : base() { }
        public AnswerList(IEnumerable<Answer> items) : base(items) { }

        public void ValidateForChooseOne()
        {
            if (Count < 2) throw new InvalidOperationException("ChooseOne requires at least two answers.");
            if (this.Count(a => a.IsCorrect) != 1) throw new InvalidOperationException("ChooseOne requires exactly one correct answer.");
        }

        public void ValidateForChooseAll()
        {
            if (Count < 2) throw new InvalidOperationException("ChooseAll requires at least two answers.");
            if (this.Count(a => a.IsCorrect) < 1) throw new InvalidOperationException("ChooseAll requires at least one correct answer.");
        }

        public void ValidateForTrueFalse()
        {
            if (Count != 2) throw new InvalidOperationException("TrueFalse requires exactly two answers (True, False).");
            if (this.Count(a => a.IsCorrect) != 1) throw new InvalidOperationException("TrueFalse requires exactly one correct answer.");
        }
    }
}

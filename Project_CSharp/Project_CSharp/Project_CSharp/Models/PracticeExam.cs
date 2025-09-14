using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CSharp.Models
{
    public class PracticeExam : Exam
    {
        public override void ShowExam()
        {
            Console.WriteLine($"=== Practice Exam: {Title} ({Subject?.Name}) ===");
            foreach (var q in Questions)
            {
                Console.WriteLine(q);
                Console.WriteLine(q.Body);
                int idx = 1;
                foreach (var a in q.Answers)
                    Console.WriteLine($"  {idx++}. {a.Text}");
                Console.WriteLine();
            }
        }
    }

}

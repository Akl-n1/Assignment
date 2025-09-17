using System.Xml.Linq;

namespace WebAppDay1.Models
{
    public class StudentBL
    {
        List<Student> Std = new List<Student>
        {
          new Student  { Id = 1, Name = "Mahmoud", ImgUrl = "1.jpg" },
          new Student  { Id = 2, Name = "Sara", ImgUrl = "2.jpg" },
          new Student  { Id = 3, Name = "Ali", ImgUrl = "3.jpg" },
          new Student  { Id = 4, Name = "Ahmed", ImgUrl = "4.jpg" }
        };

        public List<Student> GetAll()
        {
            return Std;
        }
        public Student GetbyId(int id)
        {
            return Std.FirstOrDefault(e => e.Id == id);
        }

    }
}

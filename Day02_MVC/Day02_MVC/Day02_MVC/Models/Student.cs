using System.ComponentModel.DataAnnotations.Schema;

namespace Day02_MVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department Department { get; set; }

        public ICollection<StudCrsRes> StudCrs { get; set; } = new List<StudCrsRes>();
    }
}
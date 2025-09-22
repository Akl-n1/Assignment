using System.ComponentModel.DataAnnotations.Schema;

namespace Day02_MVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department Department { get; set; }

        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();

        public ICollection<StudCrsRes> StudCrs { get; set; } = new List<StudCrsRes>();
    }
}
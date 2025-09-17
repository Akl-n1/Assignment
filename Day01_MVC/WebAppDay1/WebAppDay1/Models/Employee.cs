using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppDay1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JopTitle { get; set; }
        public int Salary { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

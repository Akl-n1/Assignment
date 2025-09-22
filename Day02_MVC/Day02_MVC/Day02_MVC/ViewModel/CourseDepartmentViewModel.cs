using Day02_MVC.Models;

namespace Day02_MVC.ViewModel
{
    public class CourseDepartmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }

        public int DeptId { get; set; }

        public ICollection<Department> departments { get; set; } = new List<Department>();
    }
}

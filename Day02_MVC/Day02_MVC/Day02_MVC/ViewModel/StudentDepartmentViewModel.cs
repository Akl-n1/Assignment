using Day02_MVC.Models;

namespace Day02_MVC.ViewModel
{
    public class StudentDepartmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int DeptId { get; set; }
        public ICollection<Department> Departments { get; set; } = new List<Department>();
        public List<int> SelectedCourseIds { get; set; } = new List<int>();
        public List<Course> Courses { get; set; }
    }
}

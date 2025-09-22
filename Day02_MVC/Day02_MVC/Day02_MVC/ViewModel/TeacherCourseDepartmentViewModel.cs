using Day02_MVC.Models;

namespace Day02_MVC.ViewModel
{
    public class TeacherCourseDepartmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }

        public int CourseId { get; set; }
        public int DeptId { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Department> Departments { get; set; } = new List<Department>();
    }
}

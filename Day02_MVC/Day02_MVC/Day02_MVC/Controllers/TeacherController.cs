using Day02_MVC.Data;
using Day02_MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day02_MVC.Controllers
{
    public class TeacherController : Controller
    {
        SystemContext Context = new SystemContext();
        public IActionResult Index()
        {
            var Teacher = Context.Teachers
                .Include(s => s.Department)
                .Include(s => s.Course).ToList();
            return View(Teacher);
        }
        public IActionResult Details(int id)
        {
            var teacher = Context.Teachers
                .Include(s => s.Department)
                .Include(s => s.Course)
                .FirstOrDefault(s => s.Id == id);
            return View(teacher);
        }
        public IActionResult Create()
        {
            var model = new TeacherCourseDepartmentViewModel
            {
                Courses = Context.Courses.ToList(),
                Departments = Context.Departments.ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(TeacherCourseDepartmentViewModel model)
        {
            var deptExists = Context.Departments.Any(d => d.Id == model.DeptId);
            var courseExists = Context.Courses.Any(c => c.Id == model.CourseId);
            if (deptExists && courseExists)
            {
                var teacher = new Models.Teacher
                {
                    Name = model.Name,
                    Salary = model.Salary,
                    Address = model.Address,
                    CourseId = model.CourseId,
                    DeptId = model.DeptId
                };

                Context.Teachers.Add(teacher);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            model.Departments = Context.Departments.ToList();
            model.Courses = Context.Courses.ToList();
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var teacher = Context.Teachers.FirstOrDefault(s => s.Id == id);
            if (teacher != null)
            {

                var model = new TeacherCourseDepartmentViewModel
                {
                    Id = teacher.Id,
                    Name = teacher.Name,
                    Salary = teacher.Salary,
                    Address = teacher.Address,
                    CourseId = teacher.CourseId,
                    DeptId = teacher.DeptId,
                    Courses = Context.Courses.ToList(),
                    Departments = Context.Departments.ToList()
                };
                return View(model);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(TeacherCourseDepartmentViewModel model)
        {
            var teacher = Context.Teachers.FirstOrDefault(s => s.Id == model.Id);
            if (teacher != null)
            {
                var deptExists = Context.Departments.Any(d => d.Id == model.DeptId);
                var courseExists = Context.Courses.Any(c => c.Id == model.CourseId);
                if (deptExists && courseExists)
                {
                    teacher.Name = model.Name;
                    teacher.Salary = model.Salary;
                    teacher.Address = model.Address;
                    teacher.CourseId = model.CourseId;
                    teacher.DeptId = model.DeptId;

                    Context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            model.Departments = Context.Departments.ToList();
            model.Courses = Context.Courses.ToList();
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            var teacher = Context.Teachers.FirstOrDefault(s => s.Id == id);
            if (teacher != null)
            {
                Context.Teachers.Remove(teacher);
                Context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}

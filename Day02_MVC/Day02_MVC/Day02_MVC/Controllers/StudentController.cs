using Day02_MVC.Data;
using Day02_MVC.Models;
using Day02_MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day02_MVC.Controllers
{
    public class StudentController : Controller
    {
        SystemContext Context = new SystemContext();
        public IActionResult Index()
        {
            var students = Context.Students
                .Include(s => s.Department)
                .Include(s => s.StudCrs)
                    .ThenInclude(sc => sc.Course)
                        .ToList();
            return View(students);
        }

        public IActionResult Details(int id)
        {
            var student = Context.Students
                .Include(s => s.Department)
                .Include(s => s.StudCrs)
                    .ThenInclude(sc => sc.Course)
                        .ThenInclude(c => c.Teachers)
                .FirstOrDefault(s => s.Id == id);

            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var student = Context.Students.Find(id);
            if (student != null)
            {
                Context.Students.Remove(student);
                Context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new StudentDepartmentViewModel
            {
                Departments = Context.Departments.ToList(),
                Courses = Context.Courses.ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(StudentDepartmentViewModel model)
        {
            if (model != null)
            {
                var student = new Student
                {
                    Name = model.Name,
                    Age = model.Age,
                    DeptId = model.DeptId,
                    StudCrs = new List<StudCrsRes>()
                };
                if (model.SelectedCourseIds != null)
                {
                    foreach (var courseId in model.SelectedCourseIds)
                    {
                        student.StudCrs.Add(new StudCrsRes
                        {
                            CourseId = courseId,
                            Student = student
                        });
                    }
                }
                Context.Students.Add(student);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            model.Departments = Context.Departments.ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = Context.Students
                .Include(s => s.StudCrs)
                .FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            var model = new StudentDepartmentViewModel
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                DeptId = student.DeptId,
                Departments = Context.Departments.ToList(),
                Courses = Context.Courses.ToList(),
                SelectedCourseIds = student.StudCrs.Select(sc => sc.CourseId).ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(StudentDepartmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var student = Context.Students
                    .Include(s => s.StudCrs)
                    .FirstOrDefault(s => s.Id == model.Id);

                if (student == null)
                    return NotFound();

                student.Name = model.Name;
                student.Age = model.Age;
                student.DeptId = model.DeptId;

                // تحديث الكورسات
                student.StudCrs.Clear();
                if (model.SelectedCourseIds != null && model.SelectedCourseIds.Any())
                {
                    foreach (var courseId in model.SelectedCourseIds)
                    {
                        student.StudCrs.Add(new StudCrsRes
                        {
                            StudentId = student.Id,
                            CourseId = courseId
                        });
                    }
                }

                Context.SaveChanges();
                return RedirectToAction("Index");
            }

            model.Departments = Context.Departments.ToList();
            model.Courses = Context.Courses.ToList();
            return View(model);
        }



    }
}

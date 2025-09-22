using Day02_MVC.Data;
using Day02_MVC.Models;
using Day02_MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day02_MVC.Controllers
{
    public class CourseController : Controller
    {
        SystemContext Context = new SystemContext();
        public IActionResult Index()
        {
            var Course = Context.Courses.Include(s => s.Department).ToList();
            return View(Course);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new CourseDepartmentViewModel
            {
                departments = Context.Departments.ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(CourseDepartmentViewModel course)
        {
            if (course != null)
            {
                var courseModel = new Course
                {
                    Name = course.Name,
                    Degree = course.Degree,
                    MinDegree = course.MinDegree,
                    DeptId = course.DeptId
                };

                Context.Courses.Add(courseModel);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var course = Context.Courses.Find(id);
            if (course == null)
            {
                return NotFound();
            }
            var model = new CourseDepartmentViewModel
            {
                Id = course.Id,
                Name = course.Name,
                Degree = course.Degree,
                MinDegree = course.MinDegree,
                DeptId = course.DeptId,
                departments = Context.Departments.ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(CourseDepartmentViewModel moedl)
        {
            if (moedl != null)
            {
                var existingCourse = Context.Courses.Find(moedl.Id);
                if (existingCourse == null)
                    return NotFound();
                existingCourse.Name = moedl.Name;
                existingCourse.Degree = moedl.Degree;
                existingCourse.MinDegree = moedl.MinDegree;
                existingCourse.DeptId = moedl.DeptId;
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            moedl.departments = Context.Departments.ToList();
            return View(moedl);

        }

        public IActionResult Delete(int id)
        {
            var course = Context.Courses.Find(id);
            if (course != null)
            {
                Context.Courses.Remove(course);
                Context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}

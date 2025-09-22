using Day02_MVC.Data;
using Day02_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day02_MVC.Controllers
{
    public class DepartmentController : Controller
    {
        SystemContext Context = new SystemContext();
        public IActionResult Index()
        {
            var Department = Context.Departments.ToList();
            return View(Department);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (department != null)
            {
                Context.Departments.Add(department);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var department = Context.Departments.FirstOrDefault(d => d.Id == id);
            return View(department);
        }
        [HttpPost]
        public IActionResult Edit(Department department)
        {
            if (department != null)
            {
                Context.Departments.Update(department);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit");
        }
        public IActionResult Delete(int id)
        {
            var department = Context.Departments.FirstOrDefault(d => d.Id == id);
            if (department != null)
            {
                Context.Departments.Remove(department);
                Context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}

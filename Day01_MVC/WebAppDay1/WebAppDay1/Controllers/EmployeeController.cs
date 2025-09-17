using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppDay1.Data;
using WebAppDay1.Models;
using WebAppDay1.ViewModel;

namespace WebAppDay1.Controllers
{
    public class EmployeeController : Controller
    {
        LearnContext Context = new LearnContext();
        public IActionResult Details(int id)
        {
            List<String> branch = new List<string>
            {
                new string("Cairo"),
                new string("Zagazig"),
                new string("Giza")
            };
            Employee Empmodel = Context.Employees.FirstOrDefault(e => e.Id == id);

            //======================= ViewData =============
            ViewData["Message"] = "Mahmoud Akl Message";
            ViewData["Temp"] = 50;
            ViewData["branch"] = branch;

            //======================= ViewBag =============
            ViewBag.Color = "red";

            return View("Details", Empmodel);
        }

        public IActionResult DetailsVM(int id)
        {
            List<String> branch = new List<string>
            {
                new string("Cairo"),
                new string("Zagazig"),
                new string("Giza")
            };
            Employee empmodel = Context.Employees
                .Include(e => e.Department)
                .FirstOrDefault(e => e.Id == id);
            EveryThingBelongEmployeeViewModel EmpVM = new EveryThingBelongEmployeeViewModel();
            EmpVM.EmpName = empmodel.Name;
            EmpVM.DeptName = empmodel.Department.Name;
            EmpVM.branchs = branch;
            EmpVM.temp = 10;
            EmpVM.Color = "red";
            return View("DetailsVM", EmpVM);
        }


    }
}

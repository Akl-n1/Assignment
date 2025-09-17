using Microsoft.AspNetCore.Mvc;
using WebAppDay1.Data;
using WebAppDay1.Models;

namespace WebAppDay1.Controllers
{
    public class DepartmentController : Controller
    {
        LearnContext Context = new LearnContext();
        public IActionResult Index()
        {
            List<Department> departmentList = Context.Departments.ToList();

            return View("index", departmentList);
        }
    }
}

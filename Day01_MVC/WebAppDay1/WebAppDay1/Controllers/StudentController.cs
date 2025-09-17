using Microsoft.AspNetCore.Mvc;
using WebAppDay1.Models;

namespace WebAppDay1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ShowAllStudent()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> studentsListModel = studentBL.GetAll();
            return View("ShowAllStudent", studentsListModel);
        }
        public IActionResult StudentDetails(int id)
        {
            StudentBL studentBL = new StudentBL();
            Student studentsModel = studentBL.GetbyId(id);
            return View("ShowStudentDetails", studentsModel);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PassifDataViewToController.Models;

namespace PassifDataViewToController.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EmployeeModel collection)
        {
            int id = collection.EmpId;
            string name = collection.EmpName;
            double salary = collection.EmpSalary;

            return View();
        }
    }
}

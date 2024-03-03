using Microsoft.AspNetCore.Mvc;
using W02.Models;

namespace W02.Controllers
{
    public class RegistrationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About(int id)
        {
            Student student;

            if (id ==1 )
            {
                student = new Student
                {
                    Id = id,
                    FirstName = "Alican",
                    LastName = "Cesur",
                    Department = "Math Eng."
                };

            }
            else if (id ==2)
            {
                student = new Student
                {
                    Id = id,
                    FirstName = "Murtaza",
                    LastName = "Kızıl",
                    Department = "Math Eng."
                };
            }
            else
            {
                student = new Student
                {
                    Id = -1,
                    FirstName = "No Data",
                    LastName = "No Data",
                    Department = "No Data"

                };
            }

            return View(student);
        }

        [HttpPost]
        public IActionResult Create()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Create(int id, string firstName , string LastName , string department)
        {

            return View();
        }
    }
}

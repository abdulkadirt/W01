using Microsoft.AspNetCore.Mvc;

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

            if (id ==1 )
            {
                 ViewBag.id = id;
                ViewBag.firstName = "Alican";
                ViewBag.lastName = "Cesur";
                ViewBag.department = "Math Eng.";
            }
            else if (id ==2)
            {
                ViewBag.id = id;
                ViewBag.firstName = "Murtaza";
                ViewBag.lastName = "Kızıl";
                ViewBag.department = "Math Eng.";
            }
            else
            {
                {
                    ViewBag.id = -1;
                    ViewBag.firstName = "No data found";
                    ViewBag.lastName = "No data found";
                    ViewBag.department = "No data found";

                }
            }

            return View();
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

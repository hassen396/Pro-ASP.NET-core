using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "Good Morning" : "Good Aftrnoon";
            return View("MyView", viewModel);
        }
        public string About()
        {
            return "tsega telkesekesech kadech";
        }
    }
}
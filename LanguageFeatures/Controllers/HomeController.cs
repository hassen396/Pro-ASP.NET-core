// using Microsoft.AspNetCore.Mvc;
// using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            decimal total = 0;
            object[] data = new object[] { "one", 2, 3.75, 4.87M };
            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case decimal d:
                        total += d;
                        break;
                    case int intVal:
                    total = total +intVal;
                    break;
                    case double f:
                    total = total + (decimal)f;
                    break;
                }
            }
            return View("Index", new string[] { $"Total: {total:C2}" });
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace JenkinsWebApplicationDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //cuonglv
            return View();
        }
    }
}

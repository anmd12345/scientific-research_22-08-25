using Microsoft.AspNetCore.Mvc;

namespace scientific_research_22_08_25.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}

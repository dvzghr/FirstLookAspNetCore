using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromScratch.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FromScratch.Controllers
{
    [Route("/[controller]"), Route("/")]
    public class HomeController : Controller
    {
        private IGreetingService _greetingService;

        public HomeController(IGreetingService greeter) => _greetingService = greeter;


        // GET: /<controller>/
        [Route("[action]"), Route("")]
        public IActionResult Index()
        {
            return View(_greetingService.GetTodaysGreeting());
        }
    }
}
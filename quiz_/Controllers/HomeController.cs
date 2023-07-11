using Microsoft.AspNetCore.Mvc;
using quiz_.Models;
using System.Diagnostics;

namespace quiz_.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    class HomeController : Controller
    {
 
        public IActionResult Index()
        {
            HttpContext.Response.Cookies.Append("exampleCookie1", "valueExampleCookie1");
            HttpContext.Session.SetString("exampleSession1", "valueExampleSession1");
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpDelete]
        public IActionResult ExampleMethod([FromForm] string name)
        {
            var cookie1 = HttpContext.Request.Cookies["exampleCookie1"];
            var session1 = HttpContext.Session.GetString("exampleSession1");
            return View();
        }
    }
}
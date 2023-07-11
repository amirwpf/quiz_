using Microsoft.AspNetCore.Mvc;
using quiz_.Models;
using System.Diagnostics;

namespace quiz_.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    class HomeController : Controller
    {
        [HttpDelete]
        public IActionResult ExampleAction(string actionName)
        {
            return null;
        }

        [ValidateAntiForgeryToken]
        [HttpDelete]
        public IActionResult AnotherAction(string actionName)
        {
            return null;
        }
    }
}
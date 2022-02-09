using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        
        //public string Index()
        public IActionResult Index()
        {
            //return "This is my default action..";
            return View(); 
        }

        //
        // GET: /HelloWorld/Welcome
        
        //public string Welcome(string name, int numTimes = 1)
        public IActionResult Welcome(string name, int numTimes=1)
        {
            //return "This is welcome action method...";

            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View(); // make sure return specifid view
        }
    }

}
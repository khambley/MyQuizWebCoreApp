using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyQuizWebCoreApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // Get: /HelloWorld
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome
        // https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
        // /HelloWorld/Welcome/3?name=Rick
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
        }
    }
}

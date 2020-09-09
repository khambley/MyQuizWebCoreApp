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
        public string Index()
        {
            return "This is my Index (default) action";
        }

        // GET: /HelloWorld/Welcome
        // https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}

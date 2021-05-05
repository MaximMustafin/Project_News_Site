using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Maganizer_Project.WEB.Controllers
{
    public class ErrorNotFoundController : Controller
    {
        [Route("missing")]
        public IActionResult Index() 
        {
            return View("ErrorNotFound");
        }
    }
}

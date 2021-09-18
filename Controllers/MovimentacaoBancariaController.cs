using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoCunha.Controllers
{
    public class MovimentacaoBancariaController : Controller
    {
        [HttpGet]
        public IActionResult MovimentacaoBancaria()
        {
            return View();

        }

    }
}

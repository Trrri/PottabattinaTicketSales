using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using PottabattinaTicketSales.Models;

namespace PottabattinaTicketSales.Controllers
{
    public class HomeController : Controller
    {
        /*
         * Created by Triveni Pottabattina
         * 6666666666666666666666666666666
         */

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}

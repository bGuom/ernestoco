using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Core_2_1.Controllers
{

    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
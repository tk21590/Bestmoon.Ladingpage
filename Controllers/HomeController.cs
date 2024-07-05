using BestVia.Models;
using BestViaCustomer.LandingPage.Models;
using BestViaCustomer.LandingPage.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace BestViaCustomer.LandingPage.Controllers
{
    public class HomeController : Controller
    {
        private INotifyServices _notifyServices { get; set; }

        public HomeController( INotifyServices notifyServices)
        {
            _notifyServices = notifyServices;
        }
        public IActionResult LandingPage()
        {
            return View();

        }
      
  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

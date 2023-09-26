using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.RegularExpressions;
using TIc_Tac_Toe.DAL;
using TIc_Tac_Toe.Models;

namespace TIc_Tac_Toe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private TicTacToeDAL context = new TicTacToeDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(IFormCollection formData)
        {
            string loginID = formData["txtLoginID"].ToString();
            string password = formData["txtPassword"].ToString();
            string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            if (context.Login(loginID, password))
            {
                HttpContext.Session.SetString("username", loginID);
                return RedirectToAction("Privacy", "Home");

            }
            else
            {
                TempData["Message"] = "Invalid Login Info";
                return RedirectToAction("Login");
            }
        }
    }
}
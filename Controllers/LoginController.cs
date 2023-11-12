using BibleVerseApp.Models;
using CLCMilestone.Services;
using Microsoft.AspNetCore.Mvc;

namespace BibleVerseApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Process login pages
        public IActionResult ProcessLogin(Login User)
        {
            SecurityService securityService = new SecurityService();
            if (securityService.isValid(User))
            {
                return View("LoginSuccess", User);
            }
            else
            {
                return View("LoginFailure", User);
            }
        }
    }
}

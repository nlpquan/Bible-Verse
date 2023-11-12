using BibleVerseApp.Models;
using CLCMilestone.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace BibleVerseApp.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Registration handler conneced to SecurityDAO
        public IActionResult RegistrationHandler(Register User)
        {
            SecurityDAO securityService = new SecurityDAO();
            return View(securityService.RegisterUser(User));
        }



    }
}

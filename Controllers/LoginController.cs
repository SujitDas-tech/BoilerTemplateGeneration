using Microsoft.AspNetCore.Mvc;
using BoilerTemplateGeneration.Models;
namespace BoilerTemplateGeneration.Controllers
{
    public class LoginController : Controller
    {
        private readonly boilerTemplateDBContext _context;
        public LoginController(boilerTemplateDBContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View("LoginIndex");
        }
        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            var details = _context.TblLogInDetails.SingleOrDefault(m => m.Password == model.password);
            string user = model.username.ToString();
            if (details != null && user.Equals(details.UserName.ToString()))
            {
                TempData["success"] = "Welcome to Boiler Template";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["error"] = "Check your credentials!";
                return RedirectToAction("Index", "Login");

            }
            
        }

    }
}

using System.Linq;
using Library.Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        
        public AdminController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        
        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
             
            return View(users);
        }
    }
}
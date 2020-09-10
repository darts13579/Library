using System.Linq;
using System.Threading.Tasks;
using Library.Data.Entity;
using Library.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<LibraryUser> _userManager;

        public AdminController(UserManager<LibraryUser> userManager)
        {
            _userManager = userManager;
        }
        
        public IActionResult Index()
        {
            var users = _userManager.Users.
                Select(_ => new LibraryUserModel(_, _userManager.GetRolesAsync(_).Result.FirstOrDefault())).ToList();
             
            return View(users);
        }
    }
}
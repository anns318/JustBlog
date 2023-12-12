using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.PaginateList;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;


        public UserController(UserManager<User> userManager)
        {
            this._userManager = userManager;
        }
        
        public async Task<IActionResult> Index(string sortBy, string filtering, int page = 1, int pageSize = 10)
        {
            var user = from u in _userManager.Users
                       select u;
            ViewBag.PageSize = pageSize;
            ViewBag.SortBy = sortBy;


            if (!string.IsNullOrWhiteSpace(filtering))
            {
                ViewData["filtering"] = filtering;
                user = user.Where(x => x.UserName.Contains(filtering));

            }

            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.ToLower() == "name")
                {
                    user = user.OrderByDescending(x => x.UserName);
                }
                else if (sortBy.ToLower() == "email")
                {
                    user = user.OrderByDescending(x => x.Email);

                }
            }


            return View(await PaginatedList<User>.CreateAsync(user, page, pageSize));
        }
    }
}

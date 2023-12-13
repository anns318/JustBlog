using FA.JustBlog.Core.Areas.Admin.Models;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.PaginateList;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Areas.Admin.Controllers
{


    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IPasswordHasher<User> passwordHasher;
        public UserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IPasswordHasher<User> passwordHasher)
        {
            this._userManager = userManager;
            _roleManager = roleManager;
            this.passwordHasher = passwordHasher;
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

        [Authorize("ForCreateSelectUpdate")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Roles = _roleManager.Roles.ToList();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            RegisterViewModel _user = new RegisterViewModel();
            _user.Id = id;
            _user.AboutMe = user.AboutMe;
            _user.Email = user.Email;
            _user.Age = user.Age;
            _user.Role = _userManager.GetRolesAsync(user).GetAwaiter().GetResult().FirstOrDefault();
            ViewBag.Roles = _roleManager.Roles.ToList();

            return View(_user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize("ForCreateSelectUpdate")]
        public async Task<IActionResult> Edit(string Id, [Bind("Id,Email,AboutMe,Age,Role,Password")] RegisterViewModel User)
        {
            if (ModelState.IsValid)
            {
                var _user = await _userManager.FindByIdAsync(Id);
                if (_user == null)
                {
                    return NotFound();
                }
                _user.AboutMe = User.AboutMe;
                _user.Age = User.Age;
                //_user.Email = User.Email;

                var result = await _userManager.UpdateAsync(_user);
                if (result.Succeeded)
                {
                    var _userRole = _userManager.GetRolesAsync(_user).GetAwaiter().GetResult();
                    var resultRole = await _userManager.RemoveFromRolesAsync(_user, _userRole);
                    if (resultRole.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(_user, User.Role);

                        return RedirectToAction(nameof(Index));
                    }
                }
                foreach (var error in result.Errors)
                {
                    if (error.Code == "DuplicateUserName")
                    {
                        continue;
                    }
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            ViewBag.Roles = _roleManager.Roles.ToList();

            return View(User);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize("ForCreateSelectUpdate")]
        public async Task<IActionResult> Create([Bind("Password,Email,AboutMe,Role")] RegisterViewModel _user)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = _user.Email,
                    Email = _user.Email,
                    AboutMe = _user.AboutMe,
                    EmailConfirmed = true
                };
                var result = await _userManager.CreateAsync(user, _user.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, _user.Role);
                    return RedirectToAction("Index");
                }
                foreach (var error in result.Errors)
                {
                    if (error.Code == "DuplicateUserName")
                    {
                        continue;
                    }
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            ViewBag.Roles = _roleManager.Roles.ToList();
            return View(_user);
        }

        [HttpGet]
        [Authorize("OnlyBlogOwner")]

        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewBag.Role = _userManager.GetRolesAsync(user).GetAwaiter().GetResult().FirstOrDefault();

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize("OnlyBlogOwner")]
        public async Task<IActionResult> DeleteConfirmed(string? id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return Problem("Not found");
            }

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));

            }
            return Problem("Some problem happen");

        }

    }
}

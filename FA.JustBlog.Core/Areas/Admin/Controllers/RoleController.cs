using FA.JustBlog.Core.Areas.Admin.Models;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.PaginateList;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FA.JustBlog.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index(string sortBy, string filtering, int page = 1, int pageSize = 10)
        {
            var role = from u in _roleManager.Roles
                       select u;
            ViewBag.PageSize = pageSize;
            ViewBag.SortBy = sortBy;


            if (!string.IsNullOrWhiteSpace(filtering))
            {
                ViewData["filtering"] = filtering;
                role = role.Where(x => x.Name.Contains(filtering));

            }

            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.ToLower() == "name")
                {
                    role = role.OrderByDescending(x => x.Name);
                }

            }


            return View(await PaginatedList<IdentityRole>.CreateAsync(role, page, pageSize));
        }

        [Authorize("ForCreateSelectUpdate")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize("ForCreateSelectUpdate")]
        public async Task<IActionResult> Create([Bind("Name")] IdentityRole Role)
        {
            if (string.IsNullOrEmpty(Role.Name))
            {
                ModelState.AddModelError("Name", "Name is required");
                return View(Role);

            }

            var result = await _roleManager.CreateAsync(Role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            foreach (var error in result.Errors)
            {

                ModelState.AddModelError("Name", "Role is duplicate");
            }

            return View("Create", Role);
        }



        [HttpGet]
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }


            return View(role);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize("ForCreateSelectUpdate")]
        public async Task<IActionResult> Edit(string Id, [Bind("Name,Id")] IdentityRole role)
        {
            if (Id != role.Id && Id == null)
            {
                return NotFound();
            }

            var _role = await _roleManager.FindByIdAsync(role.Id);
            if (_role == null)
            {
                return NotFound();
            }
            _role.Name = role.Name;
            var result = await _roleManager.UpdateAsync(_role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            foreach (var error in result.Errors)
            {
                if (error.Code == "DuplicateRoleName")
                    ModelState.AddModelError("Name", error.Description);
            }


            return View(role);
        }



        //[HttpGet]
        [Authorize("OnlyBlogOwner")]

        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize("OnlyBlogOwner")]
        public async Task<IActionResult> DeleteConfirmed(string? id)
        {
            var _role = await _roleManager.FindByIdAsync(id);

            if (_role == null)
            {
                return Problem("Not found");
            }

            var result = await _roleManager.DeleteAsync(_role);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));

            }
            return Problem("Some problem happen");

        }

    }
}

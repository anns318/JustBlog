using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.PaginateList;
using Microsoft.AspNetCore.Authorization;

namespace FA.JustBlog.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class TagController : Controller
    {
        private readonly BlogContext _context;

        public TagController(BlogContext context)
        {
            _context = context;
        }
        // GET: Admin/Tag
        
        public async Task<IActionResult> Index(string sortBy, string filtering, int page = 1, int pageSize = 10)
        {
            ViewBag.PageSize = pageSize;
            ViewBag.SortBy = sortBy;
            ViewData["filtering"] = filtering;

            var tag = from b in _context.Tags
                          select b;
            if (!string.IsNullOrWhiteSpace(filtering))
            {
                ViewData["filtering"] = filtering;
                tag = tag.Where(x => x.Name.Contains(filtering));

            }

            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.ToLower() == "name")
                {
                    tag = tag.OrderByDescending(x => x.Name);
                }
                else if (sortBy.ToLower() == "createdDate")
                {
                    tag = tag.OrderByDescending(x => x.CreatedDate);

                }
            }
            return View(await PaginatedList<Tag>.CreateAsync(tag, page, pageSize));
        }

        // GET: Admin/Tag/Details/5
        [Authorize("ForCreateSelectUpdate")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Tags == null)
            {
                return NotFound();
            }

            var tag = await _context.Tags
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tag == null)
            {
                return NotFound();
            }

            return View(tag);
        }

        // GET: Admin/Tag/Create
        [Authorize("ForCreateSelectUpdate")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Tag/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize("ForCreateSelectUpdate")]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,CreatedDate")] Tag tag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tag);
        }

        // GET: Admin/Tag/Edit/5
        [Authorize("ForCreateSelectUpdate")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Tags == null)
            {
                return NotFound();
            }

            var tag = await _context.Tags.FindAsync(id);
            if (tag == null)
            {
                return NotFound();
            }
            return View(tag);
        }

        // POST: Admin/Tag/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize("ForCreateSelectUpdate")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,CreatedDate")] Tag tag)
        {
            if (id != tag.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TagExists(tag.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tag);
        }

        // GET: Admin/Tag/Delete/5
        [Authorize("OnlyBlogOwner")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Tags == null)
            {
                return NotFound();
            }

            var tag = await _context.Tags
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tag == null)
            {
                return NotFound();
            }

            return View(tag);
        }

        // POST: Admin/Tag/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize("OnlyBlogOwner")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Tags == null)
            {
                return Problem("Entity set 'BlogContext.Tags'  is null.");
            }
            var tag = await _context.Tags.FindAsync(id);
            if (tag != null)
            {
                _context.Tags.Remove(tag);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TagExists(int id)
        {
          return (_context.Tags?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

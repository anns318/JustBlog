using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Service.UnitOfWork;
using FA.JustBlog.Core.PaginateList;

namespace FA.JustBlog.Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostController : Controller
    {
        private readonly BlogContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public PostController(BlogContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: Admin/Post
        public async Task<IActionResult> Index(string sortBy,string filtering,int page = 1,int pageSize = 10)
        {

            if(page < 1)
            {
                page = 1;
            }
            var blogContext = from p in _context.Posts
                              select p;
            if(blogContext == null)
            {

                return View(null);
            }
            if (!string.IsNullOrWhiteSpace(filtering))
            {
                if(filtering.ToLower() == "published")
                {
                    ViewData["filtering"] = filtering;
                    blogContext = blogContext.Where(x => x.IsPublished);
                }else if(filtering.ToLower() == "unpublished")
                {
                    ViewData["filtering"] = filtering;
                    blogContext = blogContext.Where(x => !x.IsPublished);

                }
            }
            if(!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.ToLower() == "viewed")
                {
                    ViewBag.SortBy = sortBy;
                    blogContext = blogContext.OrderByDescending(x => x.View);
                } else if (sortBy.ToLower() == "recent")
                {
                    ViewBag.SortBy = sortBy;
                    blogContext = blogContext.OrderByDescending(x => x.CreatedDate);
                } else if (sortBy.ToLower() == "interesting")
                {
                    ViewBag.SortBy = sortBy;
                    
                    blogContext = from p in _context.Posts.DefaultIfEmpty()
                                  join x in
                                      (from pr in _context.PostRate
                                       group pr by pr.PostId into g
                                       select new
                                       {
                                           PostId = g.Key,
                                           AVGRate = g.Average(pr => pr.Rate)
                                       })
                                  on p.Id equals x.PostId into postrate
                                  from pr in postrate.DefaultIfEmpty()
                                  orderby pr.AVGRate descending
                                  select p;

                }
                   
            }
            ViewBag.PageSize = pageSize;

            return View(await PaginatedList<Post>.CreateAsync(blogContext, page, pageSize));
        }

        // GET: Admin/Post/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Admin/Post/Create
        public IActionResult Create()
        {
            var listCate = _context.Categories.ToList();
            ViewBag.Categories = listCate;
            var listTag = _context.Tags.ToList();
            ViewBag.Tags = listTag;
            return View();
        }

        // POST: Admin/Post/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,View,CategoryId,CreatedDate,IsPublished")] Post post,List<int> PostTags)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.postRepository.Add(post);
                foreach(var tagid in PostTags)
                {
                    _context.PostTag.Add(new PostTag { PostId = post.Id, TagId = tagid });
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var listTag = _context.Tags.ToList();
            ViewBag.Tags = listTag;
            var listCate = _context.Categories.ToList();
            ViewBag.Categories = listCate;
            return View(post);
        }

        // GET: Admin/Post/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", post);
            return View(post);
        }

        // POST: Admin/Post/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,View,CategoryId,CreatedDate")] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", post.CategoryId);
            return View(post);
        }

        // GET: Admin/Post/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Admin/Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Posts == null)
            {
                return Problem("Entity set 'BlogContext.Posts'  is null.");
            }
            var post = await _context.Posts.FindAsync(id);
            if (post != null)
            {
                _context.Posts.Remove(post);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
          return (_context.Posts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

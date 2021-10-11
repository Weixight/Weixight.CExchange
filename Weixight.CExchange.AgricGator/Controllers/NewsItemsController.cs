using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Weixight.CExchange.AgricGator.Data;
using Weixight.CExchange.AgricGator.Models;
using Weixight.CExchange.AgricGator.Services;

namespace Weixight.CExchange.AgricGator.Controllers
{
    public class NewsItemsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly FilesService _filesService;

        public NewsItemsController(ApplicationDbContext context, FilesService filesService)
        {
            _context = context;
            _filesService = filesService;
        }

        // GET: NewsItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.NewsItems.ToListAsync());
        }

        // GET: NewsItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                // return NotFound();
                return View();
            }

            var newsItems = await _context.NewsItems
                .FirstOrDefaultAsync(m => m.id == id);
            if (newsItems == null)
            {
                return NotFound();
            }

            return View(newsItems);
        }

        // GET: NewsItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewsItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public async Task<IActionResult> Create([Bind("id,Tittle,Highlight,Details,activate,PostedDate,Picture")] NewsItems newsItems)
        {
            var files = HttpContext.Request.Form.Files;
            
                if (files != null)
                {
                    newsItems.Picture = _filesService.FileUpload(HttpContext.Request.Form.Files);
                }
                _context.Add(newsItems);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
           
            //return View(newsItems);
        }

        // GET: NewsItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsItems = await _context.NewsItems.FindAsync(id);
            if (newsItems == null)
            {
                return NotFound();
            }
            return View(newsItems);
        }

        // POST: NewsItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
      
        public async Task<IActionResult> Edit(int id, [Bind("id,Tittle,Highlight,Details,activate,PostedDate,Picture")] NewsItems newsItems)
        {
            if (id != newsItems.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newsItems);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsItemsExists(newsItems.id))
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
            return View(newsItems);
        }

        // GET: NewsItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsItems = await _context.NewsItems
                .FirstOrDefaultAsync(m => m.id == id);
            if (newsItems == null)
            {
                return NotFound();
            }

            return View(newsItems);
        }

        // POST: NewsItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var newsItems = await _context.NewsItems.FindAsync(id);
            _context.NewsItems.Remove(newsItems);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsItemsExists(int id)
        {
            return _context.NewsItems.Any(e => e.id == id);
        }
    }
}

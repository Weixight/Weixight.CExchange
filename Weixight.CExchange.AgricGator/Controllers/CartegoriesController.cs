using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Weixight.CExchange.AgricGator.Data;
using Weixight.CExchange.AgricGator.Models;
using Weixight.CExchange.AgricGator.Models.IRepository;
using Weixight.CExchange.AgricGator.Models.IRepository.IProduce;

namespace Weixight.CExchange.AgricGator.Controllers
{
    public class CartegoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepositoryWrapper _repositoryWrapper;

        public CartegoriesController(ApplicationDbContext context, IRepositoryWrapper repositoryWrapper)
        {
            _context = context;
            _repositoryWrapper = repositoryWrapper;
        }

        // GET: Cartegories
        public async Task<IActionResult> Index(int page = 1)
        {
            return View( _context.cartegories.GetPaged(page,10));
        }

        // GET: Cartegories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartegory = await _context.cartegories
                .FirstOrDefaultAsync(m => m.id == id);
            if (cartegory == null)
            {
                return NotFound();
            }

            return View(cartegory);
        }

        // GET: Cartegories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cartegories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
      
        public async Task<IActionResult> Create([Bind("id,Name,Dsc,MetaData,Created,Updated")] Cartegory cartegory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartegory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cartegory);
        }

        // GET: Cartegories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartegory = await _context.cartegories.FindAsync(id);
            if (cartegory == null)
            {
                return NotFound();
            }
            return View(cartegory);
        }

        // POST: Cartegories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,Dsc,MetaData,Created,Updated")] Cartegory cartegory)
        {
            if (id != cartegory.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartegory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartegoryExists(cartegory.id))
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
            return View(cartegory);
        }

        // GET: Cartegories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartegory = await _context.cartegories
                .FirstOrDefaultAsync(m => m.id == id);
            if (cartegory == null)
            {
                return NotFound();
            }

            return View(cartegory);
        }

        // POST: Cartegories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartegory = await _context.cartegories.FindAsync(id);
            _context.cartegories.Remove(cartegory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartegoryExists(int id)
        {
            return _context.cartegories.Any(e => e.id == id);
        }
    }
}

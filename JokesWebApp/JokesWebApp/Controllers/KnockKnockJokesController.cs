using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JokesWebApp.Data;
using JokesWebApp.Models;

namespace JokesWebApp.Controllers
{
    public class KnockKnockJokesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KnockKnockJokesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: KnockKnockJokes
        public async Task<IActionResult> Index()
        {
            return View(await _context.KnockKnockJoke.ToListAsync());
        }

        // GET: KnockKnockJokes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knockKnockJoke = await _context.KnockKnockJoke
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knockKnockJoke == null)
            {
                return NotFound();
            }

            return View(knockKnockJoke);
        }

        // GET: KnockKnockJokes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KnockKnockJokes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PunchLine,PunchLineQuestion,WhoIsThereAnswer,Name")] KnockKnockJoke knockKnockJoke)
        {
            if (ModelState.IsValid)
            {
                _context.Add(knockKnockJoke);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(knockKnockJoke);
        }

        // GET: KnockKnockJokes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knockKnockJoke = await _context.KnockKnockJoke.FindAsync(id);
            if (knockKnockJoke == null)
            {
                return NotFound();
            }
            return View(knockKnockJoke);
        }

        // POST: KnockKnockJokes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PunchLine,PunchLineQuestion,WhoIsThereAnswer,Name")] KnockKnockJoke knockKnockJoke)
        {
            if (id != knockKnockJoke.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(knockKnockJoke);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KnockKnockJokeExists(knockKnockJoke.Id))
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
            return View(knockKnockJoke);
        }

        // GET: KnockKnockJokes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var knockKnockJoke = await _context.KnockKnockJoke
                .FirstOrDefaultAsync(m => m.Id == id);
            if (knockKnockJoke == null)
            {
                return NotFound();
            }

            return View(knockKnockJoke);
        }

        // POST: KnockKnockJokes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var knockKnockJoke = await _context.KnockKnockJoke.FindAsync(id);
            _context.KnockKnockJoke.Remove(knockKnockJoke);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KnockKnockJokeExists(int id)
        {
            return _context.KnockKnockJoke.Any(e => e.Id == id);
        }
    }
}

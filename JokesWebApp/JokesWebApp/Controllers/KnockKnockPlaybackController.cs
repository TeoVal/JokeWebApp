using JokesWebApp.Data;
using JokesWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Controllers
{
    public class KnockKnockPlaybackController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KnockKnockPlaybackController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joke = await _context.Joke.FirstOrDefaultAsync(j => j.Id == id);

            if (joke == null)
            {
                return NotFound();
            }

            return View();

        }
    }
}

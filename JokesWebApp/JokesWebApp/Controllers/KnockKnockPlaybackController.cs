using JokesWebApp.Data;
using JokesWebApp.Dtos;
using JokesWebApp.Models;
using JokesWebApp.Services;
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
        private readonly IKnockJokeService knockJokeService;

        public KnockKnockPlaybackController(IKnockJokeService knockJokeService)
        {
            this.knockJokeService = knockJokeService;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            KnockKnockPlaybackDto dto = knockJokeService.GetJokeStep(id, 1);

            if (dto == null)
            {
                return NotFound();
            }

            return View(dto);

        }
    }
}

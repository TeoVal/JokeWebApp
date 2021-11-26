using JokesWebApp.Data;
using JokesWebApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Services.Implementation
{
    public class KnockJokeService : IKnockJokeService
    {
        private readonly ApplicationDbContext context;

        public KnockJokeService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public KnockKnockPlaybackDto GetJokeStep(int? jokeId, int? stepNumber)
        {
            KnockKnockPlaybackDto dto = new KnockKnockPlaybackDto();
            dto.TextToShow = "This is text from the service";


            return dto;
        }
    }
}

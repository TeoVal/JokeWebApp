using JokesWebApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Services
{
    public interface IKnockJokeService
    {
        KnockKnockPlaybackDto GetJokeStep(int? jokeId, int? stepNumber); 
    }
}

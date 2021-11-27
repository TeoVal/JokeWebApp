using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Dtos
{
    public class KnockKnockPlaybackDto
    {
        public int CurrentStep { get; set; }

        public string TextToShow { get; set; }

        public int JokeId { get; set; }

        public int? NextStep { get; set; }
    }
}

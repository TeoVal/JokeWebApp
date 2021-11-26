﻿using JokesWebApp.Data;
using JokesWebApp.Dtos;
using JokesWebApp.Models;
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

        public KnockKnockPlaybackDto GetJokeStep(int? jokeId, int? stepIndex)
        {
            KnockKnockJoke joke = FindById(jokeId);

            if (joke == null)
            {
                return null;
            }

            KnockKnockPlaybackDto dto = GetStepProperty(stepIndex, joke);
            return dto;
        }


        private KnockKnockPlaybackDto GetStepProperty(int? stepIndex, KnockKnockJoke joke)
        {
            KnockKnockPlaybackDto dto = new KnockKnockPlaybackDto();

            switch (stepIndex)
            {
                case 0:
                    dto.TextToShow = "Knock knock!";
                    break;
                case 1:
                    dto.TextToShow = "Who's there?";
                    break;
                case 2:
                    dto.TextToShow = joke.WhoIsThereAnswer;
                    break;
                case 3:
                    dto.TextToShow = joke.WhoIsThereAnswer + " who?";
                    break;
                case 4:
                    dto.TextToShow = joke.PunchLine;
                    break;
            }
            return dto;
        }


        private KnockKnockJoke FindById(int? id)
        {
            if(id == null)
            {
                return null;
            }

            var joke = context.KnockKnockJoke
                .FirstOrDefault(m => m.Id == m.Id);

            return joke;
        }


    }
}

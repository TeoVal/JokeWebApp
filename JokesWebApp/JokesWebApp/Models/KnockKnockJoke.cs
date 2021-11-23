using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class KnockKnockJoke
    {
        public int Id { get; set; }

        public string WhoIsThereAnswer { get; set; }

        public string PunchLine { get; set; }

        public KnockKnockJoke()
        {

        }
    }
}

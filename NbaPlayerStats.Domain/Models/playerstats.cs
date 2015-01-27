using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NbaPlayerStats.Domain.Models
{
    public class playerstats
    {
        public string name { get; set; }
        public int yearsPlayed { get; set; }
        public string teamsPlayedOn { get; set; }
        public int points { get; set; }
        public int rebounds { get; set; }
        public int assists { get; set; }
        public int blocks { get; set; }
        public int steals { get; set; }

    }
}
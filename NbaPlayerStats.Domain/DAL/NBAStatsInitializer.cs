using NbaPlayerStats.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NbaPlayerStats.Domain.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NBAStatsContext>
    {
        protected override void Seed(NBAStatsContext context)
        {
            var users = new List<users>
            {
            new users{firstName="matt",lastName="solesbee", username="msoles091", password="nba34",email="123@gmail.com",permission="administrative"},
            new users{firstName="greg",lastName="solesbee", username="ducksFan02", password="nfl99",email="456@gmail.com",permission="guest"},
            };

            users.ForEach(s => context.users.Add(s));
            context.SaveChanges();
            var playerstats = new List<playerstats>
            {
            new playerstats{name="Michal Jordon", yearsPlayed=13, teamsPlayedOn="Bulls and Wizards", points=50000, rebounds=10000, assists=8000, blocks=5000, steals=9000},
            new playerstats{name="Maigc", yearsPlayed=15, teamsPlayedOn="Lakers", points=250000, rebounds=10000, assists=8000, blocks=1000, steals=7000},
            new playerstats{name="Larry Bird", yearsPlayed=13, teamsPlayedOn="Celtics", points=150000, rebounds=15000, assists=8000, blocks=5000, steals=9000},
            };
            playerstats.ForEach(s => context.playerstats.Add(s));
            context.SaveChanges();
            var permission = new List<permission>
            {
            new permission{user="msoles091", LevelOfPermission="administrative"},
            };
            permission.ForEach(s => context.permission.Add(s));
            context.SaveChanges();
        }
    }
}
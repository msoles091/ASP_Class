using NbaPlayerStats.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace NbaPlayerStats.Domain.DAL
{
    public class NBAStatsContext : DbContext
    {
        public NBAStatsContext() 
            : base("NBAStatsContext")
        {
        }

        public DbSet<playerstats> playerstats { get; set; }
        public DbSet<users> users { get; set; }
        public DbSet<permission> permission { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
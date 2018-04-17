using BocceBall.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BocceBall.Context
{
    class DataContext : DbContext
    {
        public DataContext() : base("name=DefaultConnection") 
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Games> Games { get; set; }
    }
}

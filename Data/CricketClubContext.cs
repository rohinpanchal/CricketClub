using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CricketClub.Models;

namespace CricketClub.Data
{
    public class CricketClubContext : DbContext
    {
        public CricketClubContext (DbContextOptions<CricketClubContext> options)
            : base(options)
        {
        }

        public DbSet<CricketClub.Models.Member> Member { get; set; }

        public DbSet<CricketClub.Models.Payment> Payment { get; set; }

        public DbSet<CricketClub.Models.Plan> Plan { get; set; }
    }
}

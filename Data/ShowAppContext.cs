using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShowApp.Models;

namespace ShowApp.Data
{
    public class ShowAppContext : DbContext
    {
        public ShowAppContext (DbContextOptions<ShowAppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ShowApp.Models.Shows> Shows { get; set; }
    }
}

#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razerMovies1.Models;

namespace razerMovies1.Data
{
    public class razerMovies1Context : DbContext
    {
        public razerMovies1Context (DbContextOptions<razerMovies1Context> options)
            : base(options)
        {
        }

        public DbSet<razerMovies1.Models.Movie> Movie { get; set; }
    }
}

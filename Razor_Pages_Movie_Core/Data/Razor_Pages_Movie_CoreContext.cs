using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razor_Pages_Movie_Core.Modelos;

namespace Razor_Pages_Movie_Core.Data
{
    public class Razor_Pages_Movie_CoreContext : DbContext
    {
        public Razor_Pages_Movie_CoreContext (DbContextOptions<Razor_Pages_Movie_CoreContext> options)
            : base(options)
        {
        }

        public DbSet<Razor_Pages_Movie_Core.Modelos.Movie> Movie { get; set; }
    }
}

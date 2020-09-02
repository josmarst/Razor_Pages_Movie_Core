using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Pages_Movie_Core.Data;
using Razor_Pages_Movie_Core.Modelos;

namespace Razor_Pages_Movie_Core.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Razor_Pages_Movie_Core.Data.Razor_Pages_Movie_CoreContext _context;

        public IndexModel(Razor_Pages_Movie_Core.Data.Razor_Pages_Movie_CoreContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}

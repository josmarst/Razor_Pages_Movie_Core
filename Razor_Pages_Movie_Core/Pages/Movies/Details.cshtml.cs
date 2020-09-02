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
    public class DetailsModel : PageModel
    {
        private readonly Razor_Pages_Movie_Core.Data.Razor_Pages_Movie_CoreContext _context;

        public DetailsModel(Razor_Pages_Movie_Core.Data.Razor_Pages_Movie_CoreContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

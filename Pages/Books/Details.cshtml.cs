﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Petrean_Beatrice_Lab8.Data;
using Petrean_Beatrice_Lab8.Models;

namespace Petrean_Beatrice_Lab8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Petrean_Beatrice_Lab8.Data.Petrean_Beatrice_Lab8Context _context;

        public DetailsModel(Petrean_Beatrice_Lab8.Data.Petrean_Beatrice_Lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

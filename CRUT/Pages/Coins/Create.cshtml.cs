#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUT.Data;
using CRUT.Models;

namespace CRUT.Pages.Coins
{
    public class CreateModel : PageModel
    {
        private readonly CRUT.Data.CRUTContext _context;

        public CreateModel(CRUT.Data.CRUTContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Coin Coin { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Coin.Add(Coin);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

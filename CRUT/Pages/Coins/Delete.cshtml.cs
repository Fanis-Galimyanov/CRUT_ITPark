#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUT.Data;
using CRUT.Models;

namespace CRUT.Pages.Coins
{
    public class DeleteModel : PageModel
    {
        private readonly CRUT.Data.CRUTContext _context;

        public DeleteModel(CRUT.Data.CRUTContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Coin Coin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Coin = await _context.Coin.FirstOrDefaultAsync(m => m.Id == id);

            if (Coin == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Coin = await _context.Coin.FindAsync(id);

            if (Coin != null)
            {
                _context.Coin.Remove(Coin);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

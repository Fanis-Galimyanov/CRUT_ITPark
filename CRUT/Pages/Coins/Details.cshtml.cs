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
    public class DetailsModel : PageModel
    {
        private readonly CRUT.Data.CRUTContext _context;

        public DetailsModel(CRUT.Data.CRUTContext context)
        {
            _context = context;
        }

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
    }
}

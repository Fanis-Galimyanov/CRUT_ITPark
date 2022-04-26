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
    public class IndexModel : PageModel
    {
        private readonly CRUT.Data.CRUTContext _context;

        public IndexModel(CRUT.Data.CRUTContext context)
        {
            _context = context;
        }

        public IList<Coin> Coin { get;set; }

        public async Task OnGetAsync()
        {
            Coin = await _context.Coin.ToListAsync();
        }
    }
}

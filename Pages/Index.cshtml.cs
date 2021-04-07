using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PokemonTCGTrades.Models;
using Microsoft.AspNetCore.Identity;

namespace PokemonTCGTrades.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly StoreContext _context;

        private readonly UserManager<Member> _userManager;

        public IndexModel(ILogger<IndexModel> logger, StoreContext context, UserManager<Member> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IList<Listing> Listings { get; set; }
        public Member Member {get; set;}

        public async Task OnGetAsync()
        {
            if (User.Identity.IsAuthenticated) {
                Member = await _userManager.GetUserAsync(User);
            }
            // var products = from product in _context.Products select product;
            // Products = await products.ToListAsync();
        }
    }
}

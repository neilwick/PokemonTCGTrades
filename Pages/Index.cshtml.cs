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
using Model.Cards;
using System.Net.Http;
using System.Text.Json;

namespace PokemonTCGTrades.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly StoreContext _context;
        private HttpClient httpClient = new HttpClient();
        public Card card { get; set; }
        private readonly UserManager<Member> _userManager;

        public IndexModel(ILogger<IndexModel> logger, StoreContext context, UserManager<Member> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IList<Listing> Listings { get; set; }
        public IList<Listing> WantList { get; set; }
        public IList<Listing> OfferList { get; set; }
        public Member Member {get; set;}

        public async Task OnGetAsync()
        {
            if (User.Identity.IsAuthenticated) {
                Member = await _userManager.GetUserAsync(User);
                var loc = await _context.Members.Where(m => m.MemberName == Member.MemberName)
                    .Include(l => l.Listings).FirstOrDefaultAsync<Member>();
                OfferList = loc.Listings.Where(l => !l.IsWanted).ToList();
                foreach (Listing l in OfferList) {
                    HttpResponseMessage response = await httpClient.GetAsync("https://api.pokemontcg.io/v2/cards/" + l.CardID);

                    if (response.IsSuccessStatusCode) {

                        var dataStream = await response.Content.ReadAsStreamAsync();

                        card = await JsonSerializer.DeserializeAsync<Card>(
                                dataStream,
                                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                            );

                        // l.Name = card.Name;
                    }
                }

                WantList = loc.Listings.Where(l => l.IsWanted).ToList();

            }


        }


    }
}

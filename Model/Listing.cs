using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonTCGTrades.Models
{
    public class Listing
    {
        public uint ListingID { get; set; }
        public uint MemberID { get; set; }
        public string CardID { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public bool IsWanted { get; set; }
        public bool OnHold { get; set; }

    }
}
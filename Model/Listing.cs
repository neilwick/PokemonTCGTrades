using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonTCGTrades.Models
{
    public class Listing
    {
        public uint ListingID { get; set; }
        [Column(TypeName="varchar(255)")]
        public virtual Member Member { get; set; }
        [Column(TypeName="varchar(15)")]
        public string CardID { get; set; }
        [Column(TypeName="varchar(300)")]
        public string Description { get; set; }
        [MaxLength(10)]
        public string Condition { get; set; }
        public bool IsWanted { get; set; }
        public bool OnHold { get; set; }

    }
}
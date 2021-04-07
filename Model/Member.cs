using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace PokemonTCGTrades.Models
{

    public class Member : IdentityUser
    {

        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime Birthday { get; set; }
        [PersonalData]
        public string Description { get; set; }
        [PersonalData]
        public string PostalCode { get; set; }
        [PersonalData]
        [Column(TypeName = "decimal(8,2)"), DataType(DataType.Currency)]
        public decimal Balance { get; set; }
        [PersonalData]
        public uint DealsCompleted { get; set; }

    }

}
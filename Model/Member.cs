using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace PokemonTCGTrades.Models
{

    public class Member : IdentityUser
    {

        [PersonalData]
        [Column(TypeName="varchar(30)")]
        public string MemberName { get; set; }
        [PersonalData]
        public DateTime Birthday { get; set; }
        [PersonalData]
        [Column(TypeName="varchar(300)")]
        public string Description { get; set; }
        [PersonalData]
        public DateTime ModifiedDate { get; set; }
        [PersonalData]
        [Column(TypeName="varchar(10)")]
        public string PostalCode { get; set; }
        [PersonalData]
        [Column(TypeName = "decimal(8,2)"), DataType(DataType.Currency)]
        public decimal Balance { get; set; }
        [PersonalData]
        public DateTime JoinedDate { get; set; }
        [PersonalData]
        public uint DealsCompleted { get; set; }

        public virtual ICollection<Listing> Listings { get; set; }
        // public virtual ICollection<Transaction> Transactions { get; set; }

    }

}
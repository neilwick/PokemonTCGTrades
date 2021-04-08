using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonTCGTrades.Models
{
    public class Transaction
    {
        public uint TransactionID { get; set; }
        [Column(TypeName="varchar(255)")]
        public uint SenderID { get; set; }
        [Column(TypeName="varchar(255)")]
        public uint ReceiverID { get; set; }
        public uint ListingID { get; set; }
        [Column(TypeName="decimal(6, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName="DateTime")]
        public DateTime TimeStamp { get; set; }
        public bool InProgress { get; set; }
        public bool Completed { get; set; }
        public uint PaymentID { get; set; }

    }
}
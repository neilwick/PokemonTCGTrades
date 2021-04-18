using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonTCGTrades.Models
{
    public class Transaction
    {
        public uint TransactionID { get; set; }
        public virtual Member Sender { get; set; }
        public virtual Member Receiver { get; set; }
        public virtual Listing Listing { get; set; }
        [Column(TypeName="decimal(6, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName="DateTime")]
        public DateTime TimeStamp { get; set; }
        public bool InProgress { get; set; }
        public bool Completed { get; set; }
        public uint PaymentID { get; set; }

    }
}
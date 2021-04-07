using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonTCGTrades.Models
{
    public class Product
    {
        public uint ProductID { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(8,2)"), DataType(DataType.Currency)]
        public decimal Price { get; set; }


        public uint Stock { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }


    }
}
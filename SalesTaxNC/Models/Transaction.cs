using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesTaxNC.Models
{
    public class Transaction
    {
        public Transaction(string county, float cost)
        {
            this.county = county;
            this.cost = cost;
        }

        [Required]
        public string county { get; set; }
        [Required]
        public float cost { get; set; }
    }
}
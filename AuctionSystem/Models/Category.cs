using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionSystem.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Wprowadź nazwę kategorii")]
        [StringLength(100)]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Wprowadź opis kategorii")]
        public string CategoryDesc { get; set; }

        public virtual ICollection<Auction> Auctions { get; set; }
    }
}
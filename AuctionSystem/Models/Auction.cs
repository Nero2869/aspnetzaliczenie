using Microsoft.AspNet.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuctionSystem.Models
{
    public class Auction
    {
        public int AuctionID { get; set; }
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="Wprowadź nazwę aukcji")]
        [StringLength(100)]
        [DisplayName("Tytuł")]
        public string AuctionTitle { get; set; }
        public string AuctionDescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime AuctionDateAdd { get; set; }

        [DataType(DataType.Currency)]
        public decimal AuctionPrice { get; set; }
        public bool Hidden { get; set; }
        public string AuctionShortDesc { get; set; }
        public string UserId { get; set; }
        public virtual IUser User { get; set; }
        public virtual Category Category { get; set; }
        
    }
}
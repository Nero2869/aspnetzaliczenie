using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionSystem.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Wprowadź imię")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Wprowadź nazwisko")]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Wprowadź ulicę")]
        [StringLength(100)]
        public string Street { get; set; }

        [Required(ErrorMessage = "Wprowadź miasto")]
        [StringLength(100)]
        public string City { get; set; }

        [Required(ErrorMessage = "Wprowadź kod pocztowy")]
        [StringLength(6)]
        public string PostCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime OrderAddDate { get; set; }
        public OrderState OrderState { get; set; }
        public decimal OrderSumPrice { get; set; }

        List<OrderItem> OrderItems { get; set; }
    }

    public enum OrderState
    {
        Nowe,
        Zrealizowane
    }
}
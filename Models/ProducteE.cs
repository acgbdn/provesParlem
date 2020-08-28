using System;

namespace WebApplicaction.Models
{
    public class ProducteE
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string productTypeName { get; set; }
        public string NumeracioTerminal { get; set; }
        public DateTime SoldAt { get; set; }
        public int CustomerId { get; set; }
    }
}
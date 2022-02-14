using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cake_Store.Models
{
    public class Invoice_Detail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product_Detail Product { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public int Quantity { get; set; }
        public int Unit_Price { get; set; }
    }
}

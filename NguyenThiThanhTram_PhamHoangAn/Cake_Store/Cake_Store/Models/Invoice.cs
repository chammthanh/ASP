using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cake_Store.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        public int CustomerId { get; set; }
        public Account Customer { get; set; }
        public DateTime Date_Create { get; set; }
        public DateTime Date_Modified { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public List<Invoice_Detail> Invoice_Detail { get; set; }
    }
}

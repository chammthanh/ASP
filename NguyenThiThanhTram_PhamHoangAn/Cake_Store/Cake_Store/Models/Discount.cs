using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cake_Store.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string DiscountName { get; set; }
        public int Discounts { get; set; }
        public DateTime Effective_Date { get; set; }
        public DateTime Expiration_Date { get; set; }
        public int Status { get; set; }
        public List<Invoice> Invoice { get; set; }
    }
}

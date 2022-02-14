using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cake_Store.Models
{
    public class List_Address
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string NameCustomer { get; set; }
        public Account Customer { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Boolean Status { get; set; }
    }
}

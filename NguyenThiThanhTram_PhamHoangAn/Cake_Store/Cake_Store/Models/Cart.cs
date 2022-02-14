using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cake_Store.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public char Size { get; set; }

        public int price { get; set; }
        public int soluong { get; set; }
        public string name { get; set; }
    }
}

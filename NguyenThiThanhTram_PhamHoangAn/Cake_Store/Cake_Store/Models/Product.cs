using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Cake_Store.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Descriptions { get; set; }
        public int ProductTypeId { get; set; }
        public Product_Type ProductType { get; set; }
        public float Discount { get; set; }
        public List<Product_Detail> Product_Details { get; set; }
        public List<Review> Reviews { get; set; }
    }
}

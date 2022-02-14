using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Cake_Store.Models
{
    public class Product_Detail
    {
        public int Id { get; set; }
        public int SizeId { get; set; }
        public Product_Size Size { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime Date_Create { get; set; }
        public int Quantity { get; set; }
        public int Product_Price { get; set; }
        [DataType(DataType.Date)]

        public DateTime Make_Date { get; set; }
        [DataType(DataType.Date)]

        public DateTime Date_Expired { get; set; }
        public int ImagesId { get; set; }
        public Image Images { get; set; }
        public List<Invoice_Detail> Invoice_Detail { get; set; }
    }
}

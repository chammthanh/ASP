using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Cake_Store.Models
{
    public class Product_Type
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống loại sản phẩm")]
        [MaxLength(100, ErrorMessage = "Loại sản phẩm tối đa 100 kí tự")]
        public string Type { get; set; }
        public List<Product> Product { get; set; }
    }
}

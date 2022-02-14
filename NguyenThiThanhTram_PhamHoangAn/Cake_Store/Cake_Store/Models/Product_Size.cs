using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Cake_Store.Models
{
    public class Product_Size
    {
        public int Id { get; set; }
        [MaxLength(4, ErrorMessage = "Size bánh không vượt quá 4 kí tự")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public char Size { get; set; }
        public List<Product_Detail> Product_Detail { get; set; }
    }
}

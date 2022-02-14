using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cake_Store.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Images { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<Product_Detail> Product_Detail { get; set; }
        public List<Review> Review { get; set; }
    }
}

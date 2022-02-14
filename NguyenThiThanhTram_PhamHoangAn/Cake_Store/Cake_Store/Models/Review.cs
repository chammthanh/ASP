using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cake_Store.Models
{
    public class Review
    {
        public char Id { get; set; }
        public string Description { get; set; }
        public int ImagesId { get; set; }
        public Image Images { get; set; }
        public int Rate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public Account Customer { get; set; }

        public DateTime Date_Create { get; set; }

        public Boolean Delete_Flag { get; set; }
    }
}

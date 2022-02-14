using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cake_Store.Models;

namespace Cake_Store.Data
{
    public class Cake_StoreContext : DbContext
    {
        public Cake_StoreContext()
        {
        }

        public Cake_StoreContext (DbContextOptions<Cake_StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Cake_Store.Models.Account> Account { get; set; }

        public DbSet<Cake_Store.Models.Discount> Discount { get; set; }

        public DbSet<Cake_Store.Models.Image> Image { get; set; }

        public DbSet<Cake_Store.Models.Invoice> Invoice { get; set; }

        public DbSet<Cake_Store.Models.Invoice_Detail> Invoice_Detail { get; set; }

        public DbSet<Cake_Store.Models.List_Address> List_Address { get; set; }

        public DbSet<Cake_Store.Models.Product> Product { get; set; }

        public DbSet<Cake_Store.Models.Product_Detail> Product_Detail { get; set; }

        public DbSet<Cake_Store.Models.Product_Size> Product_Size { get; set; }

        public DbSet<Cake_Store.Models.Product_Type> Product_Type { get; set; }

        public DbSet<Cake_Store.Models.Review> Review { get; set; }

    }
}

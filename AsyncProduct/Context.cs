using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AsyncProduct
{
    public class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}

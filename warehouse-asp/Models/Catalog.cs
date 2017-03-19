using System.Collections.Generic;
using System.Data.Entity;

namespace warehouse_asp.Models
{
    public class Catalog
    {
        public int id { get; set; }
        public string name { get; set; }

        public ICollection<Product> Products { get; set; }
        public Catalog()
        {
            Products = new List<Product>();
        }
    }

    public class CatalogDBContext : DbContext
    {
        public DbSet<Catalog> Catalogs { get; set; }
    }
}
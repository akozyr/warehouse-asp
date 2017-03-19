using System.Data.Entity;

namespace warehouse_asp.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }

        // foreing key
        public int? catalogId { get; set; }
        // navigational property
        public Catalog Catalog { get; set; }
    }

    public class ProductDBContext : ApplicationDbContext
    {
        public DbSet<Product> Products { get; set; }

        public System.Data.Entity.DbSet<warehouse_asp.Models.Catalog> Catalogs { get; set; }
    }
}
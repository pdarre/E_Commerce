namespace E_Commerce.Models
{
    using System.Data.Entity;

    public class EcommerceContext : DbContext
    {
        public EcommerceContext() : base("DefaultConnection")
        {

        }

        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<E_Commerce.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<E_Commerce.Models.User> Users { get; set; }
    }
}
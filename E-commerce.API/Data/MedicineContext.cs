using Microsoft.EntityFrameworkCore;
using E_commerce.API.Models;

namespace E_commerce.API.Data
{
    public class MedicineContext : DbContext
    {
        public MedicineContext (DbContextOptions<MedicineContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
     {
         builder.Entity<OrderDetail>().HasKey(table => new {
         table.ID_Order, table.ID_thc
         });
     }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Classify> Classifies { get; set; }
        public DbSet<CusAccount> CusAccounts { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using AutoShops.Models;
using System.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace AutoShops {
    public class Context : DbContext {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Clients> Client { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductOrder> ProductOrder { get; set; }
        public DbSet<StateOrder> StateOrder { get; set; }
        public DbSet<Storage> Storage { get; set; }


        public Context () {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=DANDRIANOV\MSSQLDIPL;Database=DBDiplom2;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=True;").UseLazyLoadingProxies();
            optionsBuilder.ConfigureWarnings(w => w.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning));

        }
        
        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            if(modelBuilder == null)
                throw new ArgumentNullException("modelBuilder");
            //   modelBuilder.Entity<Order>().Property(o => o.ClientsId)
            //.HasColumnOrder(0).HasColumnName("ClientId");

            //   modelBuilder.Entity<Order>().Property(o => o.StateOrderId)
            //       .HasColumnOrder(1);
            
            foreach(var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.SetTableName(entityType.DisplayName());

                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}

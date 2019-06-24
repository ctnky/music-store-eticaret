using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace MusicStore.DAL.Concrete
{
    public class MusicStoreDbContext : DbContext
    {
        public MusicStoreDbContext()
            : base("Server = CTNKYWORKS ; Database = MusicStoreDb; Trusted_Connection=true")
        {
            Database.SetInitializer<MusicStoreDbContext>(new MyStrategy());
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderDetailMapping());
        }
    }
}

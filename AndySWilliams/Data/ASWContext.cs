using AndySWilliams.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AndySWilliams.Data
{
    public class ASWContext : DbContext
    {
        private readonly IConfiguration _config;

        public ASWContext(IConfiguration config)
        {
            _config = config;
        }
        public DbSet<Family> Families { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder bldr)
        {
            base.OnConfiguring(bldr);

            bldr.UseSqlServer(_config["ConnectionStrings:ASWCon"]);

            //bldr.UseSqlServer(_config.GetConnectionString("ASWContextDB"));
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Family>()
                .HasData(new Family()
                {
                    Id = 1,
                    Name = "Colton Williams",
                    ShortDescription = "My son the old soul.",
                    LongDescription = "My name is Colton and I am 4 years old!",
                    ImageUrl = "Colton"
                });

            //modelBuilder.Entity<Family>()
            //  .Property(p => p.Price)
            //  .HasColumnType("money");

            //modelBuilder.Entity<OrderItem>()
            //  .Property(o => o.UnitPrice)
            //  .HasColumnType("money");

            //modelBuilder.Entity<Order>()
            //  .HasData(new Order()
            //  {
            //      Id = 1,
            //      OrderDate = DateTime.UtcNow,
            //      OrderNumber = "12345"
            //  });
        }


    }
}

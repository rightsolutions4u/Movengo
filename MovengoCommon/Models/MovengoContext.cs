using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;


namespace MovengoCommon.Models
{
    public partial class MovengoContext : DbContext
    {
        public MovengoContext()
        {
        }

        public MovengoContext(DbContextOptions<MovengoContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                //entity.ToTable("Customer");

                entity.HasIndex(e => e.UserId, "IX_Customer_UserId");

                entity.HasIndex(e => e.EmailId, "IX_Customer_EmailId");

            });
            modelBuilder.Entity<Shipment>(entity =>
            {
                //entity.ToTable("Shipment");
                entity.HasIndex(e => e.UserId, "IX_Shipment_UserId");
                entity.HasIndex(e => e.ShipmentId, "IX_Shipment_ShipmentId");
                entity.HasIndex(e => e.WayBillNumber, "IX_Shipment_WayBillNumber");

                entity.HasOne(d => d.Customers)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.UserId);
                //.HasConstraintName("FK_Shipment_UserId");

            });
        }
    }
}

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
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Load> Load { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                //entity.ToTable("Customer");

                entity.HasIndex(e => e.Id, "IX_Customer_Id");

                entity.HasIndex(e => e.EmailId, "IX_Customer_EmailId");

            });
            modelBuilder.Entity<Shipment>(entity =>
            {
                //entity.ToTable("Shipment");
                entity.HasIndex(e => e.Id, "IX_Shipment_Id");
                entity.HasIndex(e => e.ShipmentId, "IX_Shipment_ShipmentId");
                entity.HasIndex(e => e.WayBillNumber, "IX_Shipment_WayBillNumber");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.Id);
                //.HasConstraintName("FK_Shipment_UserId");

            });
        }
    }
}

using InventoryAPI.Enum;
using InventoryAPI.Model;
using Microsoft.EntityFrameworkCore;
namespace InventoryAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


    public DbSet<User> Users { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
    public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<StockAdjustment> StockAdjustments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Unique constraint for Username
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            // PurchaseOrder -> PurchaseOrderDetails (Cascade is OK)
            modelBuilder.Entity<PurchaseOrder>()
                .HasMany(p => p.PurchaseOrderDetails)
                .WithOne(d => d.PurchaseOrder)
                .HasForeignKey(d => d.PurchaseID)
                .OnDelete(DeleteBehavior.Cascade);

            // Product -> PurchaseOrderDetails (Restrict to avoid multiple cascade paths)
            modelBuilder.Entity<Product>()
                .HasMany(p => p.PurchaseOrderDetails)
                .WithOne(d => d.Product)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.Restrict);

            // Product -> InvoiceDetails (Restrict)
            modelBuilder.Entity<Product>()
                .HasMany(p => p.InvoiceDetails)
                .WithOne(d => d.Product)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.Restrict);

            // Product -> InventoryTransactions (Restrict)
            modelBuilder.Entity<Product>()
                .HasMany(p => p.InventoryTransactions)
                .WithOne(it => it.Product)
                .HasForeignKey(it => it.ProductID)
                .OnDelete(DeleteBehavior.Restrict);

            // Product -> StockAdjustments (Restrict)
            modelBuilder.Entity<Product>()
                .HasMany(p => p.StockAdjustments)
                .WithOne(sa => sa.Product)
                .HasForeignKey(sa => sa.ProductID)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee -> Invoices (Cascade OK)
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Invoices)
                .WithOne(i => i.Employee)
                .HasForeignKey(i => i.EmployeeID)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee -> PurchaseOrders (Restrict to prevent multiple cascade)
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.PurchaseOrders)
                .WithOne(po => po.Employee)
                .HasForeignKey(po => po.EmployeeID)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee -> StockAdjustments (Restrict)
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.StockAdjustments)
                .WithOne(sa => sa.Employee)
                .HasForeignKey(sa => sa.EmployeeID)
                .OnDelete(DeleteBehavior.Restrict);

            // Supplier -> Products (Restrict)
            modelBuilder.Entity<Supplier>()
                .HasMany(s => s.Products)
                .WithOne(p => p.Supplier)
                .HasForeignKey(p => p.SupplierID)
                .OnDelete(DeleteBehavior.Restrict);

            // Supplier -> PurchaseOrders (Restrict)
            modelBuilder.Entity<Supplier>()
                .HasMany(s => s.PurchaseOrders)
                .WithOne(po => po.Supplier)
                .HasForeignKey(po => po.SupplierID)
                .OnDelete(DeleteBehavior.Restrict);

            // Invoice -> InvoiceDetails (Cascade OK)
            modelBuilder.Entity<Invoice>()
                .HasMany(i => i.InvoiceDetails)
                .WithOne(d => d.Invoice)
                .HasForeignKey(d => d.InvoiceID)
                .OnDelete(DeleteBehavior.Cascade);

            // Invoice -> Payments (Cascade OK)
            modelBuilder.Entity<Invoice>()
                .HasMany(i => i.Payments)
                .WithOne(p => p.Invoice)
                .HasForeignKey(p => p.InvoiceID)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}


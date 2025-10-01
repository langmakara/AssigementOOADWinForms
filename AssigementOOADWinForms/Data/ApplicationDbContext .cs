using AssigementOOADWinForms.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AssigementOOADWinForms.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<StockAdjustment> StockAdjustments { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                optionsBuilder.UseSqlServer(connString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Table mappings
            modelBuilder.Entity<User>().ToTable("tbUser");
            modelBuilder.Entity<Employee>().ToTable("tbEmployee");
            modelBuilder.Entity<Category>().ToTable("tbCategory");
            modelBuilder.Entity<Supplier>().ToTable("tbSupplier");
            modelBuilder.Entity<Customer>().ToTable("tbCustomer");
            modelBuilder.Entity<Product>().ToTable("tbProduct");
            modelBuilder.Entity<PurchaseOrder>().ToTable("tbPurchaseOrder");
            modelBuilder.Entity<PurchaseOrderDetail>().ToTable("tbPurchaseOrderDetail");
            modelBuilder.Entity<SalesOrder>().ToTable("tbSalesOrder");
            modelBuilder.Entity<SalesOrderDetail>().ToTable("tbSalesOrderDetail");
            modelBuilder.Entity<InventoryTransaction>().ToTable("tbInventoryTransaction");
            modelBuilder.Entity<Payment>().ToTable("tbPayment");
            modelBuilder.Entity<StockAdjustment>().ToTable("tbStockAdjustment");
            modelBuilder.Entity<AuditLog>().ToTable("tbAuditLog");

            // ✅ Define primary key for AuditLog
            modelBuilder.Entity<AuditLog>()
                .HasKey(al => al.LogID);

            // ✅ Make LogID auto-increment (IDENTITY)
            modelBuilder.Entity<AuditLog>()
                .Property(al => al.LogID)
                .ValueGeneratedOnAdd();

            // Relationships
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryID);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierID);

            modelBuilder.Entity<PurchaseOrder>()
                .HasOne(po => po.Supplier)
                .WithMany(s => s.PurchaseOrders)
                .HasForeignKey(po => po.SupplierID);

            modelBuilder.Entity<PurchaseOrder>()
                .HasOne(po => po.Employee)
                .WithMany(e => e.PurchaseOrders)
                .HasForeignKey(po => po.EmployeeID);

            modelBuilder.Entity<SalesOrder>()
                .HasOne(so => so.Customer)
                .WithMany(c => c.SalesOrders)
                .HasForeignKey(so => so.CustomerID);

            modelBuilder.Entity<SalesOrder>()
                .HasOne(so => so.Employee)
                .WithMany(e => e.SalesOrders)
                .HasForeignKey(so => so.EmployeeID);

            modelBuilder.Entity<AuditLog>()
                .HasOne(al => al.User)
                .WithMany(u => u.AuditLogs)
                .HasForeignKey(al => al.UserID);

            // Default value for ActionDate
            modelBuilder.Entity<AuditLog>()
                .Property(al => al.ActionDate)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}

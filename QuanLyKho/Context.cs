using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho.Model;

namespace QuanLyKho
{
    internal class Context: DbContext
    {
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ExportBill> ExportBills { get; set; }
        public DbSet<ExportBillDetail> ExportBillDetails { get; set; }
        public DbSet<ExportProductDetail> ExportProductDetails { get; set; }
        public DbSet<ImportBill> ImportBills { get; set; }
        public DbSet<ImportDetail> ImportDetail { get; set; }
        public DbSet<Stock> Stocks { get; set; }    
        public DbSet<StockDetail> StockDetails { get; set; }
        public DbSet<Unit> Units { get; set; }
        private Product or { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connectDB"].ConnectionString);
        }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Unit>().HasData(
                new Unit {UnitID= 1, Name= "Hộp"},
                new Unit {UnitID = 2, Name = "Cái"},
                new Unit {UnitID= 3, Name = "Thùng"},
                new Unit {UnitID = 4, Name = "Chiếc"},
                new Unit {UnitID = 5, Name = "Ram" },
                new Unit {UnitID = 6, Name = "Xấp" }                
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1,
                    Name = "Bút bi Thiên Long",
                    Description = "Bút bi Thiên Long 20Cây/hộp màu xanh"
                },
                new Product
                {
                    ProductID = 2,
                    Name = "Thước kẻ 20cm",
                    Description = "Thước kẻ 20cm hộp 30 cái"
                },
                new Product
                {
                    ProductID = 3,
                    Name = "Giấy in văn phòng",
                    Description = "Giấy in văn phòng 1 thùng 20 xấp"
                },
                new Product
                {
                    ProductID = 4,
                    Name = "Bút lông viết bảng (màu xanh)",
                    Description = "Bút lông viết bảng (màu xanh) hộp 10 cái"
                },
                new Product
                {
                    ProductID = 5,
                    Name = "Gôm/Bút tẩy xóa",
                    Description = "Gôm/Bút tẩy xóa"
                },
                new Product
                {
                    ProductID = 6,
                    Name = "Dao kéo, Băng keo",
                    Description = "Dao kéo, Băng keo"
                },
                new Product
                {
                    ProductID = 7,
                    Name = "Túi đựng hồ sơ và tài liệu",
                    Description = "Túi đựng hồ sơ và tài liệu"
                },
                new Product
                {
                    ProductID = 8,
                    Name = "Sổ tay học từ vựng",
                    Description = "Sổ tay học từ vựng"
                }
                );
            modelBuilder.Entity<Administrator>().HasData(
                new Administrator
                {
                    AdministratorID = 1,
                    Email = "Conggioi.pro264@gmail.com",
                    Title = "Quản lý",
                    Name = "Nguyễn Công Giới",
                    Password = "admin",
                    UserName = "admin",
                    Phone = "0367093723",
                    Role = 1
                }
                );
            modelBuilder.Entity<Stock>().HasData(
                new Stock
                {
                    StockID = 1,
                    Name = "Kho A",
                    Address = "639 Phạm Văn Bạch, Phường 15, Tân Bình, TPHCM"
                },
                new Stock
                {
                    StockID = 2,
                    Name = "Kho B",
                    Address = "200 Dương Đình Hội, Phường Phước Long B, Q.9, TPHCM"
                }
                );
        }
    }
}

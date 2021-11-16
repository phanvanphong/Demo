using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.Data
{
    public class EShopDbContext : IdentityDbContext<ApplicationUser>
    {

        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
        {
  
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            // Fluent API
            //modelBuilder.Entity<Product>(entity =>
            //{
            //    // Tạo bảng Product
            //    entity.ToTable("Product");
            //    // Thiết lập khóa chính cho bảng
            //    entity.HasKey(p => p.Id);
            //    // Tạo chỉ mục
            //    entity.HasIndex(p => p.Price)
            //    .HasDatabaseName("Index-Product-Price");
            //    // Tạo mối liên hệ Reletive
            //    entity.HasOne(p => p.Category)
            //    // Category không có thuộc tính chứa tập hợp các sản hẩm nên sẽ không truyền tham số
            //    .WithMany()
            //    // Đặt tên cho khóa ngoại
            //    .HasForeignKey("Categoty_Id")
            //    // Thiết lập thuộc tính khi xóa phần 1 thỳ phần nhiều sẽ bị xóa theo
            //    // Giả sử xóa danh mục Laptop thỳ các sản phẩm thuộc danh mục Laptop cũng bị xóa theo
            //    .OnDelete(DeleteBehavior.Cascade);
            //    // .OnDelete(DeleteBehavior.NoAction); xóa phần 1 thỳ phần nhiều không bị ảnh hưởng

            //    // Thiết lập thuộc tính
            //    entity.Property(p => p.Name)
            //    .HasColumnName("ProductName")
            //    .HasColumnType("nvarchar")
            //    .HasMaxLength(60)
            //    .IsRequired(true)
            //    ;
            //});
        }

        

    }
}

using Microsoft.EntityFrameworkCore;

namespace WebLinkKienOTO.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        // Thêm đoạn này để tự động tạo dữ liệu mẫu khi Update-Database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Tạo sẵn một vài danh mục linh kiện ô tô
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Linh kiện động cơ" },
                new Category { Id = 2, Name = "Phụ kiện nội thất" },
                new Category { Id = 3, Name = "Hệ thống chiếu sáng" }
            );
        }
    }
}
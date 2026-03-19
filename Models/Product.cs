using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace WebLinkKienOTO.Models
{
    public class Product
    {
        public Product()
        {
            // Khởi tạo HashSet để tránh lỗi NullReference khi làm việc với tập hợp ảnh
            Images = new HashSet<ProductImage>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm là bắt buộc")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        // GIẢI QUYẾT CẢNH BÁO: Định nghĩa chính xác kiểu dữ liệu trong SQL Server
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, 100000000.00, ErrorMessage = "Giá phải nằm trong khoảng hợp lệ")]
        public decimal Price { get; set; }

        public string? Description { get; set; }

        public int CategoryId { get; set; }

        public string? ImageUrl { get; set; }

        // Mối quan hệ 1-N với ảnh sản phẩm
        public virtual ICollection<ProductImage> Images { get; set; }

        // Điều hướng đến Category
        public Category? Category { get; set; }
    }
}
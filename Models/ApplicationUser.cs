using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebLinkKienOTO.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tuổi")]
        public int Age { get; set; } 
    }
}
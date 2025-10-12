using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models.DataModels
{
    public class KhachHang
    {
        [Key]
        public int Id { get; set; }

        public string? MaKhachHang { get; set; }

        [Required(ErrorMessage = "Họ tên là bắt buộc")]
        [StringLength(150)]
        public string HoTenKhachHang { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc")]
        [EmailAddress]
        [StringLength(150)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
        public string MatKhau { get; set; }

        [StringLength(20)]
        public string? DienThoai { get; set; }

        [StringLength(250)]
        public string? DiaChi { get; set; }

        public DateTime NgayDangKy { get; set; } = DateTime.Now;

        public bool TrangThai { get; set; } = true;

        // Navigation property: Một khách hàng có nhiều hóa đơn
        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    }
}

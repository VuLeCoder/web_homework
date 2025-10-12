using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models.DataModels
{
    public class HoaDon
    {
        [Key]
        public int Id { get; set; }

        public string? MaHoaDon { get; set; }

        public DateTime NgayHoaDon { get; set; } = DateTime.Now;
        public DateTime? NgayNhan { get; set; }

        [Required(ErrorMessage = "Tên người nhận là bắt buộc")]
        [StringLength(150)]
        public string HoTenKhachNhan { get; set; }

        [Required(ErrorMessage = "Email người nhận là bắt buộc")]
        [StringLength(150)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc")]
        [StringLength(20)]
        public string DienThoai { get; set; }

        [Required(ErrorMessage = "Địa chỉ là bắt buộc")]
        [StringLength(250)]
        public string DiaChi { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TongTriGia { get; set; }

        // Trạng thái đơn hàng: 0: Mới đặt, 1: Đã xác nhận, 2: Đang giao, 3: Đã giao, 4: Đã hủy
        public int TrangThai { get; set; }

        // Foreign Key đến KhachHang
        public int KhachHangId { get; set; }

        // Navigation properties
        [ForeignKey("KhachHangId")]
        public virtual KhachHang KhachHang { get; set; }

        public virtual ICollection<CtHoaDon> CtHoaDons { get; set; } = new List<CtHoaDon>();
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models.DataModels
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; }

        public string? MaSanPham { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm là bắt buộc")]
        [StringLength(250)]
        public string TenSanPham { get; set; }

        public string? HinhAnh { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "decimal(18, 2)")] // Định dạng kiểu tiền tệ
        public decimal DonGia { get; set; }

        public bool TrangThai { get; set; } = true;

        // Foreign Key đến LoaiSanPham
        public int LoaiSanPhamId { get; set; }

        // Navigation properties
        [ForeignKey("LoaiSanPhamId")]
        public virtual LoaiSanPham LoaiSanPham { get; set; }

        public virtual ICollection<CtHoaDon> CtHoaDons { get; set; } = new List<CtHoaDon>();
    }
}

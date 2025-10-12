using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models.DataModels
{
    public class LoaiSanPham
    {
        [Key]
        public int Id { get; set; }

        public string? MaLoai { get; set; }

        [Required(ErrorMessage = "Tên loại sản phẩm là bắt buộc")]
        [StringLength(150)]
        public string TenLoai { get; set; }

        public bool TrangThai { get; set; } = true; // Mặc định là true (đang hoạt động)

        // Navigation property: Một loại sản phẩm có nhiều sản phẩm
        public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
    }
}

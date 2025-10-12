using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models.DataModels
{
    public class CtHoaDon
    {
        [Key]
        public int Id { get; set; }

        public int SoLuongMua { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal DonGiaMua { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal ThanhTien { get; set; }

        // Foreign Keys
        public int HoaDonId { get; set; }
        public int SanPhamId { get; set; }

        // Navigation properties
        [ForeignKey("HoaDonId")]
        public virtual HoaDon HoaDon { get; set; }

        [ForeignKey("SanPhamId")]
        public virtual SanPham SanPham { get; set; }
    }
}

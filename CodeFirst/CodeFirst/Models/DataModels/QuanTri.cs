using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models.DataModels
{
    public class QuanTri
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TaiKhoan { get; set; }

        [Required]
        public string MatKhau { get; set; }

        public bool TrangThai { get; set; } = true;
    }
}

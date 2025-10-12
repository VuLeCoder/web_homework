using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class HoaDon
{
    public int Id { get; set; }

    public string? MaHoaDon { get; set; }

    public DateTime NgayHoaDon { get; set; }

    public DateTime? NgayNhan { get; set; }

    public string HoTenKhachNhan { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string DienThoai { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public decimal TongTriGia { get; set; }

    public int TrangThai { get; set; }

    public int KhachHangId { get; set; }

    public virtual ICollection<CtHoaDon> CtHoaDons { get; set; } = new List<CtHoaDon>();

    public virtual KhachHang KhachHang { get; set; } = null!;
}

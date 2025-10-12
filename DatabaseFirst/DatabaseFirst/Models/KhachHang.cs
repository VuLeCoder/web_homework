using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class KhachHang
{
    public int Id { get; set; }

    public string? MaKhachHang { get; set; }

    public string HoTenKhachHang { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string? DienThoai { get; set; }

    public string? DiaChi { get; set; }

    public DateTime NgayDangKy { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}

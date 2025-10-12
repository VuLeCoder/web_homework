using CodeFirst.Models.DataModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace CodeFirst.Models.DBModels
{
    public class ShoppingCartContext : DbContext
    {
        public ShoppingCartContext(DbContextOptions<ShoppingCartContext> options) : base(options) { }

        public DbSet<QuanTri> QuanTris { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<CtHoaDon> CtHoaDons { get; set; }
    }
}

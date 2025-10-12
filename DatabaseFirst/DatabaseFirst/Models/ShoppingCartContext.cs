using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Models;

public partial class ShoppingCartContext : DbContext
{
    public ShoppingCartContext()
    {
    }

    public ShoppingCartContext(DbContextOptions<ShoppingCartContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CtHoaDon> CtHoaDons { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<QuanTri> QuanTris { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ShoppingCart;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CtHoaDon>(entity =>
        {
            entity.HasIndex(e => e.HoaDonId, "IX_CtHoaDons_HoaDonId");

            entity.HasIndex(e => e.SanPhamId, "IX_CtHoaDons_SanPhamId");

            entity.Property(e => e.DonGiaMua).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ThanhTien).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.HoaDon).WithMany(p => p.CtHoaDons).HasForeignKey(d => d.HoaDonId);

            entity.HasOne(d => d.SanPham).WithMany(p => p.CtHoaDons).HasForeignKey(d => d.SanPhamId);
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasIndex(e => e.KhachHangId, "IX_HoaDons_KhachHangId");

            entity.Property(e => e.DiaChi).HasMaxLength(250);
            entity.Property(e => e.DienThoai).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.HoTenKhachNhan).HasMaxLength(150);
            entity.Property(e => e.TongTriGia).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.KhachHang).WithMany(p => p.HoaDons).HasForeignKey(d => d.KhachHangId);
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.Property(e => e.DiaChi).HasMaxLength(250);
            entity.Property(e => e.DienThoai).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.HoTenKhachHang).HasMaxLength(150);
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.Property(e => e.TenLoai).HasMaxLength(150);
        });

        modelBuilder.Entity<QuanTri>(entity =>
        {
            entity.Property(e => e.TaiKhoan).HasMaxLength(100);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasIndex(e => e.LoaiSanPhamId, "IX_SanPhams_LoaiSanPhamId");

            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TenSanPham).HasMaxLength(250);

            entity.HasOne(d => d.LoaiSanPham).WithMany(p => p.SanPhams).HasForeignKey(d => d.LoaiSanPhamId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

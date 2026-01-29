using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LTQL_CuaHangSon.Models
{
    public class SanPham
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MaSP { get; set; } = null!;

        [Required]
        [StringLength(200)]
        public string TenSanPham { get; set; } = null!;

        public int NCCID { get; set; }

        public int LoaiSanPhamID { get; set; }

        [StringLength(50)]
        public string? TenMau { get; set; }

        [StringLength(20)]
        public string? MaMau { get; set; } 


        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal GiaNhap { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal GiaBan { get; set; }

       

        [Column(TypeName = "nvarchar(max)")]
        public string? MoTa { get; set; }


        public int? NguoiTao { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime NgayTao { get; set; }

        
        public DateTime? NgayCapNhat { get; set; }

        
        public virtual TaiKhoan? NguoiTaoSanPham { get; set; }

        public virtual TonKho? ThongTinTonKho { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; } = null!;
        public virtual NhaCungCap NhaCungCap { get; set; } = null!;

        public virtual ObservableCollectionListSource<ChiTiet_PhieuNhap> DanhSachChiTietNhap { get; } = new();
        public virtual ObservableCollectionListSource<ChiTiet_HoaDon> DanhSachChiTietHoaDon { get; } = new();
    }
}

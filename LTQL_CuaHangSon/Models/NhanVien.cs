using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LTQL_CuaHangSon.Models
{
    
    public class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNV { get; set; } = null!;

        [Required]
        [StringLength(200)]
        public string HoTen { get; set; } = null!;


        [Required]
        [StringLength(11)]
        public string DienThoai { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; } = null!;


        public DateTime? NgaySinh { get; set; } 


        public virtual TaiKhoan TaiKhoan { get; set; } = default!;
        public virtual ObservableCollectionListSource<HoaDon> DanhSachHoaDon { get; } = new();
        public virtual ObservableCollectionListSource<PhieuNhap> DanhSachPhieuNhap { get; } = new();
    }
}

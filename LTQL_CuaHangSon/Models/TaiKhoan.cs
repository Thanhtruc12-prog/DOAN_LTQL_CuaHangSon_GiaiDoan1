using LTQL_CuaHangSon.Enums;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LTQL_CuaHangSon.Models
{
    
    public class TaiKhoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; } = null!;

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; } = null!;

        public int NhanVienID { get; set; }

        public int VaiTroID { get; set; }

        public TrangThaiTK TrangThaiTaiKhoan { get; set; } = TrangThaiTK.HoatDong;

        public DateTime NgayTao { get; set; } 

        public virtual NhanVien? NhanVien { get; set; }

        public virtual VaiTro? VaiTro { get; set; }

        public virtual ObservableCollectionListSource<HoaDon> DanhSachHoaDon { get;  } = new();
        public virtual ObservableCollectionListSource<LogTable> DanhSachLog { get;  } = new();

    }
}

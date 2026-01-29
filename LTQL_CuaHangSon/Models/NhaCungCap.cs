using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LTQL_CuaHangSon.Models
{
    public class NhaCungCap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNCC { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string TenNCC { get; set; } = null!;

        [Required]
        [StringLength(15)]
        [Phone]

        public string SoDienThoai { get; set; } = null!;

        [Column(TypeName = "nvarchar(max)")]
        public string DiaChi { get; set; } = null!;
        public virtual ObservableCollectionListSource<SanPham> DanhSachSanPham { get; } = new();
        public virtual ObservableCollectionListSource<PhieuNhap> DanhSachPhieuNhap { get; } = new();
    }
}

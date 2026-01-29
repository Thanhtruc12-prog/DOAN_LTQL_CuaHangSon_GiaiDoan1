using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LTQL_CuaHangSon.Models
{
    public class LoaiSanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string MaLoai { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string TenLoai { get; set; } = null!;

        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}

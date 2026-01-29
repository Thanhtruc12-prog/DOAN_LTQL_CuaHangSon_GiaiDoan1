using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LTQL_CuaHangSon.Models
{
   
    public class VaiTro
    {
        
        [Key] // Đánh dấu thuộc tính MaVaiTro là khoá chính của bảng 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Giá trị của mã vai trò được Cơ sở dữ liệu tự sinh ra với Identity là tự tăng
        public int ID { get; set; }

        [Required]// Tên vai trò là bắt buộc phải có
        [StringLength(50)] // độ dài chuỗi tối đa là 50 
        public string TenVaiTro { get; set; } = null!; // Hiện tại chưa có giá trị nhưng sẽ được gán sau.

        public string? MoTa { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.Now;

        // Mỗi vai trò có thể có nhiều Quyền và Tài khoản Icollection
        // new List<> Khi tạo Vai trò tạo sẵn 1 cái danh sách Tài Khoản và Phân Quyền rỗng cho phép tạo vai trò mới
        // Dùng ICollection<> thay vì dùng ObservableCollectionListSource<> vì không có ý định bind lên DataGridView dùng ICollection nhẹ hơn
        public virtual ICollection<TaiKhoan> DanhSachTaiKhoan { get; set; } = new List<TaiKhoan>();
        public virtual ICollection<PhanQuyen> DanhSachQuyen { get; set; } = new List<PhanQuyen>();



        //public virtual ObservableCollectionListSource<TaiKhoan> DSTaiKhoan { get; set; } = new();
        //public virtual ObservableCollectionListSource<PhanQuyen> DSQuyen { get; set; } = new();

    }
}

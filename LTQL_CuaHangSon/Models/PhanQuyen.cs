using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LTQL_CuaHangSon.Models
{
   
    public class PhanQuyen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int VaiTroID { get; set; }

        [Required]
        [StringLength(50)]
        public string PhanHe { get; set; } = null!;

        public bool DuocXem { get; set; } = false;

        public bool DuocTao { get; set; } = false;

        public bool DuocSua  { get; set;} = false;

        public bool DuocXoa { get; set; } = false;

        public virtual VaiTro VaiTro { get; set; } = null!;
    }
}
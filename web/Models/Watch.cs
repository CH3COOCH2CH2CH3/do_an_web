using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace MyWatchStore.Models
{
    public class Watch
    {
        [Key]
        public int Mã { get; set; }

        [Required]
        [StringLength(100)]
        public string Tên { get; set; }

        [Required]
        [StringLength(500)]
        public string Thông_tin { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Giá { get; set; }

        [Required]
        [StringLength(200)]
        public string Ảnh { get; set; }


        [Required]
        [StringLength(100)]
        public string TenKH { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Ngay { get; set; }
    }
       
}

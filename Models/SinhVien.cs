using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Makeform.Models
{
    public class SinhVien
    {
        public static List<SinhVien> dssinhvien = new List<SinhVien>();
        [Required(ErrorMessage ="Khong dc de trong")]
        
       
        public string MaSV { get; set; }

        public string TenSV { get; set; }
        public string NgaySinh { get; set; }
        public float Toan { get; set; }
        public float Ly { get; set; }
        public float Hoa { get; set; }
        public double tongdiem
        {
            get
            {
                return Toan + Ly + Hoa;
            }
        }
        public string Anh { get; set; }







    }
}
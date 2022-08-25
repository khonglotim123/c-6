using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models
{
    
    public class SinhVien
    {
        
        public int Id { get; set; }
        public string MaSV { get; set; }
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public int IdLop { get; set; }
        public int IdNghanh { get; set; }
        public Lop lop { get; set; }       
        public Nghanh nghanh { get; set; }
    }
}

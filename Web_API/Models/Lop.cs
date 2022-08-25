using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models
{
    
    public class Lop
    {
        
        public int Id { get; set; }
        public string Ma { get; set; }
        public string TenLop { get; set; }
        public int IdTruong { get; set; }
        public Truong truong { get; set; }
        public IList<SinhVien> sinhViens { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models
{
    
    public class Nghanh
    {
        
        public int Id { get; set; }
        public string Ma { get; set; }
        public string TenNghanh { get; set; }
        public IList<SinhVien> sinhViens { get; set; }
        public IList<MonHoc> monHocs { get; set; }
    }
}

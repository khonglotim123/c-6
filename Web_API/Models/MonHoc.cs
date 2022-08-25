using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models
{
    
    public class MonHoc
    {
       
        public int Id { get; set; }
        public string Ma { get; set; }
        public string TenMon { get; set; }
        public int IdNghanh { get; set; }
        public Nghanh nghanh { get; set; }
        public IList<Diem> diems { get; set; }
    }
}

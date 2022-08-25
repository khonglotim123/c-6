using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models
{
   
    public class Truong
    {
        
        public int Id { get; set; }
        public string Ma { get; set; }
        public string TenTruong { get; set; }
        public IList<Lop> lops { get; set; }
    }
}

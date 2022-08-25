using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models
{
    
    public class Diem
    {
       
        public int Id { get; set; }
        public string Ma { get; set; }
        public float SoDiem { get; set; }
        public int IdMonhoc { get; set; }
        public MonHoc monHoc { get; set; }
    }
}

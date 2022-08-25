using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ViewSinhVien
    {
        public int Id { get; set; }
        public string MaSV { get; set; }       
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public int IdLop { get; set; }
        public int IdNghanh { get; set; }
    }
}

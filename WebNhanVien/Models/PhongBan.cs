using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNhanVien.Models
{
    public class PhongBan
    {
        public PhongBan(int id  , string ten_phong_ban)
        {
            this.id = id;
            this.ten_phong_ban = ten_phong_ban;
           
        }
        public int id { get; set; }
        public string ten_phong_ban { get; set; }

      


       
        public PhongBan() { }
    }
}

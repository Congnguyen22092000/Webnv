using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebNhanVien.Models
{

    public class NhanVien
    {
        public NhanVien(string maNhanVien, string hoTen, DateTime ngaySinh, string soDT, string diaChi, string chucVu,int phong_ban_id, string ten_phong_ban)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.soDT = soDT;
            this.diaChi = diaChi;
            this.chucVu = chucVu;
            this.phong_ban_id = phong_ban_id;
            this.ten_phong_ban = ten_phong_ban;
        }
        public string maNhanVien { get; set; }

        public string hoTen { get; set; }


        public DateTime ngaySinh { get; set; }

        public string soDT { get; set; }

        public string diaChi { get; set; }
        public string chucVu { get; set; }

        public int phong_ban_id { get; set; }

        public string ten_phong_ban { get; set; }

        public double lon { get; set; }

        public double lat { get; set; }
        public NhanVien() { }


    }






}
    

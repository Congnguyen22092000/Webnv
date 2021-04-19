using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNhanVien.Helpers;
using WebNhanVien.Models;

namespace WebNhanVien.Controllers
{
  

    public class StaffController : Controller
    {
        
        float LastStaffId;
        public SessionHelper SessionHelper = new SessionHelper();


        public List<NhanVien> DsTimKiem = new List<NhanVien>();
        public List<NhanVien> DsNhanVien = new List<NhanVien>();
        public StaffController() {
            
                LastStaffId = 6;
                TaoDsNhanVien();
            



        }
       
        /*<SessionState timeout = "30" ></ sessionState >*/


        public List<NhanVien> TaoDsNhanVien()
        {

            DsNhanVien.Add(new NhanVien("NV-0001", "Nguyễn Văn Công", DateTime.Parse("7/6/2000"), "09715869331", "Nhân viên"));
            DsNhanVien.Add(new NhanVien("NV-0002", "Nguyễn Văn Ánh", DateTime.Parse("8/6/1999"), "09715869331", "Nhân viên"));
            DsNhanVien.Add(new NhanVien("NV-0003", "Lê Thị Huệ", DateTime.Parse("6/3/2000"), "09715869331", "Nhân viên"));
            DsNhanVien.Add(new NhanVien("NV-0004", "Trần Văn Chung", DateTime.Parse("4/5/2000"), "09715869331", "Nhân viên"));
            DsNhanVien.Add(new NhanVien("NV-0005", "Bùi Tiến Đạt", DateTime.Parse("12/11/2000"), "09715869331", "Nhân viên"));
           
            /*HttpContext.Session.SetObjectAsJson("listNV", DsNhanVien);*/
            return DsNhanVien;
        }

        [HttpGet]
        public ActionResult Index()
        {

            byte[] json;
            if (HttpContext.Session.TryGetValue("StaffList", out json) && HttpContext.Session.TryGetValue("LastStaffId", out json))
            {
                DsNhanVien = JsonConvert.DeserializeObject<List<NhanVien>>(HttpContext.Session.GetString("StaffList"));
                LastStaffId = JsonConvert.DeserializeObject<float>(HttpContext.Session.GetString("LastStaffId"));
            }
            else
            {

                HttpContext.Session.SetString("StaffList", JsonConvert.SerializeObject(DsNhanVien));
                HttpContext.Session.SetString("LastStaffId", JsonConvert.SerializeObject(LastStaffId));

            }

            if (this.LastStaffId % 10 == 0)
            {
                ViewBag.maNV = "NV-" + (this.LastStaffId / 10000).ToString().Substring(2) + "0";
            }
            else
            {
                ViewBag.maNV = "NV-" + (this.LastStaffId / 10000).ToString().Substring(2);
            }

            

            return View(DsNhanVien);

        }
      
        /*[HttpPost]
        public ActionResult Index(string key = "")
        {

            return View();

        }*/
        [HttpPost]
        public IActionResult Search(string key)
        {
            if (key == null)
            {
                DsNhanVien = JsonConvert.DeserializeObject<List<NhanVien>>(HttpContext.Session.GetString("StaffList"));
                return View(DsNhanVien);
            }
            else
            {
                DsNhanVien = JsonConvert.DeserializeObject<List<NhanVien>>(HttpContext.Session.GetString("StaffList"));
                foreach (NhanVien nv in DsNhanVien)
                {
                    if (nv.maNhanVien.ToLower().IndexOf(key) > -1 || nv.hoTen.ToLower().IndexOf(key) > -1 /*|| nv.ngaySinh.ToShortDateString().ToLower().IndexOf(key) > -1 || nv.soDT.ToString().ToLower().IndexOf(key) > -1 || nv.chucVu.ToString().ToLower().IndexOf(key) > -1*/)
                    {
                        DsTimKiem.Add(nv);
                    }

                }
                HttpContext.Session.SetString("SearchList", JsonConvert.SerializeObject(DsTimKiem));
                return View(DsTimKiem);
            }
           
      
            
            

        }




        [HttpPost]
        public IActionResult CreateNV(NhanVien newItem = null)
        {
            
            byte[] json;
            if (HttpContext.Session.TryGetValue("StaffList", out json))
            {
                DsNhanVien = JsonConvert.DeserializeObject<List<NhanVien>>(HttpContext.Session.GetString("StaffList"));
                LastStaffId = JsonConvert.DeserializeObject<float>(HttpContext.Session.GetString("LastStaffId"));
                newItem.hoTen = XuLyTen(newItem.hoTen);
                if (!IsDuplicatedStaff(newItem))
                { 
                    DsNhanVien.Add(newItem);
                    LastStaffId += 1;
                }
                
                HttpContext.Session.SetString("LastStaffId", JsonConvert.SerializeObject(LastStaffId));
                HttpContext.Session.SetString("StaffList", JsonConvert.SerializeObject(DsNhanVien));

            }
            return Redirect("/staff/index");
        }
        [HttpGet]
        public IActionResult CreateNV()
        {
           
            return View();
            
        }

        [HttpPost]
        public ActionResult Edit(NhanVien newItem = null)
        {
           
            DsNhanVien = JsonConvert.DeserializeObject<List<NhanVien>>(HttpContext.Session.GetString("StaffList"));
            
            for (int i = 0; i < DsNhanVien.Count; i++)
            {
                if (DsNhanVien[i].maNhanVien == newItem.maNhanVien)
                {
                    DsNhanVien[i] = newItem;
                    HttpContext.Session.SetString("StaffList", JsonConvert.SerializeObject(DsNhanVien));
                }
            }
            return Redirect("/staff/index");
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            
            return View();
        }
      

        [HttpPost]
        public bool Delete(string maNhanVien)
        {
           
            byte[] json;
            if (HttpContext.Session.TryGetValue("StaffList", out json))
            {
               
                DsNhanVien = JsonConvert.DeserializeObject<List<NhanVien>>(HttpContext.Session.GetString("StaffList"));
            }
            for (int i = 0; i < DsNhanVien.Count; i++)
            {
                if (DsNhanVien[i].maNhanVien == maNhanVien)
                {
                    DsNhanVien.RemoveAt(i);

                    HttpContext.Session.SetString("StaffList", JsonConvert.SerializeObject(DsNhanVien));
                }
            }
            return true;
        }


    
        public string XuLyTen(string name)
        {
            string result = "";
            if (name != "" && name != null)
            {
                List<char> arrName = new List<char>(name.ToLower().Trim().ToCharArray());
                for (int i = 0; i < arrName.Count; i++)
                {
                    if (arrName[i] == ' ')
                    {
                        int _i = i + 1;
                        if (arrName[_i] == ' ')
                        {
                            arrName.RemoveAt(i);
                        }
                    }
                }
                arrName[0] = char.ToUpper(arrName[0]);
                for (int i = 0; i < arrName.Count; i++)
                {
                    if (arrName[i] == ' ')
                    {
                        int _i = i + 1;
                        arrName[_i] = char.ToUpper(arrName[_i]);
                    }
                }

                for (int i = 0; i < arrName.Count; i++)
                {
                    result += arrName[i].ToString();
                }
            }
            return result;
        }

        public bool IsDuplicatedStaff(NhanVien pnv)
        {
            pnv.hoTen = XuLyTen(pnv.hoTen);
            bool daTonTai = false;
            byte[] json;
            if (HttpContext.Session.TryGetValue("StaffList", out json))
            {
                DsNhanVien = JsonConvert.DeserializeObject<List<NhanVien>>(HttpContext.Session.GetString("StaffList"));
            }

           
            foreach (NhanVien nv in DsNhanVien)
            {
                

                if (nv.hoTen == pnv.hoTen && nv.maNhanVien != pnv.maNhanVien)
                {
                    if (DateTime.Compare(nv.ngaySinh, pnv.ngaySinh) == 0)
                    {
                        daTonTai = true;
                        break;

                    }
                    else { daTonTai = false; }
                }
                else { daTonTai = false; }
                
            }
            return daTonTai;
        }

        public bool EditValidate(NhanVien pnv)
        {
            bool daTonTai = false;
            byte[] json;
            if (HttpContext.Session.TryGetValue("StaffList", out json))
            {
                DsNhanVien = JsonConvert.DeserializeObject<List<NhanVien>>(HttpContext.Session.GetString("StaffList"));
            }
            pnv.hoTen = XuLyTen(pnv.hoTen);
            for (int i = 0; i < DsNhanVien.Count; i++)
            {
                if (DsNhanVien[i].hoTen == pnv.hoTen && DateTime.Compare(DsNhanVien[i].ngaySinh, pnv.ngaySinh) == 0 && DsNhanVien[i].maNhanVien != pnv.maNhanVien)
                {
                    daTonTai = true;
                    break;
                }

            }
            return daTonTai;
        }
      

        [HttpGet]
        public ActionResult test()
        {

            return View();
        }


    }
}

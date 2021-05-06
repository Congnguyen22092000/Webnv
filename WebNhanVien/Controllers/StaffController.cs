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
        

        public SessionHelper SessionHelper = new SessionHelper();
        private int itemPerPage = 6;
        private string currentPage = "p-1";

        [HttpGet]
       

        [HttpGet]
        public ActionResult Index()
        {

            float temp = DBHelper.GetCount() + 1;
            if (temp > 10 )
            {
                ViewBag.maNV = "NV-00" +  temp.ToString() ;
            }
            
            else
            {
                ViewBag.maNV = "NV-000" + temp.ToString();
            }

            if ((int)DBHelper.Get().Count % itemPerPage == 0)
            {
                ViewBag.currentPage = "p-" + (int)DBHelper.Get().Count / itemPerPage;
            }
            else
            {
                ViewBag.currentPage = currentPage;
            }
            ViewBag.pageNumber = (int)DBHelper.Get().Count / itemPerPage;

           
            return View(DBHelper.GetPhongBan());

        }
       

        [HttpPost]
        public IActionResult Index(string key = "")
        {

            return View(DBHelper.Get(key));

        }
        




        [HttpPost]
        public IActionResult CreateNV(NhanVien newItem = null)
        {
            newItem.phong_ban_id = DBHelper.searchPhongBan(newItem.ten_phong_ban);
            newItem.hoTen = XuLyTen(newItem.hoTen);
            newItem.diaChi = XuLyTen(newItem.diaChi);
            DBHelper.Create(newItem);
            
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
            newItem.phong_ban_id = DBHelper.searchPhongBan(newItem.ten_phong_ban);
            newItem.hoTen = XuLyTen(newItem.hoTen);
            newItem.diaChi = XuLyTen(newItem.diaChi);
            DBHelper.Update(newItem);
            return Redirect("/staff/index");
        }


        [HttpGet]
        public ActionResult Edit(string id)
        {
            
            return View();
        }
      

        [HttpPost]
        public bool Delete(string MaNhanVien)
        {
            DBHelper.Delete(MaNhanVien);
            Redirect("/staff/index");
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

        //Lien quan toi page----------------------
        //Tim kiem===============================
        [HttpPost]
        public IActionResult Search(string keyPhongBan = "", string keyBox = "")
        {
            List<NhanVien> dsTim = DBHelper.Get(keyPhongBan, keyBox);
            ViewBag.itemPerPage = itemPerPage;
            if (keyBox == "")
            {
                return View(DBHelper.Get());
            }
            return View(DBHelper.Get(keyPhongBan, keyBox));
        }
        [HttpGet]
        public ActionResult PageNav()
        {

            return View();
        }
        [HttpPost]
        public IActionResult PageNav(string currentPage = "p-1",string keyPhongBan="",string keyBox="")
        {
            ViewBag.keyBox = keyBox;
            ViewBag.keyPhongBan = keyPhongBan;
            if ((int)DBHelper.Get().Count % itemPerPage == 0)
            {
                ViewBag.currentPage = "p-" + (int)DBHelper.Get().Count / itemPerPage;
            }
            else
            {
                ViewBag.currentPage = currentPage;
            }
            if((int)DBHelper.Get().Count % itemPerPage == 0)
            {
                ViewBag.pageNumber = (int)DBHelper.Get(keyPhongBan, keyBox).Count / itemPerPage;
            }
            else
            {
                ViewBag.pageNumber = (int)DBHelper.Get(keyPhongBan, keyBox).Count / itemPerPage + 1;
            }
            

            return View();
        }
        [HttpPost]
        public IActionResult GetPage(int pageIndex, string keyPhongBan = "", string keyBox = "")
        {
            ViewBag.dsPhongban = DBHelper.GetPhongBan();
            ViewBag.pageIndex = pageIndex;
            ViewBag.itemPerPage = itemPerPage;
            return View(DBHelper.Get(keyPhongBan, keyBox));
        }

        public bool IsDuplicatedStaff(NhanVien pnv)
        {
            pnv.hoTen = XuLyTen(pnv.hoTen);
            bool daTonTai = false;
            var tempNhanVien = DBHelper.Get();


            foreach (NhanVien nv in tempNhanVien)
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

        [HttpPost]
        public bool ExcelExport()
        {
            DBHelper.Export(DBHelper.Get());
            return true;
        }


        [HttpPost]
        public bool checkPhongban()
        {
            
            return true;
        }
        [HttpGet]
        public ActionResult test()
        {

            return View();
        }


    }
}

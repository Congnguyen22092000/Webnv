using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
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
            if (temp >= 10 )
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
            if ((int)DBHelper.Get(keyPhongBan, keyBox).Count % itemPerPage == 0)
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
            HttpContext.Session.SetString("keyPhongBanSS", JsonConvert.SerializeObject(keyPhongBan));
            HttpContext.Session.SetString("keyBoxSS", JsonConvert.SerializeObject(keyBox));
            ViewBag.dsPhongban = DBHelper.GetPhongBan();
            ViewBag.pageIndex = pageIndex;
            ViewBag.itemPerPage = itemPerPage;
            ViewBag.phongBan = keyPhongBan;
            ViewBag.box = keyBox;
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
        public async Task<IActionResult> Import(IFormFile file)
        {
                    var list = new List<NhanVien>();
                    using (var stream = new MemoryStream())
                    {
                        await file.CopyToAsync(stream);
                        using(var package = new ExcelPackage(stream))
                        {
                            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                            var rowcount = worksheet.Dimension.Rows;
                            for(int row = 2 ; row<rowcount+1 ; row++)
                            {
                                var dateString = worksheet.Cells[row, 3].Value;
                                /*var check = typeof(dateString);*/
                               
                                var tempDate = worksheet.Cells[row, 3].Value.ToString().Trim();
                                var tempID = (double)worksheet.Cells[row, 7].Value;
                                list.Add(new NhanVien
                                {
                                    maNhanVien = worksheet.Cells[row, 1].Value.ToString().Trim(),
                                    hoTen = worksheet.Cells[row, 2].Value.ToString().Trim(),
                                    ngaySinh = (DateTime)worksheet.Cells[row, 3].Value,
                                    soDT = worksheet.Cells[row, 4].Value.ToString().Trim(),
                                    diaChi = worksheet.Cells[row, 5].Value.ToString().Trim(),
                                    chucVu = worksheet.Cells[row, 6].Value.ToString().Trim(),
                                    phong_ban_id = (int)tempID,
                                    ten_phong_ban = worksheet.Cells[row, 8].Value.ToString().Trim()
                                });
                            }
                        }
                    }
                    DBHelper.UpDateExcel(list);
                    return Redirect("/staff/index"); 
        }
        
        public IActionResult Export()
        {
            var tempPhongBan = JsonConvert.DeserializeObject<string>(HttpContext.Session.GetString("keyPhongBanSS"));
            var tempBox = JsonConvert.DeserializeObject<string>(HttpContext.Session.GetString("keyBoxSS"));
            var data = DBHelper.Get(tempPhongBan, tempBox).ToList();
            /*var stream = new MemoryStream();*/
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var stream = DBHelper.Export(data);
            var nameFile = "PB-" + tempPhongBan + ".xlsx";
            stream.Position = 0;
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nameFile);
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

        [HttpPost]
        public ActionResult phongBan(string name="")
        {
            ViewBag.Name = name;
            return View(DBHelper.GetPhongBan());
        }

    }
}

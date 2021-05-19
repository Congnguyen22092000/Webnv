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
                ViewBag.currentPage = "p-" + ((int)DBHelper.Get().Count / itemPerPage - 1) ;
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
        public IActionResult PageNav(string currentPage = "p-1",string keyPhongBan="",string keyBox="", int ageMin = 0, int ageMax = 100)
        {
            ViewBag.ageMin = ageMin;
            ViewBag.ageMax = ageMax;
            ViewBag.keyBox = keyBox;
            ViewBag.keyPhongBan = keyPhongBan;
            if ((int)DBHelper.Get().Count % itemPerPage == 0)
            {
                ViewBag.currentPage = "p-" + ((int)DBHelper.Get().Count / itemPerPage -1);
            }
            else
            {
                ViewBag.currentPage = currentPage;
            }
            if ((int)DBHelper.Get(keyPhongBan, keyBox, ageMin, ageMax).Count % itemPerPage == 0)
            {
                ViewBag.pageNumber = (int)DBHelper.Get(keyPhongBan, keyBox, ageMin,ageMax).Count / itemPerPage;
            }
            else
            {
                ViewBag.pageNumber = (int)DBHelper.Get(keyPhongBan, keyBox, ageMin, ageMax).Count / itemPerPage + 1;
            }
            

            return View();
        }
        [HttpPost]
        public IActionResult GetPage(int pageIndex, string keyPhongBan = "", string keyBox = "", int ageMin = 0, int ageMax = 100)
        {
            HttpContext.Session.SetString("ageMin", JsonConvert.SerializeObject(ageMin));
            HttpContext.Session.SetString("ageMax", JsonConvert.SerializeObject(ageMax));
            HttpContext.Session.SetString("keyPhongBanSS", JsonConvert.SerializeObject(keyPhongBan));
            HttpContext.Session.SetString("keyBoxSS", JsonConvert.SerializeObject(keyBox));
            ViewBag.dsPhongban = DBHelper.GetPhongBan();
            ViewBag.pageIndex = pageIndex;
            ViewBag.itemPerPage = itemPerPage;
            ViewBag.phongBan = keyPhongBan;
            ViewBag.box = keyBox;
            return View(DBHelper.Get(keyPhongBan, keyBox, ageMin, ageMax));
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
            List<string> BaoLoi = new List<string>();
            
            int coutOld = 0;
            int coutNew = 0;
            var list = new List<NhanVien>();
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using(var package = new ExcelPackage(stream))
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowcount = worksheet.Dimension.Rows;
                    var dem = 0;
                    for(int row = 2 ; row<rowcount+1 ; row++)
                    {
                        string tempMaNull = "";
                        bool checkOut = false;
                        //Bắt ngoại lệ định dạng ngày tháng
                        try
                        {
                            if(worksheet.Cells[row, 3].Value == null)
                            {
                                if(worksheet.Cells[row, 1].Value == null)
                                {
                                    checkOut = true;
                                }
                                else
                                {
                                    tempMaNull = worksheet.Cells[row, 1].Value.ToString().Trim();
                                    BaoLoi.Add(tempMaNull);
                                    checkOut = true;
                                }
                                
                            }
                            else
                            {
                                var ad = (DateTime)worksheet.Cells[row, 3].Value;
                            }
                            // khối này được giám sát để bắt lỗi - khi nó phát sinh
                           

                        }
                        catch (Exception)
                        {
                            tempMaNull = worksheet.Cells[row, 1].Value.ToString().Trim();
                            BaoLoi.Add(tempMaNull);
                            checkOut = true;

                        }

                        //bắt lỗi trống dữ liệu===============
                        if (checkOut == false)
                        {
                            for (int colum = 2; colum < 9; colum++)
                            {
                                var checkNull = worksheet.Cells[row, colum].Value;
                                if (checkNull == null)
                                {
                                    tempMaNull = worksheet.Cells[row, 1].Value.ToString().Trim();
                                    BaoLoi.Add(tempMaNull);
                                    checkOut = true;
                                }
                            }
                        }
                        
                         
                        if(checkOut == true)
                        {
                            continue;
                        }
                        
                        var check = worksheet.Cells[row, 1].Value;

                        //mã nhân viên trống=================
                        if (check == null)
                        {
                            coutNew++;
                            float temp = DBHelper.GetCount() + dem +1 ;
                            String tempMaNhanVien;
                            if (temp >= 10)
                            {
                                    tempMaNhanVien = "NV-00" + temp.ToString();
                            }
                                     
                            else
                            {
                                    tempMaNhanVien = "NV-000" + temp.ToString();
                            }
                            list.Add(new NhanVien
                            {
                                maNhanVien = tempMaNhanVien,
                                hoTen = worksheet.Cells[row, 2].Value.ToString().Trim(),
                                ngaySinh = (DateTime)worksheet.Cells[row, 3].Value,
                                soDT = worksheet.Cells[row, 4].Value.ToString().Trim(),
                                diaChi = worksheet.Cells[row, 5].Value.ToString().Trim(),
                                chucVu = worksheet.Cells[row, 6].Value.ToString().Trim(),
                                phong_ban_id = 0,
                                ten_phong_ban = worksheet.Cells[row, 8].Value.ToString().Trim()
                            });
                        }
                        //mã nhân viên không trống
                        else
                        {

                            if(checkOutImport(check.ToString().Trim()) == true)
                            {
                                        continue;
                            }
                            else
                            {
                                if(DBHelper.checkTrungMaNhanVien(DBHelper.Get("",""), check.ToString().Trim()) == true)
                                {
                                    coutOld++;
                                }
                                else
                                {
                                    coutNew++;
                                }
                                var listGoc = DBHelper.Get("", "");
                                if(DBHelper.checkTrungMaNhanVien(listGoc, check.ToString().Trim())==false)
                                    {
                                            dem++;
                                    }
                                list.Add(new NhanVien
                                {   
                                    maNhanVien = worksheet.Cells[row, 1].Value.ToString().Trim(),
                                    hoTen = worksheet.Cells[row, 2].Value.ToString().Trim(),
                                    ngaySinh = (DateTime)worksheet.Cells[row, 3].Value,
                                    soDT = worksheet.Cells[row, 4].Value.ToString().Trim(),
                                    diaChi = worksheet.Cells[row, 5].Value.ToString().Trim(),
                                    chucVu = worksheet.Cells[row, 6].Value.ToString().Trim(),
                                    phong_ban_id = 0,
                                    ten_phong_ban = worksheet.Cells[row, 8].Value.ToString().Trim()
                                });
                            }
                        }
                    }
                }
            }
            ViewBag.coutLoi = BaoLoi.Count();
            ViewBag.BaoLoi = BaoLoi;
            ViewBag.coutOld = coutOld.ToString();
            ViewBag.coutNew = coutNew.ToString();
            DBHelper.UpDateExcel(list);
            return View();
        }
        
        public bool checkOutImport(string maNV)
        {
            bool check = false;
            if (maNV.Length != 7)
            {
                check = true;
            }
            else
            {
                string temp = maNV.Substring(3, 4);
                int checkInt = 0;
                for(int i =0; i <temp.Length; i++)
                {
                    string tempIn = temp.Substring(i, 1);
                    for (int j = 0;j < 10; j++)
                    {
                        
                        if(tempIn == j.ToString())
                        {
                            checkInt++;
                            break;
                        }
                    }
                }
                check = checkInt == 4 ? false : true;
            }
            if (maNV.IndexOf("NV-") == -1)
            {
                check = true;
            }
            
            return check;
        }
        public IActionResult Export()
        {
            var tempPhongBan = JsonConvert.DeserializeObject<string>(HttpContext.Session.GetString("keyPhongBanSS"));
            var tempBox = JsonConvert.DeserializeObject<string>(HttpContext.Session.GetString("keyBoxSS"));
            var ageMin = JsonConvert.DeserializeObject<int>(HttpContext.Session.GetString("ageMin"));
            var ageMax = JsonConvert.DeserializeObject<int>(HttpContext.Session.GetString("ageMax"));
            var data = DBHelper.Get(tempPhongBan, tempBox ,ageMin ,ageMax);
            /*var stream = new MemoryStream();*/
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var stream = DBHelper.Export(data);
            var nameFile = "PB-" + tempPhongBan + ".xlsx";
            stream.Position = 0;
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nameFile);
        }

        public IActionResult ExportBieuMau()
        {
            
            var data = DBHelper.getNull();
            /*var stream = new MemoryStream();*/
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var stream = DBHelper.ExportBieuMau(data);
            var nameFile =  "Biểu Mẫu.xlsx";
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

        [HttpGet]
        public ActionResult ViewMap()
        {
            
            return View(DBHelper.Get("", ""));
        }
        
        public List<NhanVien> getListNV()
        {
            List<NhanVien> nv = new List<NhanVien>();
            nv = DBHelper.Get("","");
            return nv;
        }
        [HttpPost]
        public ActionResult GetSearchMap(string key="")
        {
            var check = DBHelper.SearchMap(key);
            return View(DBHelper.SearchMap(key));
        }

        public List<NhanVien> searchLonLat(string key = "")
        {
            List<NhanVien> nv = new List<NhanVien>();
            nv = DBHelper.SearchLonLat(key).ToList();
            return nv;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebNhanVien.Models;

namespace WebNhanVien.Controllers
{
    public class DemoController1 : Controller
    {
        private readonly NhanVien nv;
        public  DemoController1(NhanVien nhanvien)
        {
            nv = nhanvien;
        }

        public IActionResult Export()
        {
            var data = nv.maNhanVien.ToList();
            var stream = new MemoryStream();
            using (var package =  new ExcelPackage(stream))
            {
                var sheet = package.Workbook.Worksheets.Add("Nhan_Vien");
                //Do du lieu
                sheet.Cells.LoadFromCollection(data, true);
                package.Save();
            }

            stream.Position = 0;
            var fileName = "cong.xlsx";
            return File(stream, "application/vnd.ms-excel.sheet.macroEnabled.12",fileName);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

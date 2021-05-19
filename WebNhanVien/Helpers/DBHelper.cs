using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNhanVien.Models;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Style;
using System.Drawing;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;

namespace WebNhanVien.Helpers
{
    public static class DBHelper
    {
        private static readonly string connectionString = "HOST=127.0.0.1;Username=postgres;Password=cong2209;Database=CongData";
        
        public static List<NhanVien> Get(string keyPhongBan =  "",string keyBox = "",int ageMin = 0, int ageMax =100)
        {
            if (keyPhongBan == "")
            {
                keyPhongBan = "Tất Cả";
            }
            IEnumerable<NhanVien> nhanvien = null;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
               
                    if ( keyBox != null )
                    {
                        if(keyPhongBan == "Tất Cả")
                        {
                            nhanvien = connection.Query<NhanVien>("select* from \"Cong_Data\" where lower(unaccent(\"hoTen\")) like '%' || lower(unaccent(@keyBox)) || '%' or lower(unaccent(\"diaChi\")) like '%' || lower(unaccent(@keyBox)) || '%' ", new { keyBox = keyBox });
                        }
                        else
                        {
                            if (searchPhongBan(keyPhongBan) == 0)
                            {
                                nhanvien = null;
                            }
                            else
                            {
                                nhanvien = connection.Query<NhanVien>("select* from \"Cong_Data\" where \"phong_ban_id\" = @keyPhongBan and (lower(unaccent(\"hoTen\")) like '%' || lower(unaccent(@keyBox)) || '%' or lower(unaccent(\"diaChi\")) like '%' || lower(unaccent(@keyBox)) || '%')", new { keyPhongBan = searchPhongBan(keyPhongBan), keyBox = keyBox });
                            }
                        }
                    }
                    
                    else
                    {
                        if (keyPhongBan == "Tất Cả")
                        {
                            nhanvien = connection.Query<NhanVien>("SELECT * from \"Cong_Data\" order by \"maNhanVien\" ASC");
                        }
                        else
                        {
                            
                            if (searchPhongBan(keyPhongBan) == 0)
                            {
                                nhanvien = null;
                            }
                            else
                            {
                                nhanvien = connection.Query<NhanVien>("select* from \"Cong_Data\" where \"phong_ban_id\" = @keyPhongBan ", new { keyPhongBan = searchPhongBan(keyPhongBan) });
                            }
                        }
                    /*nhanvien = connection.Query<NhanVien>("SELECT * from \"Cong_Data\" order by \"maNhanVien\" ASC");*/
                }
                
                 }
            //get ra tên phòng ban============================================================================================
            var tempList = nhanvien.ToList();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                foreach (NhanVien nv in tempList)
                {
                    nv.ten_phong_ban = connection.Query<string>("select ten_phong_ban from phong_ban where id = @id", new { id = nv.phong_ban_id }).First();
                }
            }
            //Check độ tuổi
            List<NhanVien> outList = new List<NhanVien>();
            if(ageMin >= 0 || ageMax <= 100)
            {
                int nowYear = DateTime.Now.Year;
                foreach(NhanVien nhanVien in tempList)
                {
                    if(nowYear - nhanVien.ngaySinh.Year >= ageMin && nowYear - nhanVien.ngaySinh.Year <= ageMax)
                    {
                        outList.Add(nhanVien);
                    }
                }
            }
               
            return outList;
        }

        //Lấy ra list rỗng
        public static List<NhanVien> getNull()
        {
            List<NhanVien> nv = new List<NhanVien>();
            return nv;
        }


        //Get id từ tên phòng ban=====================================================================================================
        public static int searchPhongBan(string temp)
        {
            int x = 0;
           
            if (checkPhongBan(temp) != "False")
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    if (connection.Query<int>("select id from phong_ban where ten_phong_ban = @ten", new { ten = temp }).First() == 0)
                    {
                        x = 0;
                    }
                    else
                    {
                        x = connection.Query<int>("select id from phong_ban where ten_phong_ban = @ten", new { ten = temp }).First();
                    }


                }
            }
            else
            {
                x = 0;
            }
            

            return x;
        }
        //Kiêm tra tồn tại phòng ban=======================================================================
        public static string checkPhongBan(string name)
        {
            var outString = "";
            IEnumerable<PhongBan> phongban = null;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                phongban = connection.Query<PhongBan>("SELECT * from \"phong_ban\" order by \"id\" ASC");
            }
            var tempList = phongban.ToList();   
            foreach(PhongBan pb in tempList)
            {
                if(ReplaceUnicode(pb.ten_phong_ban).ToLower() == ReplaceUnicode(name).ToLower())
                {
                    return outString = pb.ten_phong_ban;
                }
            }
            return "False";
        }

        //Get list phong ban===================================================================
        public static List<PhongBan> GetPhongBan(string key = null)
        {
            IEnumerable<PhongBan> phongban = null;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                if (key == null)
                    phongban = connection.Query<PhongBan>("SELECT * from \"phong_ban\" order by \"id\" ASC");

                else

                    phongban = connection.Query<PhongBan>("select* from \"phong_ban\" where lower(unaccent(\"hoTen\")) like '%' || lower(unaccent(@key)) || '%' or lower(unaccent(\"diaChi\")) like '%' || lower(unaccent(@key)) || '%'", new { key = key });


            }

            return phongban.ToList();
        }

        //Get tên phòng ban từ id=================================================================
        public static string ParsePhongBan(int id)
        {
            string getOut = "";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                getOut = connection.Query<string>("select ten_phong_ban from phong_ban where id = @id", new { id = id }).First();


            }
            return getOut;

        }

        //Get id phòng ban lớn nhất
        public static int GetCountPhongBan()
        {
            int idPhongBan;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                idPhongBan = connection.Query<int>("SELECT MAX(\"id\") FROM \"phong_ban\"").First();

            }

            return idPhongBan;
        }


        //Get mã nhân viên lớn nhất===============================================================
        public static int GetCount()
        {
            int coutnTmp;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string tmpMaNhanVien = connection.Query<string>("SELECT MAX(\"maNhanVien\") FROM \"Cong_Data\"").First();
               
                string tmp = tmpMaNhanVien.Substring(5, 2);
                
                coutnTmp = int.Parse(tmp);
            }

            return coutnTmp;
        }



        public static NhanVien GetByMNV(string key = "")
        {
            IEnumerable<NhanVien> nhanvien = null;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                nhanvien = connection.Query<NhanVien>("SELECT * from Cong_Data where maNV = @key ", new { key = key });
            }
            return nhanvien.First();
        }
        public static int GetTheLastID()
        {


            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var id = connection.Query<int>("select nextval('nhanvien_id_seq'::regclass); ");
                if ((int)id.Count() == 0) return 0;
                return id.First();
            }

        }
        //Tạo thêm nhân viên======================================================================
        public static void Create(NhanVien nv)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute("insert into \"Cong_Data\"(\"maNhanVien\",\"hoTen\",\"ngaySinh\",\"soDT\",\"diaChi\",\"chucVu\",\"phong_ban_id\",\"lon\" ,\"lat\" ) values(@maNhanVien,@hoTen,@ngaySinh,@soDT,@diaChi,@chucVu,@phong_ban_id,@lon,@lat)", new { nv.maNhanVien, nv.hoTen, nv.ngaySinh, nv.soDT, nv.diaChi, nv.chucVu, nv.phong_ban_id,nv.lon,nv.lat });

            }
        }


        //Update Nhân viên-----------------------------------------------------------------------
        public static void Update(NhanVien nv)
        {
           
           
            var tempList = Get("", "");
            var checkTonTai = false;
            foreach(NhanVien NV in tempList)
            {
                if (NV.maNhanVien == nv.maNhanVien)
                {
                    checkTonTai = true;
                }
            }
           
            if (checkTonTai == true)
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    connection.Execute("Update \"Cong_Data\" SET  \"hoTen\" = @hoTen ,\"ngaySinh\" = @ngaySinh, \"soDT\" = @soDT,\"diaChi\" = @diaChi,\"chucVu\" = @chucVu,\"phong_ban_id\" = @phong_ban_id,\"lon\" = @lon ,\"lat\" = @lat WHERE \"maNhanVien\" = @maNhanVien", new { nv.maNhanVien, nv.hoTen, nv.ngaySinh, nv.soDT, nv.diaChi, nv.chucVu, nv.phong_ban_id,nv.lon,nv.lat });

                }
            }
            else
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    connection.Execute("insert into \"Cong_Data\"(\"maNhanVien\",\"hoTen\",\"ngaySinh\",\"soDT\",\"diaChi\",\"chucVu\",\"phong_ban_id\",\"lon\" ,\"lat\" ) values(@maNhanVien,@hoTen,@ngaySinh,@soDT,@diaChi,@chucVu,@phong_ban_id,@lon,@lat)", new { nv.maNhanVien, nv.hoTen, nv.ngaySinh, nv.soDT, nv.diaChi, nv.chucVu, nv.phong_ban_id, nv.lon, nv.lat });

                }
            }
        }
        //Import Nhân Viên=======================================================
        public static void UpDateExcel(List<NhanVien> nv)
        {
            var listGoc = Get("", "");
            var listMoi = nv;

            foreach (NhanVien nhanvien in listMoi)
            {
                if (checkPhongBan(nhanvien.ten_phong_ban) == "False")
                {
                    {
                        using (var connection = new NpgsqlConnection(connectionString))
                        {
                            connection.Open();
                            connection.Execute("insert into \"phong_ban\"(\"ten_phong_ban\") values(@tenPhongBan)", new { tenPhongBan = nhanvien.ten_phong_ban });

                        }
                    }
                    nhanvien.phong_ban_id = DBHelper.GetCountPhongBan();
                }
                else
                {
                    nhanvien.phong_ban_id = searchPhongBan(checkPhongBan(nhanvien.ten_phong_ban));
                }

            }
            for (int i = 0; i < listMoi.Count; i++)
            {
                bool checkTrung = true;
                for (int j = 0; j < listGoc.Count; j++)
                {
                    if (listMoi[i].maNhanVien == listGoc[j].maNhanVien)
                    {
                        checkTrung = false;
                        listGoc[j] = listMoi[i];
                        break;
                    }

                }
                if (checkTrung == true)
                {
                    listGoc.Add(listMoi[i]);
                }
            }

            foreach (NhanVien nhanvien in listGoc)
            {
                Update(nhanvien);
            }
        }

        public static void Delete(string maNhanVien)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute("Delete FROM  \"Cong_Data\" where \"maNhanVien\" = @maNhanVien", new { maNhanVien = maNhanVien });

            }
        }
        //Export Excel===============================================
        public static Stream Export(List<NhanVien> data = null)
        {

            var stream = new MemoryStream();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(stream))
            {


                var excelWorkSheet = package.Workbook.Worksheets.Add("Sheet1");
                //Do du lieu
                /*sheet.Cells.LoadFromCollection(data, true);
                package.Save();*/

                excelWorkSheet.Cells["A1"].Value = "Mã Nhân Viên";

                excelWorkSheet.Cells["B1"].Value = "Họ Tên";
                excelWorkSheet.Cells["C1"].Value = "Ngày Sinh";
                excelWorkSheet.Cells["D1"].Value = "Số Điện Thoại";
                excelWorkSheet.Cells["E1"].Value = "Địa Chỉ";
                excelWorkSheet.Cells["F1"].Value = "Chức Vụ";
                excelWorkSheet.Cells["G1"].Value = "Phong Ban ID";
                excelWorkSheet.Cells["H1"].Value = "Tên Phòng Ban";
                excelWorkSheet.Cells["A2"].LoadFromCollection(data);
                excelWorkSheet.Cells["C2:C" + (data.Count + 1).ToString()].Style.Numberformat.Format = "dd/MM/yyyy";
    
                //set boder----------------------------------------------------------------
                excelWorkSheet.Cells["A1:H" + (data.Count + 1).ToString()].Style.Font.Size = 12;
                excelWorkSheet.Cells["A1:H1"].Style.Font.Color.SetColor(Color.White);
                excelWorkSheet.Cells["A1:H1"].Style.Font.Bold = true;
                excelWorkSheet.Cells["A1:H1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                excelWorkSheet.Cells["A1:H1"].Style.Fill.BackgroundColor.SetColor(Color.Green);

                // excelWorkSheet.Cells["A1:H1"].Style.GetT.SetColor(Color.Green);
                excelWorkSheet.Cells["A1:H1"].Style.Border.Top.Style = ExcelBorderStyle.Thick;
                excelWorkSheet.Cells["A1:H1"].Style.Border.Right.Style = ExcelBorderStyle.Thick;
                excelWorkSheet.Cells["A1:H1"].Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
                excelWorkSheet.Cells["A1:H1"].Style.Border.Left.Style = ExcelBorderStyle.Thick;
                //Set style and color------------------------------------------------------
                excelWorkSheet.Cells["A2:H" + (data.Count + 1).ToString()].Style.Border.Top.Style = ExcelBorderStyle.Double;
                excelWorkSheet.Cells["A2:H" + (data.Count + 1).ToString()].Style.Border.Bottom.Style = ExcelBorderStyle.Double;
                excelWorkSheet.Cells["A2:H" + (data.Count + 1).ToString()].Style.Border.Top.Color.SetColor(Color.Purple);
                excelWorkSheet.Cells["A2:H" + (data.Count + 1).ToString()].Style.Border.Bottom.Color.SetColor(Color.Purple);
                excelWorkSheet.Cells["A2:H" + (data.Count + 1).ToString()].Style.Border.Right.Style = ExcelBorderStyle.Double;
                excelWorkSheet.Cells["A2:H" + (data.Count + 1).ToString()].Style.Border.Left.Style = ExcelBorderStyle.Double;
                excelWorkSheet.Cells["A2:H" + (data.Count + 1).ToString()].Style.Border.Right.Color.SetColor(Color.Purple);
                excelWorkSheet.Cells["A2:H" + (data.Count + 1).ToString()].Style.Border.Left.Color.SetColor(Color.Purple);
                double minimumSize = 15;
                excelWorkSheet.Cells[excelWorkSheet.Dimension.Address].AutoFitColumns(minimumSize);

                double maximumSize = 100;
                excelWorkSheet.Cells[excelWorkSheet.Dimension.Address].AutoFitColumns(minimumSize, maximumSize);
                double rowHeight = 15;
                for (int row = 1; row <= data.Count + 1; row++)
                {
                    excelWorkSheet.Row(row).Height = rowHeight;
                }

                for (int col = 1; col <= excelWorkSheet.Dimension.End.Column; col++)
                {
                    excelWorkSheet.Column(col).Width = excelWorkSheet.Column(col).Width + 1;
                }
                excelWorkSheet.Cells["A1:H" + (data.Count + 1).ToString()].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                excelWorkSheet.Cells["A1:H" + (data.Count + 1).ToString()].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                excelWorkSheet.Cells["B2:B" + (data.Count + 1).ToString()].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                excelWorkSheet.Cells["E2:E" + (data.Count + 1).ToString()].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                excelWorkSheet.Cells["A1:H" + (data.Count + 1).ToString()].Style.WrapText = true;
                excelWorkSheet.Column(7).Hidden = true;
                package.Save();
            }
            return stream;




        }

        public static Stream ExportBieuMau(List<NhanVien> data = null)
        {

            var stream = new MemoryStream();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(stream))
            {


                var excelWorkSheet = package.Workbook.Worksheets.Add("Sheet1");
                //Do du lieu
                /*sheet.Cells.LoadFromCollection(data, true);
                package.Save();*/

                excelWorkSheet.Cells["A1"].Value = "Mã Nhân Viên";

                excelWorkSheet.Cells["B1"].Value = "Họ Tên";
                excelWorkSheet.Cells["C1"].Value = "Ngày Sinh";
                excelWorkSheet.Cells["D1"].Value = "Số Điện Thoại";
                excelWorkSheet.Cells["E1"].Value = "Địa Chỉ";
                excelWorkSheet.Cells["F1"].Value = "Chức Vụ";
                excelWorkSheet.Cells["G1"].Value = "Phong Ban ID";
                excelWorkSheet.Cells["H1"].Value = "Tên Phòng Ban";
                excelWorkSheet.Cells["A2"].LoadFromCollection(data);
                /*excelWorkSheet.Cells["C2:C" + (data.Count + 1).ToString()].Style.Numberformat.Format = "dd/MM/yyyy";*/

                //set boder----------------------------------------------------------------
                excelWorkSheet.Cells["A1:H" + (data.Count + 1).ToString()].Style.Font.Size = 12;
                excelWorkSheet.Cells["A1:H1"].Style.Font.Color.SetColor(Color.White);
                excelWorkSheet.Cells["A1:H1"].Style.Font.Bold = true;
                excelWorkSheet.Cells["A1:H1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                excelWorkSheet.Cells["A1:H1"].Style.Fill.BackgroundColor.SetColor(Color.Green);

                // excelWorkSheet.Cells["A1:H1"].Style.GetT.SetColor(Color.Green);
                excelWorkSheet.Cells["A1:H1"].Style.Border.Top.Style = ExcelBorderStyle.Thick;
                excelWorkSheet.Cells["A1:H1"].Style.Border.Right.Style = ExcelBorderStyle.Thick;
                excelWorkSheet.Cells["A1:H1"].Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
                excelWorkSheet.Cells["A1:H1"].Style.Border.Left.Style = ExcelBorderStyle.Thick;
                //Set style and color------------------------------------------------------

                double minimumSize = 15;
                excelWorkSheet.Cells[excelWorkSheet.Dimension.Address].AutoFitColumns(minimumSize);

                double maximumSize = 100;
                excelWorkSheet.Cells[excelWorkSheet.Dimension.Address].AutoFitColumns(minimumSize, maximumSize);
                double rowHeight = 15;
                for (int row = 1; row <= data.Count + 1; row++)
                {
                    excelWorkSheet.Row(row).Height = rowHeight;
                }

                for (int col = 1; col <= excelWorkSheet.Dimension.End.Column; col++)
                {
                    excelWorkSheet.Column(col).Width = excelWorkSheet.Column(col).Width + 1;
                }

                excelWorkSheet.Cells["A1:H" + (data.Count + 1).ToString()].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                excelWorkSheet.Cells["A1:H" + (data.Count + 1).ToString()].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
               
                excelWorkSheet.Cells["A1:H" + (data.Count + 1).ToString()].Style.WrapText = true;
                excelWorkSheet.Column(7).Hidden = true;
                package.Save();
            }
            return stream;




        }

        public static bool checkTrungMaNhanVien(List<NhanVien> nv, string maNhanVien)
        {
            bool checkTrung = false;
            for (int j = 0; j < nv.Count; j++)
            {
                if (maNhanVien == nv[j].maNhanVien)
                {
                    checkTrung = true;
                    break;
                }

            }
            return checkTrung;
        }

        //Hàm chuyển dấu tiếng việt=======================================
        private static string[] VietNamChar = new string[]
       {
           "aAeEoOuUiIdDyY",
           "áàạảãâấầậẩẫăắằặẳẵ",
           "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
           "éèẹẻẽêếềệểễ",
           "ÉÈẸẺẼÊẾỀỆỂỄ",
           "óòọỏõôốồộổỗơớờợởỡ",
           "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
           "úùụủũưứừựửữ",
           "ÚÙỤỦŨƯỨỪỰỬỮ",
           "íìịỉĩ",
           "ÍÌỊỈĨ",
           "đ",
           "Đ",
           "ýỳỵỷỹ",
           "ÝỲỴỶỸ"
       };
        public static string ReplaceUnicode(string strInput)
        {
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                {
                    strInput = strInput.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
                }
            }
            return strInput;
        }

        //Tìm kiếm nhan vien cho map
        public static List<NhanVien> SearchMap(string key = "")
        {

            IEnumerable<NhanVien> nhanvien = null;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                if (key == null)
                {
                    nhanvien = connection.Query<NhanVien>("select* from \"Cong_Data\"");
                }
                else
                {
                    nhanvien = connection.Query<NhanVien>("select* from \"Cong_Data\" where lower(unaccent(\"hoTen\")) like '%' || lower(unaccent(@keyBox)) || '%' or lower(unaccent(\"maNhanVien\")) like '%' || lower(unaccent(@keyBox)) || '%' ", new { keyBox = key });
                }
                
            }
            return nhanvien.ToList();
        }

        public static List<NhanVien> SearchLonLat(string mnv = "")
        {

            IEnumerable<NhanVien> nhanvien = null;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                
                    nhanvien = connection.Query<NhanVien>("select* from \"Cong_Data\" where \"maNhanVien\"=@maNhanVien ", new { maNhanVien = mnv });
               

            }
            var tempList = nhanvien.ToList();
            tempList[0].ten_phong_ban = ParsePhongBan(tempList[0].phong_ban_id);
            return tempList;
        }
    }
}

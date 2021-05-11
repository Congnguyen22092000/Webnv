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
        
        public static List<NhanVien> Get(string keyPhongBan =  "",string keyBox = "")
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
                
            return tempList;
        }


        //Get id phòng ban=====================================================================================================
        public static int searchPhongBan(string temp)
        {

            int x = 0;
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

            return x;
        }
        public static bool checkPhongBan(string name)
        {
            IEnumerable<PhongBan> phongban = null;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                phongban = connection.Query<PhongBan>("SELECT * from \"phong_ban\" order by \"id\" ASC");
            }
            var tempList = phongban.ToList();   
            foreach(PhongBan pb in tempList)
            {
                if(pb.ten_phong_ban == name)
                {
                    return true;
                }
            }
            return false;
        }

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
        public static void Create(NhanVien nv)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute("insert into \"Cong_Data\"(\"maNhanVien\",\"hoTen\",\"ngaySinh\",\"soDT\",\"diaChi\",\"chucVu\",\"phong_ban_id\") values(@maNhanVien,@hoTen,@ngaySinh,@soDT,@diaChi,@chucVu,@phong_ban_id)", new { nv.maNhanVien, nv.hoTen, nv.ngaySinh, nv.soDT, nv.diaChi, nv.chucVu, nv.phong_ban_id });

            }
        }

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
                    connection.Execute("Update \"Cong_Data\" SET  \"hoTen\" = @hoTen ,\"ngaySinh\" = @ngaySinh, \"soDT\" = @soDT,\"diaChi\" = @diaChi,\"chucVu\" = @chucVu,\"phong_ban_id\" = @phong_ban_id WHERE \"maNhanVien\" = @maNhanVien", new { nv.maNhanVien, nv.hoTen, nv.ngaySinh, nv.soDT, nv.diaChi, nv.chucVu, nv.phong_ban_id });

                }
            }
            else
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    connection.Execute("insert into \"Cong_Data\"(\"maNhanVien\",\"hoTen\",\"ngaySinh\",\"soDT\",\"diaChi\",\"chucVu\",\"phong_ban_id\") values(@maNhanVien,@hoTen,@ngaySinh,@soDT,@diaChi,@chucVu,@phong_ban_id)", new { nv.maNhanVien, nv.hoTen, nv.ngaySinh, nv.soDT, nv.diaChi, nv.chucVu, nv.phong_ban_id });

                }
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

        public static void UpDateExcel(List<NhanVien> nv)
        {
            var listGoc = Get("","");
            var listMoi = nv;
            for(int i = 0; i< listMoi.Count; i++)
            {
                bool checkTrung = true;
                for(int j= 0;j < listGoc.Count; j++)
                {
                    if (listMoi[i].maNhanVien == listGoc[j].maNhanVien)
                    {
                        checkTrung= false;
                        listGoc[j] = listMoi[i];
                        break;
                    }
                    
                }
                if (checkTrung == true)
                {
                    listGoc.Add(listMoi[i]);
                }
            }
            var temp = listGoc;
            foreach(NhanVien nhanvien in listGoc)
            {
                Update(nhanvien);
            }
        }
    }
}

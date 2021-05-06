using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebNhanVien.Models;
using OfficeOpenXml;
using System.IO;

namespace WebNhanVien.Helpers
{
    public static class DBHelper
    {
        private static readonly string connectionString = "HOST=127.0.0.1;Username=postgres;Password=cong2209;Database=CongData";
        
        public static List<NhanVien> Get(string keyPhongBan =  "Tất Cả",string keyBox = "")
        {
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
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute("Update \"Cong_Data\" SET  \"hoTen\" = @hoTen ,\"ngaySinh\" = @ngaySinh, \"soDT\" = @soDT,\"diaChi\" = @diaChi,\"chucVu\" = @chucVu,\"phong_ban_id\" = @phong_ban_id WHERE \"maNhanVien\" = @maNhanVien", new { nv.maNhanVien, nv.hoTen, nv.ngaySinh, nv.soDT, nv.diaChi, nv.chucVu,nv.phong_ban_id });

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
        public static bool Export(List<NhanVien> ds = null)
        {
            FileInfo file = new FileInfo(@"wwwroot\data\cong.xlsx");
            if (file.Exists)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var excelPackage = new ExcelPackage(file))
                {
                    excelPackage.Workbook.Properties.Author = "Công";
                    excelPackage.Workbook.Properties.Title = "Staff List";
                    excelPackage.Workbook.Properties.Created = DateTime.Now;

                    var excelWorkSheet = excelPackage.Workbook.Worksheets["Sheet1"];

                    excelWorkSheet.Cells["A2"].LoadFromCollection(ds);

                   
                    excelPackage.SaveAs(file);

                }
            }
            else
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var excelPackage = new ExcelPackage())
                {
                    excelPackage.Workbook.Properties.Author = "Công";
                    excelPackage.Workbook.Properties.Title = "Staff List";
                    excelPackage.Workbook.Properties.Created = DateTime.Now;

                    var excelWorkSheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                    excelWorkSheet.Cells["A1"].LoadFromCollection(ds);
                    excelPackage.SaveAs(file);

                }
            }

            return true;
        }

    }
}

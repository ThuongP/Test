using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLSV.Models;

namespace QLSV.Controllers
{
    public class SinhVienController : Controller
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        // Phuong thuc ket noi
        private void ConnDb()
        {
            // lay chuoi ket noi
            string connStr = ConfigurationManager.ConnectionStrings["QLSVConnectionString"].ConnectionString;
            // Tao SqlConnection => truyen vao chuoi ket noi
            conn = new SqlConnection(connStr);
        }
        // GET: SinhVien
       
       
        public ActionResult Index()
        {
            return View();
        }
        QLSVDatabaseContextDataContext da = new QLSVDatabaseContextDataContext();
        public ActionResult DanhSachSV()
        {
         
            List<SinhVien> sinhViens = da.SinhViens.Select(s =>s).ToList();
            return View(sinhViens);
        }
         
        public List<SinhVien> KiemTraDiemSV()
        {
            ConnDb();
            List<SinhVien> sv = new List<SinhVien>();
            SqlDataAdapter da;
            string query = "select HoTen,kq.DiemThi from Sinhvien sv, Ketqua kq, MonHoc mh where sv.Masv = kq.Masv and mh.MaMH = kq.MaMH and mh.MaMH = 1 group by sv.Masv, HoTen,DiemThi,mh.MaMH having AVG(CAST(DiemThi as float)) > 8";
            da = new SqlDataAdapter(query, conn);
            
            return sv;
        }
        public ActionResult SapXep()
        {
            
            cmd.CommandText = "KiemTraDiemSV";
            
           
            var s = KiemTraDiemSV();
            return View(s);
        }
    }
}
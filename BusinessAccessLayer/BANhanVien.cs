using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class BANhanVien
    {
        DBQuanLyBanHangDataContext dbs = new DBQuanLyBanHangDataContext();

        public List<DANhanVien> XemDanhMucNhanVien()
        {
            var nvien =
                from nv in dbs.NhanViens
                select nv;
            List<DANhanVien> listnvien = new List<DANhanVien>();
            foreach (var kqnv in nvien)
            {
                listnvien.Add(new DANhanVien(kqnv));
            }
            return listnvien;
        }
   
        public void ThemNhanVien(string maNV,string hoLot,string ten,bool gioitinh,DateTime ngayNV,string diaChi,string dienThoai)
        {
            NhanVien nhanvien = new NhanVien()
            {
                MaNV = maNV,
                Ho  = hoLot,
                Ten = ten,
                Nu = gioitinh,
                NgayNV  = ngayNV,
                DiaChi = diaChi,
                DienThoai = dienThoai
            };
            dbs.NhanViens.InsertOnSubmit(nhanvien);
            dbs.SubmitChanges();
        }
        public void XoaNhanVien(string maNV)
        {
            NhanVien nhanvien =
               dbs.NhanViens.Single(nv => nv.MaNV == maNV);
            dbs.NhanViens.DeleteOnSubmit(nhanvien); 
            dbs.SubmitChanges();
        }
        public void CapNhatNhanVien(string maNV, string hoLot, string ten, bool gioitinh, DateTime ngayNV, string diaChi, string dienThoai)
        {
            NhanVien nhanvien =
                dbs.NhanViens.Single(nv => nv.MaNV == maNV );
           
            nhanvien.Ho = hoLot;
            nhanvien.Ten = ten;
            nhanvien.Nu = gioitinh;
            nhanvien.NgayNV = ngayNV;
            nhanvien.DiaChi = diaChi;
            nhanvien.DienThoai = dienThoai;
            dbs.SubmitChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class BAChiTietHoaDon
    {
          DBQuanLyBanHangDataContext dbs = new DBQuanLyBanHangDataContext();
        public List<DAChiTietHoaDon> XemDanhMucChiTietHoaDon()
        {
            var chitiethd =
                from cthd in dbs.ChiTietHoaDons
                select cthd;
            List<DAChiTietHoaDon> listcthd = new List<DAChiTietHoaDon>();
            foreach (var item in chitiethd)
            {
                listcthd.Add(new DAChiTietHoaDon(item));
            }
            return listcthd;
        }
        public void ThemChiTietHoaDon(string maHD, string maSP, int soLuong)
        {
            ChiTietHoaDon chitiethd = new ChiTietHoaDon()
            {
                MaHD = maHD,
                MaSP = maSP,
                SoLuong = soLuong
             
            };
            dbs.ChiTietHoaDons.InsertOnSubmit(chitiethd);
            dbs.SubmitChanges();
        }
        public void XoaChiTietHoaDon(string maHD,string maSP)
        {
            ChiTietHoaDon chitiethd =
                dbs.ChiTietHoaDons.Single(cthd => cthd.MaHD == maHD && cthd.MaSP == maSP);
            dbs.ChiTietHoaDons.DeleteOnSubmit(chitiethd);
            dbs.SubmitChanges();
        }
        public void CapNhatChiTietHoaDon(string maHD, string maSP, int soLuong)
        {
            ChiTietHoaDon chitiethd =
                dbs.ChiTietHoaDons.Single(cthd => cthd.MaHD == maHD && cthd.MaSP == maSP);

            chitiethd.SoLuong = soLuong;
            dbs.SubmitChanges();
        }
    }
    
}

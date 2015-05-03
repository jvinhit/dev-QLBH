using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class BAHoaDon
    {
        DBQuanLyBanHangDataContext dbs = new DBQuanLyBanHangDataContext();
        public List<DAHoaDon> XemDanhMucHoaDon()
        {
            List<DAHoaDon> listhd = new List<DAHoaDon>();
            var hdon = from sp in dbs.HoaDons
                       select sp;
            foreach (var kqhd in hdon)
            {
                listhd.Add(new DAHoaDon(kqhd));
            }
            return listhd;
        }
        public void ThemHoaDon(string MaHD, string MaKH, string MaNV,DateTime NgayLapHD, DateTime NgayNhanHang)
        {
            HoaDon hdon = new HoaDon()
            {
                MaHD = MaHD,
                MaKH = MaKH,
                MaNV = MaNV,
                NgayLapHD = NgayLapHD,
                NgayNhanHang = NgayNhanHang
            };

            dbs.HoaDons.InsertOnSubmit(hdon);

            dbs.SubmitChanges();

        }
        public void XoaHoaDon(string MaHD)
        {
            HoaDon hoadon =
                        dbs.HoaDons.
                        Single(hd => hd.MaHD == MaHD);

            dbs.HoaDons.DeleteOnSubmit(hoadon);

            dbs.SubmitChanges();
        }
        public void CapNhatHoaDon(string MaHD, string MaKH, string MaNV,DateTime NgayLapHD, DateTime NgayNhanHang)
        {
            HoaDon hoadon =
                    dbs.HoaDons.
                    Single(hd => hd.MaHD == MaHD);

            hoadon.MaKH = MaKH;
            hoadon.MaNV = MaNV;
            hoadon.NgayLapHD = NgayLapHD;
            hoadon.NgayNhanHang = NgayNhanHang;

            dbs.SubmitChanges();

        }

    }
}

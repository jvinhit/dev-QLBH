using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class BAKhachHang
    {
        DBQuanLyBanHangDataContext dbs = new DBQuanLyBanHangDataContext();
        public List<DAKhachHang> XemDanhMucKhachHang()
        {
            var khachhang =
                from tp in dbs.KhachHangs
                select tp;
            List<DAKhachHang> listkh = new List<DAKhachHang>();
            foreach (var item in khachhang)
            {
                listkh.Add(new DAKhachHang(item));
            }
            return listkh;
        }
        public void ThemKhachHang(string maKH, string tenCty, string diaChi, string thanhPho, string dienThoai)
        {
            KhachHang khachhang = new KhachHang()
            {
                MaKH = maKH,
                TenCty = tenCty,
                DiaChi = diaChi,
                MaThanhPho = thanhPho,
                DienThoai = dienThoai
            };
            dbs.KhachHangs.InsertOnSubmit(khachhang);
            dbs.SubmitChanges();
        }
        public void XoaKhachHang(string maKhachHang)
        {
            KhachHang khachhang =
                dbs.KhachHangs.Single(kh => kh.MaKH == maKhachHang);
            dbs.KhachHangs.DeleteOnSubmit(khachhang);
            dbs.SubmitChanges();
        }
        public void CapNhatKhachHang(string maKhachHang,string tenCty,string diaChi,string thanhPho,string dienThoai)
        {
            KhachHang khachhang =
                dbs.KhachHangs.Single(kh => kh.MaKH == maKhachHang);

            khachhang.TenCty = tenCty;
            khachhang.DiaChi = diaChi;
            khachhang.MaThanhPho = thanhPho;
            khachhang.DienThoai = dienThoai;
            dbs.SubmitChanges();
        }
    }
}

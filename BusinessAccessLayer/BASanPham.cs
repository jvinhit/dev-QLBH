using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class BASanPham
    {
        DBQuanLyBanHangDataContext dbs = new DBQuanLyBanHangDataContext();
        public List<DASanPham> XemDanhMucSanPham()
        {
            List<DASanPham> lstSP = new List<DASanPham>();
            var spham = from sp in dbs.SanPhams
                        select sp;
            foreach (var item in spham)
            {
                lstSP.Add(new DASanPham(item));
            }
            return lstSP;
        }
        public void ThemSanPham(string maSP,string tenSP,string donViTinh,float donGia,string maLoaiSP)
        {
            SanPham sanpham = new SanPham()
            {
                MaSP = maSP,
                TenSP = tenSP,
                DonViTinh = donViTinh,
                DonGia = donGia,
                MaloaiSP = maLoaiSP
            };
            dbs.SanPhams.InsertOnSubmit(sanpham);
            dbs.SubmitChanges();
        }
        public void XoaSanPham(string maSP)
        {
            SanPham sanpham =
                       dbs.SanPhams.
                       Single(sp => sp.MaSP == maSP);

            dbs.SanPhams.DeleteOnSubmit(sanpham);
            dbs.SubmitChanges();
        }
        public void CapNhatSanPham(string maSP, string tenSP, string donViTinh, float donGia, string maLoaiSP)
        {
            SanPham sanpham =
                   dbs.SanPhams.
                   Single(sp => sp.MaSP == maSP);

            sanpham.TenSP = tenSP;
            sanpham.DonViTinh = donViTinh;
            sanpham.DonGia = donGia;
            sanpham.MaloaiSP = maLoaiSP;

            dbs.SubmitChanges();
        }
    }
}

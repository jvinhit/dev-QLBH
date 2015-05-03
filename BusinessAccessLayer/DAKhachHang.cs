using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class DAKhachHang
    {
        private string maKH;
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private string tenCty;
        public string TenCty
        {
            get { return tenCty; }
            set { tenCty = value; }
        }
        private string diachi;
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private string thanhpho;
        public string ThanhPho
        {
            get { return thanhpho; }
            set { thanhpho = value; }
        }
        private string dienthoai;
        public string DienThoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        public DAKhachHang()
        {
        }
        public DAKhachHang(KhachHang kh)
        {
            MaKH = kh.MaKH;
            TenCty = kh.TenCty;
            DiaChi = kh.DiaChi;
            DienThoai = kh.DienThoai;
            ThanhPho = kh.MaThanhPho;
        }
    }
}

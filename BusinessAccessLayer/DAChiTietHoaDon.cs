using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class DAChiTietHoaDon
    {
        private string maHD;
        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
        private string maSP;
        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public DAChiTietHoaDon(ChiTietHoaDon cthd)
        {
            this.MaHD = cthd.MaHD;
            this.MaSP = cthd.MaSP;
            this.SoLuong = (int)cthd.SoLuong;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class DAHoaDon
    {
         private string maHD;
        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
        private string maKH;
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private string maNV;
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private DateTime ngayLapHD;
        public DateTime NgayLapHD
        {
            get { return ngayLapHD; }
            set { ngayLapHD = value; }
        }
        private DateTime ngayNhanHang;
        public DateTime NgayNhanHang
        {
            get { return ngayNhanHang; }
            set { ngayNhanHang = value; }
        }
        public DAHoaDon(HoaDon hd)
        {
            this.maHD = hd.MaHD;
            this.maKH = hd.MaKH;
            this.maNV = hd.MaNV;
            this.ngayLapHD = (DateTime)hd.NgayLapHD;
            this.ngayNhanHang = (DateTime)hd.NgayNhanHang;
        }
    }
}

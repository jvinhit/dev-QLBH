using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DataAccessLayer;
using System.IO;
namespace BusinessAccessLayer
{
    public class DANhanVien
    {
         private string maNV;
        public string MaNV
        {
            get {return maNV;}
            set {maNV= value;}
        }

        private string ho;
        public string Ho
        {
            get { return ho; }
            set { ho = value; }
        }
        private string ten;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private bool nu;
        public bool Nu
        {
            get { return nu; }
            set { nu = value; }
        }
        private string ngayNV;
        public string NgayNV
        {
            get { return ngayNV; }
            set { ngayNV = value; }
        }
        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string dienThoai;
        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }
        private Image hinh;
        public Image Hinh
        {
            get { return hinh; }
            set { hinh = value;}
        }
        public DANhanVien(NhanVien nv)
        {
            this.maNV = nv.MaNV;
            this.ho = nv.Ho;
            this.ten = nv.Ten;
            this.nu = nv.Nu == true ? true : false;
            this.ngayNV = nv.NgayNV.ToString();
            this.diaChi = nv.DiaChi;
            this.dienThoai = nv.DienThoai;
            this.hinh = nv.Hinh == null ? null : Image.FromStream(new MemoryStream(nv.Hinh.ToArray())); 
        }
    }
}

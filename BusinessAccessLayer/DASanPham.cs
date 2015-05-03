using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class DASanPham
    {
        private string maSP;

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        private string tenSP;

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        private string donViTinh;

        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        private float donGia;

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        private string maLoaiSP;

        public string MaLoaiSP
        {
            get { return maLoaiSP; }
            set { maLoaiSP = value; }
        }

        private string hinh2;

        public string Hinh2
        {
            get { return hinh2; }
            set { hinh2 = value; }
        }

        private Image hinh;

        public Image Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }
        public DASanPham(SanPham sp)
        {
            this.maSP = sp.MaSP;
            this.tenSP = sp.TenSP;
            this.donViTinh = sp.DonViTinh;
            this.donGia = (int)sp.DonGia;
            this.Hinh = sp.Hinh == null ? null : Image.FromStream(new MemoryStream(sp.Hinh.ToArray()));
            this.maLoaiSP = sp.MaloaiSP;
            this.hinh2 = sp.Hinh2;    
        }
    }
}

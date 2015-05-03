using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessAccessLayer;

namespace DevQuanLyBanHang
{
    public partial class XtraFormHoaDon : DevExpress.XtraEditors.XtraForm
    {
        BAHoaDon hoadon = new BAHoaDon();
        BANhanVien nhanvien = new BANhanVien();
        BAKhachHang khachhang = new BAKhachHang();
        DateTime ngaylaphd;
        DateTime ngaylapnh;
        public XtraFormHoaDon(BAHoaDon hoadon, BAKhachHang khachhang)
        {
            InitializeComponent();
            this.hoadon = hoadon;
            lookUpEditMaKH.Properties.DataSource = khachhang.XemDanhMucKhachHang();
            lookUpEditMaKH.Properties.NullText = "Chọn mã khách hàng";
            lookUpEditMaKH.Properties.DisplayMember = "MaKH";
            lookUpEditMaKH.Properties.ValueMember = "MaKH";

            lookUpEditMaNV.Properties.DataSource = nhanvien.XemDanhMucNhanVien();
            lookUpEditMaNV.Properties.NullText = "Chọn mã nhân viên";
            lookUpEditMaNV.Properties.DisplayMember = "MaNV";
            lookUpEditMaNV.Properties.ValueMember = "MaNV";
        }

        private void simpleBtnThem_Click(object sender, EventArgs e)
        {
            ngaylaphd = DateTime.Parse(txtEditNgayLapHD.Text);
            ngaylapnh = DateTime.Parse(txtEditNgayLapNH.Text);
            try
            {
                hoadon.ThemHoaDon(textEditMaHD.Text, lookUpEditMaKH.Text, lookUpEditMaNV.Text, ngaylaphd, ngaylapnh);
                MessageBox.Show("Thêm Hóa đơn thành công!!",
                    "Kết quả",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Thêm Hóa đơn thất bại!!",
                "Lỗi: " + ex.Message,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                textEditMaHD.Focus();
            }
        }

        private void simpleBtnCapNhat_Click(object sender, EventArgs e)
        {
            ngaylaphd = DateTime.Parse(txtEditNgayLapHD.Text);
            ngaylapnh = DateTime.Parse(txtEditNgayLapNH.Text);
            try
            {
                hoadon.CapNhatHoaDon(textEditMaHD.Text, lookUpEditMaKH.Text, lookUpEditMaNV.Text, ngaylaphd, ngaylapnh);
                MessageBox.Show("Cập nhật Hóa đơn thành công!!",
                    "Kết quả",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Cập nhật Hóa đơn thất bại!!",
                "Lỗi: " + ex.Message,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                textEditMaHD.Focus();
            }
        }
        

       
    }
}
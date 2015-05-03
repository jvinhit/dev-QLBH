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
    public partial class XtraFrmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BANhanVien nhanvien = new BANhanVien();
        public XtraFrmNhanVien(BANhanVien nhanvien)
        {
            InitializeComponent();
            this.nhanvien = nhanvien;
        }
        bool gtinh;
        DateTime ngaynv;
     
        private void simpleBtnThem_Click(object sender, EventArgs e)
        {
            ngaynv = DateTime.Parse(textEditNgayNV.Text);
            if (checkEditGioiTinh.Checked == true)
                gtinh = true;
            else if (checkEditGioiTinh.Checked == false)
                gtinh = false;

            try
            {
                nhanvien.ThemNhanVien(textEditMaNV.Text, textEditHo.Text, textEditTen.Text, gtinh, ngaynv, textEditDiaChi.Text, textEditDienThoai.Text);
                MessageBox.Show("Thêm Khách hàng thành công!!",
                    "Kết quả",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Thêm Khách hàng thất bại!!",
                "Lỗi: " + ex.Message,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                textEditMaNV.Focus();
            }
        }

        private void simpleBtnCapNhat_Click(object sender, EventArgs e)
        {
            ngaynv = DateTime.Parse(textEditNgayNV.Text);
            if (checkEditGioiTinh.Checked == true)
                gtinh = true;
            else if (checkEditGioiTinh.Checked == false)
                gtinh = false;
            try
            {
                nhanvien.CapNhatNhanVien(textEditMaNV.Text, textEditHo.Text, textEditTen.Text, gtinh, ngaynv, textEditDiaChi.Text, textEditDienThoai.Text);
                MessageBox.Show("Cập nhật Khách hàng thành công!!",
                    "Kết quả",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Cập nhật Khách hàng thất bại!!",
                "Lỗi: " + ex.Message,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                textEditMaNV.Focus();
            }
        }
    }
}
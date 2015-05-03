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
    public partial class XtraFrmSanPham : DevExpress.XtraEditors.XtraForm
    {
        BASanPham sanpham = new BASanPham();
        float dongia;
        public XtraFrmSanPham(BASanPham sanpham)
        {
            this.sanpham = sanpham;
            InitializeComponent();
        }

        private void simpleBtnThem_Click(object sender, EventArgs e)
        {
            dongia = float.Parse(textEditDonGia.Text);
            try
            {
                sanpham.ThemSanPham(textEditMaSP.Text, textEditTenSP.Text, txtEditDonVT.Text, dongia,textEditMaLoaiSP.Text);
                MessageBox.Show("Thêm Sản phẩm thành công!!",
                    "Kết quả",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Thêm Sản phẩm thất bại!!",
                "Lỗi: " + ex.Message,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                textEditMaSP.Focus();
            }
        }

        private void simpleBtnCapNhat_Click(object sender, EventArgs e)
        {
            dongia = float.Parse(textEditDonGia.Text);
            try
            {
                sanpham.CapNhatSanPham(textEditMaSP.Text, textEditTenSP.Text, txtEditDonVT.Text, dongia, textEditMaLoaiSP.Text);
                MessageBox.Show("Cập nhật Sản phẩm thành công!!",
                    "Kết quả",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Cập nhật Sản phẩm thất bại!!",
                "Lỗi: " + ex.Message,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                textEditMaSP.Focus();
            }
        }

     
    }
}
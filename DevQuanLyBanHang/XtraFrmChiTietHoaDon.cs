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
    public partial class XtraFrmChiTietHoaDon : DevExpress.XtraEditors.XtraForm
    {
        int soluong;
        BAHoaDon hoadon = new BAHoaDon();
        BASanPham sanpham = new BASanPham();
        BAChiTietHoaDon chitiethoadon = new BAChiTietHoaDon();
        public XtraFrmChiTietHoaDon(BAHoaDon hoadon,BAChiTietHoaDon chitiethoadon,BASanPham sanpham)
        {
            InitializeComponent();
            this.hoadon = hoadon;
            this.chitiethoadon = chitiethoadon;
            lookUpEditMaHD.Properties.DataSource = hoadon.XemDanhMucHoaDon();
            lookUpEditMaHD.Properties.NullText = "Chọn Mã hóa đơn";
            lookUpEditMaHD.Properties.DisplayMember = "MaHD";
            lookUpEditMaHD.Properties.ValueMember = "MaHD";

            lookUpEditMaSP.Properties.DataSource = sanpham.XemDanhMucSanPham();
            lookUpEditMaSP.Properties.NullText = "Chọn Mã sản phẩm";
            lookUpEditMaSP.Properties.DisplayMember = "MaSP";
            lookUpEditMaSP.Properties.ValueMember = "MaSP";

        }

        private void simpleBtnThem_Click(object sender, EventArgs e)
        {
            soluong = int.Parse(textEditSoLuong.Text);
            try
            {
                chitiethoadon.ThemChiTietHoaDon(lookUpEditMaHD.Text, lookUpEditMaSP.Text,soluong);
                MessageBox.Show("Thêm Chi tiết hóa đơn thành công!!",
                    "Kết quả",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Thêm Chi tiết hóa đơn thất bại!!",
                "Lỗi: " + ex.Message,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                
            }
        }

        private void simpleBtnCapNhat_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    chitiethoadon.(textEditMaKH.Text, textEditCty.Text, textEditDiaChi.Text, lookUpEditThanhPho.GetColumnValue("MaThanhPho").ToString(), textEditDienThoai.Text);
            //    MessageBox.Show("Cập nhật Khách hàng thành công!!",
            //        "Kết quả",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
            //    this.Close();
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show("Cập nhật Khách hàng thất bại!!",
            //    "Lỗi: " + ex.Message,
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Error);
            //    textEditMaKH.Focus();
            //}
        }

    }
}
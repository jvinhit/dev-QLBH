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
    public partial class XtraFrmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        BAKhachHang khachhang = new BAKhachHang();
        BAThanhPho thanhpho = new BAThanhPho();
        public XtraFrmKhachHang(BAKhachHang khachhang,BAThanhPho thanhpho)
        {
            InitializeComponent();
            this.thanhpho = thanhpho;
            this.khachhang = khachhang;
            lookUpEditThanhPho.Properties.DataSource = thanhpho.XemDanhMucThanhPho();
            lookUpEditThanhPho.Properties.NullText = "Chọn Thành Phố";
            lookUpEditThanhPho.Properties.DisplayMember = "TenThanhPho";
            lookUpEditThanhPho.Properties.ValueMember = "MaThanhPho";
        }

        private void simpleBtnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                khachhang.CapNhatKhachHang(textEditMaKH.Text, textEditCty.Text, textEditDiaChi.Text, lookUpEditThanhPho.GetColumnValue("MaThanhPho").ToString(), textEditDienThoai.Text);
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
                textEditMaKH.Focus();
            }
        }

        private void simpleBtnThem_Click(object sender, EventArgs e)
        {

            try
            {
                if (lookUpEditThanhPho.EditValue == null)
                {
                    MessageBox.Show("Mời bạn chọn thành phố!!!");
                    return;
                }
                khachhang.ThemKhachHang(textEditMaKH.Text, textEditCty.Text, textEditDiaChi.Text, lookUpEditThanhPho.GetColumnValue("MaThanhPho").ToString(), textEditDienThoai.Text);
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
                textEditMaKH.Focus();
            }
        }
    }
}
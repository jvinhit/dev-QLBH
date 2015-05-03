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
    public partial class XtraFrmThanhPho : DevExpress.XtraEditors.XtraForm
    {
        BAThanhPho thanhpho = new BAThanhPho();
        public XtraFrmThanhPho(BAThanhPho thanhpho)
        {
            InitializeComponent();
            this.thanhpho = thanhpho;
        }

        private void simpleBtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                thanhpho.ThemThanhPho(textEditMaTP.Text,
                    textEditTenTP.Text);
                MessageBox.Show("Thêm thành phố thành công!!",
                    "Kết quả",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();

            }
            catch
            {
                MessageBox.Show("Thêm thành phố thất bại!!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textEditTenTP.Focus();
            }

        }

        private void simpleBtnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                thanhpho.CapNhatThanhPho(textEditMaTP.Text,
                    textEditTenTP.Text);
                MessageBox.Show("Cập nhật thành phố thành công!!",
                    "Kết quả",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();

            }
            catch
            {
                MessageBox.Show("Cập nhật thành phố thất bại!!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textEditTenTP.Focus();
            }

        }

    }
}
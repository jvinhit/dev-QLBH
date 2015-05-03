using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevQuanLyBanHang
{
    public partial class XtraFormHoaDonTheoKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormHoaDonTheoKhachHang()
        {
            InitializeComponent();
        }

        private void XtraFormHoaDonTheoKhachHang_Load(object sender, EventArgs e)
        {
            string strPath = "..\\..\\CRHoaDonTheoKhachHang.rpt";
            crystalReportViewer1.ReportSource = strPath;
        }
    }
}
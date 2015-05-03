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
    public partial class XtraFormHoaDonTheoSanPham : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormHoaDonTheoSanPham()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            string strPath = "..\\..\\CRHoaDonTheoSanPham.rpt";
            crystalReportViewer1.ReportSource = strPath;
        }
    }
}
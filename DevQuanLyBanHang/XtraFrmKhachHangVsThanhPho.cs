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
    public partial class XtraFrmKhachHangVsThanhPho : DevExpress.XtraEditors.XtraForm
    {
        BAThanhPho thanhpho = new BAThanhPho();
        public XtraFrmKhachHangVsThanhPho()
        {
            InitializeComponent();
        }
     
        private void XtraFrmKhachHangVsThanhPho_Load(object sender, EventArgs e)
        {
            string strPath = "..\\..\\CR1.rpt";
            crystalReportViewer1.ReportSource = strPath;
        }

    }
}
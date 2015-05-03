using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Helpers;
using DevExpress.Printing;
using DevExpress.XtraReports.UI;
using BusinessAccessLayer;

namespace DevQuanLyBanHang
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
        }
        BAThanhPho thanhpho = new BAThanhPho();
        BAKhachHang khachhang = new BAKhachHang();
        BAHoaDon hoadon = new BAHoaDon();
        BANhanVien nhanvien = new BANhanVien();
        BASanPham sanpham = new BASanPham();
        BAChiTietHoaDon chitiethoadon = new BAChiTietHoaDon();
        DAThanhPho tp { get; set; }
        DAKhachHang kh { get; set; }
        DAHoaDon hd { get; set; }
        DANhanVien nv { get; set; }
        DASanPham sp { get; set; }
        DAChiTietHoaDon cthd { get; set; }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        public void LoadDuLieuThanhPho()
        {
            gridControl.DataSource = thanhpho.XemDanhMucThanhPho();
            gridView1.PopulateColumns();
        }
        private void barButtonXemTP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDuLieuThanhPho();
        }

        private void barButtonThemTP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFrmThanhPho frmtp = new XtraFrmThanhPho(thanhpho);
            frmtp.ShowDialog();
            LoadDuLieuThanhPho();
        }

        private void barButtonXoaTP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tp = (DAThanhPho)gridView1.Columns[0].View.GetFocusedRow();
            DialogResult tl = MessageBox.Show("Bạn có muốn xóa Thành phố \"" + tp.TenThanhPho + "\" không?",
                   "Xóa Thành phố",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                try
                {

                    thanhpho.XoaThanhPho(tp.MaThanhPho);
                    MessageBox.Show("Xóa Thành phố thành công!!",
                       "Kết quả",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    LoadDuLieuThanhPho();
                }
                catch
                {
                    MessageBox.Show("Xóa Thành phố thất bại !!",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFrmKhachHang frmkh = new XtraFrmKhachHang(khachhang,thanhpho);
            frmkh.ShowDialog();
            LoadDuLieuKhachHang();
        }
        public void LoadDuLieuKhachHang()
        {
            gridControl.DataSource = khachhang.XemDanhMucKhachHang();
            gridView1.PopulateColumns();
        }
        private void barButtonXemKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDuLieuKhachHang();
        }

        private void barButtonXoaKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kh = (DAKhachHang)gridView1.Columns[0].View.GetFocusedRow();
            DialogResult tl = MessageBox.Show("Bạn có muốn xóa Khách hàng  \"" + kh.MaKH + "\" không?",
                   "Xóa Khách hàng",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                try
                {

                    khachhang.XoaKhachHang(kh.MaKH);
                    MessageBox.Show("Xóa Khách hàng thành công!!",
                       "Kết quả",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    LoadDuLieuKhachHang();
                }
                catch
                {
                    MessageBox.Show("Xóa Khách hàng thất bại !!",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }

        private void barButtonSuaKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFrmKhachHang frmkh = new XtraFrmKhachHang(khachhang, thanhpho);
            frmkh.ShowDialog();
            LoadDuLieuKhachHang();
        }

        private void barButtonISuaTP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFrmThanhPho frmtp = new XtraFrmThanhPho(thanhpho);
            frmtp.ShowDialog();
            LoadDuLieuThanhPho();
        }
        public void LoadDanhMucHoaDon()
        {
            gridControl.DataSource = hoadon.XemDanhMucHoaDon();
            gridView1.PopulateColumns();
        }
        private void barBtnXemHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDanhMucHoaDon();
        }

        private void barBtnThemHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormHoaDon frmhd = new XtraFormHoaDon(hoadon,khachhang);
            frmhd.ShowDialog();
            LoadDanhMucHoaDon();
        }
        public void LoadDanhMucNhanVien()
        {
            gridControl.DataSource = nhanvien.XemDanhMucNhanVien();
            gridView1.PopulateColumns();
            gridView1.Columns["Hinh"].ColumnEdit = new RepositoryItemPictureEdit() { SizeMode = PictureSizeMode.Stretch };
        }

        private void barBtnXemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDanhMucNhanVien();
        }

        private void barBtnThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFrmNhanVien frmnv = new XtraFrmNhanVien(nhanvien);
            frmnv.ShowDialog();
            LoadDanhMucNhanVien();
        }

        private void barBtnXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nv = (DANhanVien)gridView1.Columns[0].View.GetFocusedRow();
            DialogResult tl = MessageBox.Show("Bạn có muốn xóa Nhân viên  \"" + nv.Ho+" "+nv.Ten + "\" không?",
                   "Xóa Nhân viên",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                try
                {

                    nhanvien.XoaNhanVien(nv.MaNV);
                    MessageBox.Show("Xóa Nhân viên thành công!!",
                       "Kết quả",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    LoadDanhMucNhanVien();
                }
                catch
                {
                    MessageBox.Show("Xóa Nhân viên thất bại !!",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }

        private void barBtnSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            XtraFrmNhanVien frmnv = new XtraFrmNhanVien(nhanvien);
            frmnv.ShowDialog();
            LoadDanhMucNhanVien();
        }

        private void barBtnXoaHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hd = (DAHoaDon)gridView1.Columns[0].View.GetFocusedRow();
            DialogResult tl = MessageBox.Show("Bạn có muốn xóa Hóa đơn  \"" + hd.MaHD +  "\" không?",
                   "Xóa Hóa đơn",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                try
                {

                    hoadon.XoaHoaDon(hd.MaHD);
                    MessageBox.Show("Xóa Hóa đơn thành công!!",
                       "Kết quả",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    LoadDanhMucHoaDon();
                }
                catch
                {
                    MessageBox.Show("Xóa Hóa đơn thất bại !!",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }

        private void barBtnSuaHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormHoaDon frmhd = new XtraFormHoaDon(hoadon,khachhang);
            frmhd.ShowDialog();
            LoadDanhMucHoaDon();
        }
        public void LoadDanhMucSanPham()
        {
            gridControl.DataSource = sanpham.XemDanhMucSanPham();
            gridView1.PopulateColumns();
            gridView1.Columns["Hinh"].ColumnEdit = new RepositoryItemPictureEdit() { SizeMode = PictureSizeMode.Stretch };
        }
        private void barBtnSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDanhMucSanPham();
        }

        private void barBtnThemSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFrmSanPham frmsp = new XtraFrmSanPham(sanpham);
            frmsp.ShowDialog();
            LoadDanhMucSanPham();
        }

        private void barBtnXoaSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sp = (DASanPham)gridView1.Columns[0].View.GetFocusedRow();
            DialogResult tl = MessageBox.Show("Bạn có muốn xóa Sản Phẩm  \"" + sp.TenSP + "\" không?",
                   "Xóa Sản phẩm",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                try
                {

                    sanpham.XoaSanPham(sp.MaSP);
                    MessageBox.Show("Xóa Sản phẩm thành công!!",
                       "Kết quả",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    LoadDanhMucSanPham();
                }
                catch
                {
                    MessageBox.Show("Xóa Sản phẩm thất bại !!",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }

        private void barBtnSuaSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFrmSanPham frmsp = new XtraFrmSanPham(sanpham);
            frmsp.ShowDialog();
            LoadDanhMucSanPham();
        }
        public void LoadDuLieuChiTietHoaDon()
        {
            gridControl.DataSource = chitiethoadon.XemDanhMucChiTietHoaDon();
            gridView1.PopulateColumns();
        }
        private void barBtnXemCTHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDuLieuChiTietHoaDon();
        }

        private void barBtnThemCTHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFrmChiTietHoaDon frmcthd = new XtraFrmChiTietHoaDon(hoadon,chitiethoadon,sanpham);
            frmcthd.ShowDialog();
            LoadDuLieuChiTietHoaDon();
        }

        private void barBtnXoaCTHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cthd = (DAChiTietHoaDon)gridView1.Columns[0].View.GetFocusedRow();
            DialogResult tl = MessageBox.Show("Bạn có muốn xóa Chi tiết hóa đơn  \"" + cthd.MaHD + "\" không?",
                   "Xóa Chi tiết hóa đơn",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                try
                {

                    chitiethoadon.XoaChiTietHoaDon(cthd.MaHD,cthd.MaSP);
                    MessageBox.Show("Xóa Chi tiết hóa đơn thành công!!",
                       "Kết quả",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    LoadDuLieuChiTietHoaDon();
                }
                catch
                {
                    MessageBox.Show("Xóa Chi tiết hóa đơn thất bại !!",
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }

        private void barBtnCapNhatCTHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFrmChiTietHoaDon frmcthd = new XtraFrmChiTietHoaDon(hoadon,chitiethoadon,sanpham);
            frmcthd.ShowDialog();
            LoadDuLieuChiTietHoaDon();
        }

        private void KhachHangTheoTP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RptKhachHangTheoThanhPho r1 = new RptKhachHangTheoThanhPho();
            ReportPrintTool in1 = new ReportPrintTool(r1);
            in1.ShowRibbonPreview();
        }

        private void calendarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RptHoaDonTheoKhachHang r1 = new RptHoaDonTheoKhachHang();
            ReportPrintTool in1 = new ReportPrintTool(r1);
            in1.ShowRibbonPreview();
        }

        private void navBarHoaDonTheoSP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RptChiTietHoaDonTheoSanPham r = new RptChiTietHoaDonTheoSanPham();
            ReportPrintTool i = new ReportPrintTool(r);
            i.ShowRibbonPreview();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RptDanhSachHoaDon hd = new RptDanhSachHoaDon();
            ReportPrintTool in1 = new ReportPrintTool(hd);
            in1.ShowRibbonPreview();
        }
    

    }
}
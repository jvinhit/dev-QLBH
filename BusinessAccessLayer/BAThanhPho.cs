using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class BAThanhPho
    {
        DBQuanLyBanHangDataContext dbs = new DBQuanLyBanHangDataContext();
        public List<DAThanhPho> XemDanhMucThanhPho()
        {
            var thanhpho =
                from tp in dbs.ThanhPhos
                select tp;
            List<DAThanhPho> listtp = new List<DAThanhPho>();
            foreach (var item in thanhpho)
            {
                listtp.Add(new DAThanhPho(item));
            }
            return listtp;
        }

        public void ThemThanhPho(string MaThanhPho, string TenThanhPho)
        {
            ThanhPho tpho = new ThanhPho()
            {
                MaThanhPho = MaThanhPho,
                TenThanhPho = TenThanhPho
            };

            dbs.ThanhPhos.InsertOnSubmit(tpho);
            dbs.SubmitChanges();
        }

        public void CapNhatThanhPho(string MaThanhPho, string TenThanhPho)
        {
            ThanhPho tpho =
                    dbs.ThanhPhos.
                    Single(tp => tp.MaThanhPho == MaThanhPho);

            tpho.TenThanhPho = TenThanhPho;

            dbs.SubmitChanges();
        }

        public void XoaThanhPho(string MaThanhPho)
        {
            ThanhPho tpho =
                    dbs.ThanhPhos.
                    Single(tp => tp.MaThanhPho == MaThanhPho);

            dbs.ThanhPhos.DeleteOnSubmit(tpho);
            dbs.SubmitChanges();
        }

    }
}

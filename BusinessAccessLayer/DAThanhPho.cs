using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class DAThanhPho
    {
        private string maTP;
        public string MaThanhPho
        {
            get { return maTP; }
            set { maTP = value; }
        }
        private string tenTP;
        public string TenThanhPho
        {
            get { return tenTP; }
            set { tenTP = value; }
        }
        public DAThanhPho()
        {
        }
        public DAThanhPho(ThanhPho tp)
        {
            this.MaThanhPho = tp.MaThanhPho;
            this.TenThanhPho = tp.TenThanhPho;
        }
    }
}

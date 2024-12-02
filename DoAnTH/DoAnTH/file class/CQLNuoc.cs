using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    class CQLNuoc
    {
        private String m_id;
        private String m_tensp;
        private String m_soluong;
        private String m_ngay;
        private string m_giatien;
        private string m_chucvu;


        //public string ID { get; set; }
        public string TenSP
        {
            get { return m_tensp; }
            set { m_tensp = value; }
        }
        public string SoLuong
        {
            get { return m_soluong; }
            set { m_soluong = value; }
        }
        public string Ngay
        {
            get { return m_ngay; }
            set { m_ngay = value; }
        }
        public string GiaTien
        {
            get { return m_giatien; }
            set { m_giatien = value; }
        }
        public string ChucVu
        {
            get { return m_chucvu; }
            set { m_chucvu = value; }
        }

        public CQLNuoc()
        {
            //  ID = "";
            this.TenSP = "";
            this.SoLuong = "";
            this.Ngay = "";
            this.GiaTien = "";
            this.ChucVu = "";

        }
        public CQLNuoc(string Id, string Tensp, string soluong, string ngay, string giatien, string chucvu)
        {
            //ID = Id;
            this.TenSP = Tensp;
            this.SoLuong = soluong;
            this.Ngay = ngay;
            this.GiaTien = giatien;
            this.ChucVu = chucvu;

        }

    }
}

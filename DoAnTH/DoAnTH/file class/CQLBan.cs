using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    class CQLBan
    {
        private string m_soban;
        private string m_trangthai;
        private DateTime m_ngaycn;

        public string SoBan
        {
            get { return m_soban; }
            set { m_soban = value; }
        }
        public string TrangThai
        {
            get { return m_trangthai; }
            set { m_trangthai = value; }
        }
        public DateTime NgayCN
        {
            get { return m_ngaycn; }
            set { m_ngaycn = value; }
        }

        public CQLBan()
        {
            //  ID = "";
            this.m_soban = "";
            this.m_trangthai = "";
            this.m_ngaycn = DateTime.Now;
        }
        public CQLBan(string soban, string trangthai, DateTime ngay)
        {
            m_soban = soban;
            m_trangthai = trangthai;
            m_ngaycn = ngay;
           
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    [Serializable]
    class COrder
    {
        private string m_id;
        private string m_tensanpham;
        private string m_topping;
        private string m_soluong;
        private string m_gia;
        private string m_hinhthuc;
        private string m_TrangThai;
        private DateTime m_ngaymua;

        public string ID
        {
            get { return m_id; }
           // set { m_id = value; }
        }
        public string TenSanPham
        {
            get { return m_tensanpham; }
            //set { m_tensanpham = value; }
        }
        public string Topping
        {
            get { return m_topping; }
          //  set { m_topping = value; }
        }
        public string SoLuong
        {
            get { return m_soluong; }
           // set { m_soluong = value; }
        }
        public string Gia
        {
            get { return m_gia; }
           // set { m_gia = value; }
        }
        public string HinhThuc
        {
            get { return m_hinhthuc; }
           // set { m_hinhthuc = value; }
        }
        public string TrangThai
        {
            get { return m_TrangThai; }
           // set { m_TrangThai = value; }
        }

        public DateTime Ngay
        {
            get { return m_ngaymua; }
            set { m_ngaymua = value; }
        }
        public COrder()
        {
            m_id = " ";
            m_tensanpham = " ";
            m_topping = " ";
            m_soluong = " ";
            m_gia = " " ;
            m_hinhthuc = " ";
            m_TrangThai = " ";
            m_ngaymua = DateTime.Now;

        }
        public COrder(string id, string tensp, string toping, string soluong, string gia, string hinhthuc, string trangthai, DateTime ngay)
        {
            m_id = id;
            m_tensanpham = tensp;
            m_topping = toping;
            m_soluong = soluong;
            m_gia = gia;
            m_hinhthuc = hinhthuc;
            m_TrangThai = trangthai;
            m_ngaymua = ngay;
        }
    }
}

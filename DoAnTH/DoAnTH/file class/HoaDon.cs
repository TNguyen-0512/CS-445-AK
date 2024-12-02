using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    public class HoaDon
    {
        private string m_id;
        private string m_tensp;
        private string m_topping;
        private double m_soluong;
        private double m_gia;
        private string m_hinhthuc;
        private string m_trangthai;
        private DateTime m_ngaymua;
        private string m_chucvu;

        public string IDHoaDon
        {
            get { return m_id; }
            set { m_id = value; }
        }
        public string tenSanPham
        {
            get { return m_tensp; }
            set { m_tensp = value; }
        }
        public string Topping
        {
            get { return m_topping; }
            set { m_topping = value; }
        }
        public double SoLuong
        {
            get { return m_soluong; }
            set { m_soluong = value; }
        }
        public double Gia
        {
            get { return m_gia; }
            set { m_gia = value; }
        }
        public string  HinhThuc
        {
            get { return m_hinhthuc; }
            set { m_hinhthuc = value; }
        }
        public string TrangThai
        {
            get { return m_trangthai; }
            set { m_trangthai = value; }
        }
        public DateTime NgayMua
        {
            get { return m_ngaymua; }
            set { m_ngaymua = value; }
        }
        public string ChucVu
        {
            get { return m_chucvu; }
            set { m_chucvu = value; }
        }

        public HoaDon()
        {
            m_id = " ";
            m_tensp = " ";
            m_topping = " ";
            m_soluong =0;
            m_gia = 0;
            m_hinhthuc = " ";
            m_trangthai = " ";
            m_ngaymua = DateTime.Now;
            this.ChucVu = "";
        }

        public HoaDon(string id, string tensp, string toping, double soluong, double gia, string hinhthuc, string trangthai, DateTime ngay, string chucvu)
        {
            m_id = id;
            m_tensp = tensp;
            m_topping = toping;
            m_soluong = soluong;
            m_gia = gia;
            m_hinhthuc = hinhthuc;
            m_trangthai = trangthai;
            m_ngaymua = ngay;
            this.ChucVu = chucvu;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    class COderView
    {
        public string ID { get; set; }
        public string TenSanPham { get; set; }
        public string Topping { get; set; }
        public string SoLuong { get; set; }
        public string Gia { get; set; }
        public string HinhThuc { get; set; }
        public string TrangThai { get; set; }
        public string Ngay { get; set; }

        public static List<COderView> getOrderview(List<COrder> ds)
        {
            List<COderView> kq = new List<COderView>();
            foreach (COrder h in ds)
            {
                COderView t = new COderView();
                t.ID = h.ID;
                t.TenSanPham = h.TenSanPham;
                t.Topping = h.Topping;
                t.SoLuong = h.SoLuong;
                t.Gia = h.Gia;
                t.HinhThuc = h.HinhThuc;
                t.TrangThai = h.TrangThai;
                t.Gia = h.Gia;
                t.Ngay = h.Ngay.ToLongTimeString();

                //t.MaLop = h.Lop.MaLop;
                //t.TenLop = h.Lop.TenLop;
                kq.Add(t);
            }
            return kq;
        }
    }
}

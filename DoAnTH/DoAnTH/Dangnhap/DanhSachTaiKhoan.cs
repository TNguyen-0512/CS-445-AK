using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;
        public static DanhSachTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance;
            }
            set => instance = value;
        }

        List<TaiKhoan> listTaiKhoan;
        public List<TaiKhoan> ListTaiKhoan
        {
            get => listTaiKhoan;
            set => listTaiKhoan = value;
        }

        DanhSachTaiKhoan()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("admin", "admin", TaiKhoan.LoaiTK.Quanli));
            listTaiKhoan.Add(new TaiKhoan("admin1", "admin1", TaiKhoan.LoaiTK.Quanli1));
            listTaiKhoan.Add(new TaiKhoan("admin2", "admin2", TaiKhoan.LoaiTK.NhanVien));
            listTaiKhoan.Add(new TaiKhoan("admin3", "admin3", TaiKhoan.LoaiTK.NhanVien1));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get => tenTaiKhoan;
            set => tenTaiKhoan = value;
        }

        private string matKhau;

        public string MatKhau
        {
            get => matKhau;
            set => matKhau = value;
        }

        public enum LoaiTK
        {
            Quanli, Quanli1, NhanVien, NhanVien1// NhaCungCap

        }

        private LoaiTK loaiTaiKhoan;

        public LoaiTK LoaiTaiKhoan
        {
            get { return loaiTaiKhoan; }
            set => loaiTaiKhoan = value;
        }


        private string tenHienThi;
        public string TenHienThi
        {
            get
            {
                switch (LoaiTaiKhoan)
                {
                    case LoaiTK.Quanli:
                        tenHienThi = "Quản Lí";
                        break;
                    case LoaiTK.Quanli1:
                        tenHienThi = "Quản Lí 1";
                        break;

                    case LoaiTK.NhanVien1:
                        tenHienThi = "Nhân Viên 1";
                        break;
                    default:
                        tenHienThi = "Nhân Viên ";
                        break;
                }
                return tenHienThi;
            }
            set => tenHienThi =value;
        }

        public TaiKhoan(string tentaikhoan, string matkhau, LoaiTK loaitaikhoan)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
            this.LoaiTaiKhoan = loaitaikhoan;
        }


    }
}

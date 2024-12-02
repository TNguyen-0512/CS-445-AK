using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    class DatMon
    {
        public double sltopping = 0;
        public int soLuong { get; set; }
        public string tenMon { get; set; }
        public DateTime ngayMua { get; set; }

        public override string ToString()
        {
            return "Số Lượng: "+sltopping + " - Món:  " + tenMon + " - Ngày: " + ngayMua.ToString("dd/MM/yyyy");
        }


    }
}

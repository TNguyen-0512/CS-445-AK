using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    class Caffee
    {

        public double soLuong = 0;
        public string tenMon { get; set; }
        public double Gia = 0;
        public override string ToString()
        {
            return soLuong + " - " + tenMon + " - " + Gia;
        }
    }
}
 
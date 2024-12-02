using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    class Caffee
    {
        public string ID { get; set; }
        public string tenMon { get; set; }
        public string Topping { get; set; }
        public double soLuong = 0;
        public double Gia = 0;
        public override string ToString()
        {

            return "ID hóa đơn: "+ ID +  " Tên món: " + tenMon +  " Topping: " 
                + Topping + " Số Lượng: " + soLuong + " Giá: " + Gia;
        }
    }
}
 
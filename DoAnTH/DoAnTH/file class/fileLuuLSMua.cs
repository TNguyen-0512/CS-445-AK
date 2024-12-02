using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DoAnTH
{
    class fileLuuLSMua
    {
        public static bool FileLuu(List<Caffee> cafe, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach (Caffee cf in cafe)
                {
                    string line = "ID: " + cf.ID + " - " + " Tên món: " + cf.tenMon + " - " + "Số Lượng: " + cf.soLuong + " - " + "Giá: " + cf.Gia;//dh.ngayMua.ToString("dd/MM/yyyy");
                    sw.WriteLine(line);
                }
                sw.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Caffee> DocFile(string parth)
        {
            List<Caffee> cafe = new List<Caffee>();
            try
            {
                StreamReader sr = new StreamReader(parth, Encoding.UTF8);
                string line = sr.ReadLine(); // đo độ dài chuỗi
                while (line != null) // khác Null thì làm 
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 4) // 4 đối tượng 
                    {
                        Caffee cf = new Caffee();
                        cf.ID =arr[1];
                        cf.tenMon = arr[1];
                        cf.soLuong = double.Parse(arr[0]);
                        cf.Gia = double.Parse(arr[0]);
                        cafe.Add(cf);
                    }
                    line = sr.ReadLine();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            return cafe;
        }
    }
}

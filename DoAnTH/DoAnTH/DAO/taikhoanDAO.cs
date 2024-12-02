using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH.DAO
{
    public class taikhoanDAO
    {
        private static taikhoanDAO instance;

        public taikhoanDAO Instance
        {
            get { if (instance == null)
                    instance = new taikhoanDAO();
                    return instance; 
                 }
          private set { instance = value; }
        }
        private taikhoanDAO() { }

        public bool Login(string taikhoan, string matkhau)
        {
            return false;

        }

    }
}

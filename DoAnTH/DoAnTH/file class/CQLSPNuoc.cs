using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTH
{
    class CQLSPNuoc
    {
        public List<CQLNuoc> Spham;

        public CQLSPNuoc()
        {
            this.Spham = new List<CQLNuoc>();
        }

        public void them(CQLNuoc ch)
        {
            this.Spham.Add(ch);
        }
        public int soLuong()
        {
            return this.Spham.Count;
        }

        //public CQLNuoc timSP(string id)
        //{
        //    foreach (CQLNuoc item in Spham)
        //        if (item.ID ==id)
        //            return item;
        //    return null;
        //}

        internal void them()
        {
            throw new NotImplementedException();
        }


    }

}

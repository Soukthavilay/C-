using _4132021.DAL;
using _4132021.DTO;
using Lucene.Net.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4132021.BLL
{
    class BLL_QLSV
    {
        private static BLL_QLSV _Instance;
        public static BLL_QLSV Instance
        {
            get
            {
                if (_Instance ==null)
                {
                    _Instance = new BLL_QLSV();
                }
                return _Instance;
            }
             set { }
        }
        public BLL_QLSV()
        {

        }
        public List<CBBItem> GetListCBBItem()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (LSH i in DAL_QLSV.Instance.GetAllLSH_DAL())
            {
                data.Add(new CBBItem { value = i.ID_lop, text = i.NameLop });
            }
            return data;
        }
        public List<SV> GetListSV_BLL(int ID_Lop)
        {
            if (ID_Lop == 0)
            {
                return DAL_QLSV.Instance.GetListSV_DAL();
            }
            else
            {
                List<SV> data = new List<SV>();
                foreach(SV i in DAL_QLSV.Instance.GetListSV_DAL())
                {
                    if(i.ID_Lop==ID_Lop)
                    {
                        data.Add(i);
                    }
                }
                return data;
            }
        }

        public SV GetSVByMSSV(string m)
        {
            SV data = new SV();
            foreach (SV i in DAL_QLSV.Instance.GetListSV_DAL())
            {
                if (i.MSSV == m)
                {
                    data = m;
                }
            }
            return data;
        }
       public void DelBLL(List<string> LMSSV)
        {
            foreach (string i in LMSSV)
            {
                DAL_QLSV.Instance.DelDAL(i);
            }
        }
    }
    
}

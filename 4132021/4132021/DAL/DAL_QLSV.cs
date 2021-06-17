using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _4132021.DTO;

namespace _4132021.DAL
{
    class DAL_QLSV
    {
        private static DAL_QLSV _Instance;
        public static DAL_QLSV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLSV();
                }
                return _Instance;
            }
             set { }
        }
        private DAL_QLSV()
        {

        }

        public List<SV> GetListSV_DAL()
        {
            List<SV> data = new List<SV>();
            string query = "select * from SV";
            foreach(DataRow i in DBhelper.Instance.GetRecord(query).Rows)
            {
                data.Add(GetSV(i));
            }
            return data;
        }
        public SV GetSV(DataRow i)
        {
            return new SV
            {
                MSSV = i["MSSV"].ToString(),
                NameSV = i["NameSV"].ToString(),
                NS = Convert.ToDateTime(i["NS"].ToString()),
                Gender = Convert.ToBoolean(i["Gender"].ToString()),
                ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString())

            };
        }
        public List<LSH> GetAllLSH_DAL()
        {
            List<LSH> data = new List<LSH>();
            string query = "select * from LopSH";
            foreach(DataRow i in DBhelper.Instance.GetRecord(query).Rows)
            {
                data.Add(GetLSH(i));
            }
            return data;
        }
        public LSH GetLSH(DataRow i)
        {
            return new LSH
            {
                ID_lop = Convert.ToInt32(i["ID_Lop"].ToString()),
                NameLop = i["NameLop"].ToString()
            };
        }
        public void AddSV_DAL(SV sv)
        {
            string query = @"Data Source=DESKTOP-H8G7SSP\SQLEXPRESS;Initial Catalog=demo;Integrated Security=True";
            DBhelper.Instance.ExecuteDB(query);
        }
        public void EditSv_DAL(SV m)
        {
            string query = "Update sv where mssv = "  + m.MSSV ;
            DBhelper.Instance.ExecuteDB(query);
        }
        public void DelDAL(string LMSSV)
        {
            string query = "Delete sv where mssv = " + LMSSV;
            DBhelper.Instance.ExecuteDB(query);
        }
        public void SortDAL()
        {

        }
    }
}

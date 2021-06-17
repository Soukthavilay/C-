using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using _4132021.DTO;

namespace _4132021.DAL
{
    class DBhelper
    {
        SqlConnection cnn;
        private static DBhelper _Instance;

        public static DBhelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string s = @"Data Source=DESKTOP-H8G7SSP\SQLEXPRESS;Initial Catalog=demo;Integrated Security=True";
                    _Instance = new DBhelper(s);
                }

                return _Instance;

            }


            private set
            {

            }
           
        }
        private DBhelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public DataTable GetRecord(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        internal void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            
        }

        internal void ExecuteDB(SV m)
        {
            
        }
    }
}
        


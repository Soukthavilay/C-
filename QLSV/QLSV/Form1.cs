using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public DataTable DB { get; set; }
        public Form1()
        {
            InitializeComponent();
            //1
            // tong dai song tae la hrng khuen ma phuea sa daeng phon  
            CreateDB();
            GetCBB();
            //1


        }
        //2
        // sarng ta ta lang doi pa kop mi "COLUMS" kub "ROW" 
        public void CreateDB()
        {
            // Tao colum cho DB (7 colums) 
            DB = new DataTable(); // 
            DB.Columns.AddRange(new DataColumn[] // colums 
            {
                new DataColumn("MSSV",typeof (String)),
                new DataColumn("Name", typeof(String)),
                new DataColumn("Lop_HP",typeof(String)),
                new DataColumn("Phone",typeof(String)),
                new DataColumn("NS",typeof(DateTime)),
                new DataColumn("Dia Chi",typeof(String)),
                new DataColumn("Gender",typeof(bool)),

            });
            // Tao row (3 row ) 
            DB.Rows.Add(new object[]
            { "102190395", 
                "Soukthavilay bouiphaphan",
                "19TCLC_DT3",
                "08830165",
                DateTime.Now, 
                "Lao",
                true });
            DB.Rows.Add(new object[] 
            { "102190396", 
                "Lita Manivong",
                "19TCLC_DT1",
                "02020215",
                DateTime.Now,
                "Lao", 
                false });
            DB.Rows.Add(new object[]
            {"102190395",
                "Vilayded phongadid",
                "19TCLC_DT3","09090984",
                DateTime.Now,
                "Vietnam",
                true });
            //2
        }


        private void button_show_Click(object sender, EventArgs e)
        {
            //3 
            // het hai poum "SHOW" khr moun thung mod nai ta ta lang "DB" khrng "CREATE DB" kharng therng
            //dtdv_SV.DataSource = DB;
            // 
            string LopHP = cbb_LHP2.SelectedItem.ToString();
            dtdv_SV.DataSource = GetSV_ByLopHP(LopHP);
            //3
        }
        //5
        // sork ha khr moun nai "DB" "ROW" dh trng kan yark hai sa daeng 
        public DataTable GetSV_ByLopHP(string txtLopHP)
        {
            DataTable data = new DataTable();
            if (txtLopHP == "ALL")
            {
                data = DB;
            }
            else
            {

            }
            // pa kard sai "DATATABLE" man trng dai perd sai "DATATABLE:" mai
         
            return data;
        }
        //4
        // tong kan hai sa daeng list khr moun pai nai Combo box 
        public void GetCBB()
        {
            if (cbb_LHP2 != null) 
            {
                cbb_LHP2.Items.Clear();
            }
            cbb_LHP2.Items.Add("All");
            //phuea br hai khr moun nai ccb sa daeng khr moun sum kun mai sai " DISTINCT() "
            cbb_LHP2.Items.AddRange(GetTenLopHocPhan().Distinct().ToArray());
        }
        public List<String> GetTenLopHocPhan()
        {
            List<string> data = new List<string> { };
            foreach (DataRow i in DB.Rows)
            {
                data.Add(i["Lop_HP"].ToString());
            }
            return data;
            //4
        }

    }
}

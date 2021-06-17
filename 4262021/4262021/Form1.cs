using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4262021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            demoEntities dm = new demoEntities();
            dataGridView1.DataSource = dm.SVs.ToList();
            // de lay cai du lieu tarm jai 
          /*  var l1 = from p in dm.SVs
                         // lopSh bi loi
                     where (p.MSSV == "101")
                     select new { p.NameSV, p.LopSH,NameSV };
            var l2 = dm.SVs.Where(p => p.MSSV == "101")
              .Select(p => new { p.NameSV,p.LopSH.NameSV });
          dataGridView1.DataSource = l2.ToList();
*/
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            /* SV sv = new SV()
             {

             };
             demoEntities dm = new demoEntities();
             dm.SVs.Add(sv);
             dm.SaveChanges();*/
            Form2 fm = new Form2();
            fm.Show();
            
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            List<string> lmssv = new List<string>();
            demoEntities dm = new demoEntities();
            foreach( string i in lmssv)
            {
                SV sv = dm.SVs.Find();
                dm.SVs.Remove(sv);
                dm.SaveChanges();
            }

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            demoEntities dm = new demoEntities();
            List<string> LMSS = new List<string>();
            string MSSV = "";
            SV ss = dm.SVs.Find(MSSV);
            var s = dm.SVs.Where(p => p.MSSV == MSSV).FirstOrDefault();
            s.NameSV = "AAA";
            dm.SaveChanges();
        }

        private void sort_btn_Click(object sender, EventArgs e)
        {
            List<SV> s = new List<SV>();
            //get list sv hien tai
            // goi ham sort

        }

        private void lopSH_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

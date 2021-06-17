using _4132021.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _4132021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void setCBB()
        {
            comboBox1.Items.Add(new CBBItem { value = 0, text = "All" });
            comboBox1.Items.AddRange(BLL_QLSV.Instance.GetListCBBItem().ToArray());
            comboBox1.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setCBB();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count >= 0)
                {
                    List<string> LMSSV = new List<string>();
                    foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                    {
                        LMSSV.Add(i.Cells["MSSV"].Value.ToString());
                    }
                    BLL_QLSV.Instance.DelBLL(LMSSV);
                }
                btn_Show.PerformClick();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            //int ID_Lop = ((CBBItem)comboBox1.SelectedItem).value;
            // dataGridView1.DataSource = BLL_QLSV.Instance.Sort();
            // (ID_Lop, textBox1.Text,) ;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            CBBItem c = (CBBItem)comboBox1.SelectedItem;
            int ID_Lop = c.value;
            BLL_QLSV bill = new BLL_QLSV();
            dataGridView1.DataSource = bill.GetListSV_BLL(ID_Lop);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}

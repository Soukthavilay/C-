using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapvenha
{
    public partial class Form1 : Form
    {
        string s = "";
        public Form1()
        {
            InitializeComponent();
        }
        List<Access> dsAccess = new List<Access>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\102190117.txt";
            dsAccess= FileFactory.DocFile(path);
            HienThiAc();
        }
        void Temp(int c)
        {
            if (s.Length < 4)
            {
                s += c + "";
                txtSecurityCode.Text = s;
            }
            else
            {
                return;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Temp(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Temp(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Temp(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Temp(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Temp(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Temp(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Temp(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Temp(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Temp(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Temp(0);
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            try { 
            int a = s.Length;
            s= s.Remove(a-1, 1);
            txtSecurityCode.Text = s;
           }
            catch (Exception ex)
            {
                MessageBox.Show("No Backspace");
            }
             
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (s.Equals("1234") == true || s.Equals("3214")==true)
            {
                Access ac = new Access();
                ac.datetime = DateTime.Now;
                ac.TinhTrang = "Secientists";
                dsAccess.Add(ac);
                HienThiAc();
            }
            else if (s.Length == 1)
            {
                Access ac = new Access();
                ac.datetime = DateTime.Now;
                ac.TinhTrang = "Restricted Access";
                dsAccess.Add(ac);
                HienThiAc();
            }
            else
            {
                Access ac = new Access();
                ac.datetime = DateTime.Now;
                ac.TinhTrang = "Access denied";
                dsAccess.Add(ac);
                HienThiAc();
            }
            string path = Application.StartupPath + "\\102190117.txt";
            bool kt = FileFactory.LuuFile(dsAccess, path);
        }
        private void HienThiAc()
        {
            lsbAccessLog.Items.Clear();
            foreach (Access ac in dsAccess)
            {
                lsbAccessLog.Items.Add(ac);
            }
        }
    }
}

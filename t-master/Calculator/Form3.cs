using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = " all| *.*| c#| *.cs* ";
            DialogResult r = f.ShowDialog();
            if (r== DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
        }
        
    }
}

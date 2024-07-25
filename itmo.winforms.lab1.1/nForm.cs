using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itmo.winforms.lab1
{
    public partial class nForm : Form
    {
        private bool nclose = false;
        public nForm()                                 
        {
            InitializeComponent();
            
        }
       

        private void nForm_Load(object sender, EventArgs e)
        {

        }

        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBox1.Checked) return;
            if (nclose) return;
            e.Cancel = true;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public new void Close() 
        { 
            nclose = true; base.Close(); 
        }
    }
}

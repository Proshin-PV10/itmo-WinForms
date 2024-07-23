using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itmo.winforms.lad5_contr_
{
    public partial class circle : Form
    {
        public circle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rombus myF2 = new rombus(); myF2.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rubber myF1 = new Rubber(); myF1.Show();
        }
    }
}

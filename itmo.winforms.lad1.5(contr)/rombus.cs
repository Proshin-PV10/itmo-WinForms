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
    public partial class rombus : Form
    {
        public rombus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rombus_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(this.Width / 2, 0),
                            new Point(this.Width, this.Height / 2),
                            new Point(this.Width / 2, this.Height),
                            new Point(0, this.Height / 2) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}

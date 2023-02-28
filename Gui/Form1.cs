using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace External_Menu.Gui
{
    public partial class Form11 : Form
    {

        public Form11()
        {                        
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            nhknoob.ForeColor= Color.FromArgb(3, 134, 254);
            KAL.ForeColor = Color.White;
            BYE.ForeColor = Color.White;
            pnlselection.Location = new Point(30, 60);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            nhknoob.ForeColor = Color.White;
            KAL.ForeColor =  Color.FromArgb(3, 134, 254);           
            BYE.ForeColor = Color.White;
            pnlselection.Location = new Point(242, 60);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            KAL.ForeColor = Color.White;
            nhknoob.ForeColor = Color.FromArgb(3, 124, 254);
            BYE.ForeColor = Color.FromArgb(3, 124, 254);
            pnlselection.Location = new Point(453, 60);
        }
    }
}

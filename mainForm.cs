using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace External_Menu
{
    public partial class mainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]         //rounded edge
        private static extern IntPtr CreateRoundRectRgn(
          int nLeftRect,
          int nTopRect,
          int nBottomRect,
          int nRightRect,
          int nWidthEllipse,
          int nHeightEllipse);

        bool mouseDown;                                                     //dragable panel
        private Point offset;


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public mainForm()
        {
            InitializeComponent();
           
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));   //dragable panel
        }

        //button click

        private void iconButton2_Click(object sender, EventArgs e)
        {
            sidepnl.BackColor = Color.DeepSkyBlue;
            sidepnl.Height = iconButton2.Height;
            sidepnl.Top = iconButton2.Top;
            openChildForm(new Gui.Form1());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }


        //close and minimized button for panel4

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //left pnl movement

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X; offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - offset.X, currentPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        // middle pnl movement

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X; offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - offset.X, currentPos.Y - offset.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        // top pnl movement

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X; offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - offset.X, currentPos.Y - offset.Y);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}

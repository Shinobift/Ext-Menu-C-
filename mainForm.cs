using External_Menu.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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
       
        private void weaponsButton2_Click(object sender, EventArgs e)
        {
            sidepnl.BackColor = Color.DeepSkyBlue;
            sidepnl.Height = weaponsButton2.Height;
            sidepnl.Top = weaponsButton2.Top;
          
            openChildForm(new Gui.Form11());
           
        }

        private void canonButton3_Click(object sender, EventArgs e)
        {
            
            sidepnl.Height = canonButton3.Height;
            sidepnl.Top = canonButton3.Top;
            openChildForm(new Gui.Canon());
        }

        private void harpoonButton4_Click(object sender, EventArgs e)
        {
            sidepnl.Height = harpoonButton4.Height;
            sidepnl.Top = harpoonButton4.Top;
            openChildForm(new Gui.Harpoon());
        }

        private void PlayersButton5_Click(object sender, EventArgs e)
        {
            sidepnl.Height = PlayersButton5.Height;
            sidepnl.Top = PlayersButton5.Top;
            openChildForm(new Gui.Visuals.Players());
        }
        private void shipsButton6_Click(object sender, EventArgs e)
        {
            sidepnl.Height= shipsButton6.Height;
            sidepnl.Top = shipsButton6.Top;
            openChildForm(new Gui.Visuals.Ships());
        }

        private void mobsButton7_Click(object sender, EventArgs e)
        {
            sidepnl.Height = mobsButton7.Height;
            sidepnl.Top = mobsButton7.Top;
            openChildForm(new Gui.Visuals.Mobs());
        }

        private void worldButton12_Click(object sender, EventArgs e)
        {
            sidepnl.Height = worldButton12.Height;
            sidepnl.Top = worldButton12.Top;
            openChildForm(new Gui.Visuals.World());
        }

        private void skinButton8_Click(object sender, EventArgs e)
        {
            sidepnl.Height = skinButton8.Height;
            sidepnl.Top = skinButton8.Top;
            openChildForm(new Gui.Misc.Skin());
        }

        private void exploitButton9_Click(object sender, EventArgs e)
        {
            sidepnl.Height = exploitButton9.Height;
            sidepnl.Top = exploitButton9.Top;
            openChildForm(new Gui.Misc.Exploit());
        }

        private void customButton10_Click(object sender, EventArgs e)
        {
            sidepnl.Height = customButton10.Height;
            sidepnl.Top = customButton10.Top;
            openChildForm(new Gui.Settings.Customize());
        }

        private void configButton11_Click(object sender, EventArgs e)
        {
            sidepnl.Height = configButton11.Height;
            sidepnl.Top = configButton11.Top;
            openChildForm(new Gui.Settings.Config());
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



        //Back button

        private System.Windows.Controls.Button previousSelectedButton;
        private void iconButton13_Click(object sender, EventArgs e)
        {
           
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



        //sidepanel events
        private void sidepnl_Paint(object sender, PaintEventArgs e)
        {
            sidepnl.SendToBack();
        }

       
    }
}

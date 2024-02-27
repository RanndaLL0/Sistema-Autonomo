using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPI
{
    public partial class Form1 : Form
    {
        public Point MouseLocation;

        public Form1()
        {
            InitializeComponent();
        }

        //Header

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Forms position

        private void MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_click (object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        
        }

    }
}

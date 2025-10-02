using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        private bool konum = false;
        private int mouseX, mouseY;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            konum = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if(konum)
            {
                button1.Left += e.X - mouseX;
                button1.Top += e.Y - mouseY;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            konum = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_363_Car_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.car_pic;
            pictureBox2.Image = Properties.Resources.map_pic;
        }

        private void themeButton_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Black)
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.Black;
            }
        }
    }
}

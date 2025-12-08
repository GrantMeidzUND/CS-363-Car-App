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
    public partial class addDriverForm : Form
    {
        public string newDriverName;
        public addDriverForm()
        {
            InitializeComponent();
        }

        private void addToDriversButton_Click(object sender, EventArgs e)
        {
            if (newDriverNameBox.Text.Equals(""))
            {
                MessageBox.Show("Must Enter a Name");
            }
            else
            {
                newDriverName = newDriverNameBox.Text;
                this.Close();
            }
        }
    }
}

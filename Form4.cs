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
    public partial class startMenu : Form
    {
        public string driverName;
        public startMenu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverName = comboBox1.Text;
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            //Application.Run(new carApp());
            carApp startApp = new carApp();
            startApp.Show();
            this.Visible = false;
        }

        private void driverButton_Click(object sender, EventArgs e)
        {
            addDriverForm newForm = new addDriverForm();
            newForm.Show();
        }
    }
}

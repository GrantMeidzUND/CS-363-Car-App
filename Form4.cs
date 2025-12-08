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
        carApp startApp = new carApp();
        public string driverName;
        public startMenu()
        {
            InitializeComponent();
        }

        private void startingDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = startApp.driverDropdown.FindString(startingDriver.Text);
            if(index != -1)
            {
                startApp.driverDropdown.SelectedIndex = index;
            }
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            //Application.Run(new carApp());
            //carApp startApp = new carApp();
            if (startingDriver.SelectedIndex == -1)
            {
                MessageBox.Show("Must Choose a Driver");
            }
            else
            {
                startApp.Show();
                this.Visible = false;
            }
        }

        private void driverButton_Click(object sender, EventArgs e)
        {
            addDriverForm newForm = new addDriverForm();
            newForm.ShowDialog();
            string newDriverName = newForm.newDriverName;
            startingDriver.Items.Add(newDriverName);
            startApp.driverDropdown.Items.Add(newDriverName);
        }
    }
}

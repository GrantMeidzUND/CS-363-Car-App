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
    public partial class controllerForm : Form
    {
        private carApp _carApp; //lets you edit the labels from main form
        int fuelLevel = 100;
        int oilLevel = 100;
        //int engineTemp = 200;
        int batteryLevel = 100;
        //int internalTemp = 75;
        //int externalTemp = 20;

        public controllerForm(carApp _carApp_)
        {
            InitializeComponent();
            _carApp = _carApp_;
        }

        //This function lowers the values of the car "stats" when drive button is clicked
        private void driveButton_Click(object sender, EventArgs e)
        {
            // if any levels below zero
            if(fuelLevel <= 0 || oilLevel <= 0 || batteryLevel <= 0)
            {
                //insert error popup
                return;
            }

            fuelLevel -= 1;
            _carApp.fuelLabel.Text = "Fuel: " + fuelLevel + "%";

            oilLevel -= 1;
            _carApp.oilLevelLabel.Text = "Oil Level: " + oilLevel + "%";

            batteryLevel -= 1;
            _carApp.batteryLabel.Text = "Battery: " + batteryLevel + "%";
        }
    }
}

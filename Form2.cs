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
        int batteryLevel = 100;

        public controllerForm(carApp _carApp_)
        {
            InitializeComponent();
            _carApp = _carApp_;
        }

        //This function lowers the values of the car "stats" when drive button is clicked
        private void driveButton_Click(object sender, EventArgs e)
        {
            if(_carApp.carON)
            {
                // if any levels below zero
                if (fuelLevel <= 0)
                {
                    MessageBox.Show("ERROR: No Fuel");
                    _carApp.vehicleErrors.Text = "No Fuel\r\n" + _carApp.vehicleErrors.Text;
                    return;
                }
                else if (oilLevel <= 0)
                {
                    MessageBox.Show("ERROR: No Oil");
                    return;
                }
                else if (batteryLevel <= 0)
                {
                    MessageBox.Show("ERROR: No Battery Charge");
                    return;
                }
                else
                {

                    fuelLevel -= 10;
                    _carApp.fuelLabel.Text = "Fuel: " + fuelLevel + "%";

                    oilLevel -= 10;
                    _carApp.oilLevelLabel.Text = "Oil Level: " + oilLevel + "%";

                    batteryLevel -= 10;
                    _carApp.batteryLabel.Text = "Battery: " + batteryLevel + "%";
                }
            }
            else
            {
                MessageBox.Show("Car Not On");
            }
        }

        private void openDoorsButton_Click(object sender, EventArgs e)
        {
            bool doorsUnlocked = _carApp.doorsUnlocked;
            if(doorsUnlocked == true)
            {
                //open doors message
                MessageBox.Show("Doors Opened");
                return;
            }
            else
            {
                //doors are locked message
                MessageBox.Show("Doors are locked");
                return;
            }
        }

        private void breakInButton_Click(object sender, EventArgs e)
        {
            bool alarmOn = _carApp.alarmON;
            if(alarmOn)
            {
                MessageBox.Show("ALERT: BREAK IN!!!!");
            }
            else
            {
                //maybe make so nothing happens
                MessageBox.Show("No alarm sounded");
            }
        }

        private void refuelButton_Click(object sender, EventArgs e)
        {
            fuelLevel = 100;
            _carApp.fuelLabel.Text = "Fuel: " + fuelLevel + "%";
            _carApp.activitiesLog.Text = DateTime.Now + "   Refueled\r\n" + _carApp.activitiesLog.Text;
        }

        private void oilChangeButton_Click(object sender, EventArgs e)
        {
            oilLevel = 100;
            _carApp.oilLevelLabel.Text = "Oil: " + oilLevel + "%";
            _carApp.activitiesLog.Text = DateTime.Now + "   Oil Changed\r\n" + _carApp.activitiesLog.Text;
        }

        private void batteryChargeButton_Click(object sender, EventArgs e)
        {
            batteryLevel = 100;
            _carApp.batteryLabel.Text = "Battery: " + batteryLevel + "%";
            _carApp.activitiesLog.Text = DateTime.Now + "   Battery Charged\r\n" + _carApp.activitiesLog.Text;

        }
    }
}

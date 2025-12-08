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
    public partial class carApp : Form
    {
        public bool doorsUnlocked;
        public bool alarmON;
        public bool carON;
        private System.Windows.Forms.Timer fuelTimer;
        public static Random random = new Random();
        public int fuelLevel;
        public int oilLevel;
        public int batteryLevel;
        public string vehicleType = "gas";
        
    
        public carApp()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.car_pic;
            pictureBox2.Image = Properties.Resources.map_pic;
            this.FormClosing += carApp_FormClosing;

            //creates and shows the controller
            controllerForm controllerForm = new controllerForm(this);
            controllerForm.Show();
            
            // Setup fuel timer
            fuelTimer = new System.Windows.Forms.Timer();
            fuelLevel = random.Next(10, 100);
            if (fuelLevel <= 25){
                fuelLabel.ForeColor = Color.Red;
            }
            fuelLabel.Text = "Fuel: " + fuelLevel + "% .";
            fuelTimer.Interval = 1000;
            fuelTimer.Tick += fuelTimer_Tick;
            fuelTimer.Start();
            


            oilLevel = random.Next(50, 100);
            oilLevelLabel.Text = "Oil Level: " + oilLevel + "% .";

            batteryLevel = random.Next(50, 100);
            batteryLabel.Text = "Battery: " + batteryLevel + "% .";
        }

        //impliments day/night theme button
        private void themeButton_Click(object sender, EventArgs e)
        {
            //night -> day
            if(this.BackColor == Color.Black)
            {
                this.BackColor = SystemColors.Control;
                vehicleDataLabel.ForeColor = Color.Black;
                engineTempLabel.ForeColor = Color.Black;
                oilLevelLabel.ForeColor = Color.Black;
                batteryLabel.ForeColor = Color.Black;
                internalTempLabel.ForeColor = Color.Black;
                externalTempLabel.ForeColor = Color.Black;
                errorsLabel.ForeColor = Color.Black;
                activitiesLabel.ForeColor = Color.Black;
                vehicleNameLabel.ForeColor = Color.Black;
                fuelLabel.ForeColor = Color.Black;
                doorsLabel.ForeColor = Color.Black;
                alarmLabel.ForeColor = Color.Black;
                windowsLabel.ForeColor = Color.Black;
                currentDriverLabel.ForeColor = Color.Black;
                activitiesLog.BackColor = Color.White;
                activitiesLog.ForeColor = Color.Black;
                startButton.ForeColor = Color.Black;
                startButton.BackColor = Color.White;
                stopButton.ForeColor = Color.Black;
                stopButton.BackColor = Color.White;
                doorLockButton.ForeColor = Color.Black;
                doorLockButton.BackColor = Color.White;
                doorUnlockButton.ForeColor = Color.Black;
                doorUnlockButton.BackColor = Color.White;
                alarmONButton.ForeColor = Color.Black;
                alarmONButton.BackColor = Color.White;
                alarmOFFButton.ForeColor = Color.Black;
                alarmOFFButton.BackColor = Color.White;
                windowsCloseButton.ForeColor = Color.Black;
                windowsCloseButton.BackColor = Color.White;
                windowsOpenButton.ForeColor = Color.Black;
                windowsOpenButton.BackColor = Color.White;
                driverButton.ForeColor = Color.Black;
                driverButton.BackColor = Color.White;
                vehicleErrors.BackColor = Color.White;
                vehicleErrors.ForeColor = Color.Black;
                updateBox.ForeColor = Color.Black;
                updateBox.BackColor = Color.White;
                gpsButton.ForeColor = Color.Black;
                gpsButton.BackColor = Color.White;
                typeDisplay.ForeColor = Color.Black;
                themeButton.ForeColor = Color.Black;
                themeButton.BackColor = Color.White;
                gasToElecButton.ForeColor = Color.Black;
                gasToElecButton.BackColor = Color.White;
                driverDropdown.ForeColor = Color.Black;
                driverDropdown.BackColor = Color.White;
            }
            //day -> night
            else
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                vehicleDataLabel.ForeColor = Color.White;
                engineTempLabel.ForeColor = Color.White;
                oilLevelLabel.ForeColor = Color.White;
                batteryLabel.ForeColor = Color.White;
                internalTempLabel.ForeColor = Color.White;
                externalTempLabel.ForeColor = Color.White;
                errorsLabel.ForeColor = Color.White;
                activitiesLabel.ForeColor = Color.White;
                vehicleNameLabel.ForeColor = Color.White;
                fuelLabel.ForeColor = Color.White;
                doorsLabel.ForeColor = Color.White;
                alarmLabel.ForeColor = Color.White;
                windowsLabel.ForeColor = Color.White;
                currentDriverLabel.ForeColor = Color.White;
                activitiesLog.BackColor = Color.Black;
                activitiesLog.ForeColor = Color.White;
                startButton.ForeColor = Color.White;
                startButton.BackColor = Color.Black;
                stopButton.ForeColor = Color.White;
                stopButton.BackColor = Color.Black;
                doorLockButton.ForeColor = Color.White;
                doorLockButton.BackColor = Color.Black;
                doorUnlockButton.ForeColor = Color.White;
                doorUnlockButton.BackColor = Color.Black;
                alarmONButton.ForeColor = Color.White;
                alarmONButton.BackColor = Color.Black;
                alarmOFFButton.ForeColor = Color.White;
                alarmOFFButton.BackColor = Color.Black;
                windowsCloseButton.ForeColor = Color.White;
                windowsCloseButton.BackColor = Color.Black;
                windowsOpenButton.ForeColor = Color.White;
                windowsOpenButton.BackColor = Color.Black;
                driverButton.ForeColor = Color.White;
                driverButton.BackColor = Color.Black;
                vehicleErrors.BackColor = Color.Black;
                vehicleErrors.ForeColor = Color.White;
                updateBox.ForeColor = Color.White;
                updateBox.BackColor = Color.Black;
                gpsButton.ForeColor = Color.White;
                gpsButton.BackColor = Color.Black;
                typeDisplay.ForeColor = Color.White;
                themeButton.ForeColor = Color.White;
                themeButton.BackColor = Color.Black;
                gasToElecButton.ForeColor = Color.White;
                gasToElecButton.BackColor = Color.Black;
                driverDropdown.ForeColor = Color.White;
                driverDropdown.BackColor = Color.Black;
            }
        }

        private void gasButton_Click(object sender, EventArgs e){
            vehicleType = "gas";
            InitializeComponent();
        }

        private void evButton_Click(object sender, EventArgs e){
            vehicleType = "ev";
            InitializeComponent();
        }
        
        private void doorUnlockButton_Click(object sender, EventArgs e)
        {
            doorsUnlocked = true;
            activitiesLog.Text = DateTime.Now + "   Doors Unlocked\r\n" + activitiesLog.Text;
        }

        private void doorLockButton_Click(object sender, EventArgs e)
        {
            doorsUnlocked = false;
            activitiesLog.Text = DateTime.Now + "   Doors Locked\r\n" + activitiesLog.Text;
        }

        private void windowsOpenButton_Click(object sender, EventArgs e)
        {
            activitiesLog.Text = DateTime.Now + "   Windows Opened\r\n" + activitiesLog.Text;
        }

        private void windowsCloseButton_Click(object sender, EventArgs e)
        {
            activitiesLog.Text = DateTime.Now + "   Windows Closed\r\n" + activitiesLog.Text;
        }

        private void alarmONButton_Click(object sender, EventArgs e)
        {
            alarmON = true;
            activitiesLog.Text = DateTime.Now + "   Alarm Activated\r\n" + activitiesLog.Text;

        }

        private void alarmOFFButton_Click(object sender, EventArgs e)
        {
            alarmON = false;
            activitiesLog.Text = DateTime.Now + "   Alarm Deactivated\r\n" + activitiesLog.Text;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(carON)
            {
                MessageBox.Show("Vehicle Already Started");
            }
            else if (fuelLevel == 0){
                vehicleErrors.Text = "Cannot start vehicle: No Fuel\r\n" + vehicleErrors.Text;
            }
            else
            {
                carON = true;
                //string oldText = activitiesLog.Text;
                activitiesLog.Text = DateTime.Now + "   Vehicle Started\r\n" + activitiesLog.Text;

            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (!carON)
            {
                MessageBox.Show("Vehicle Already Stopped");
            }
            else
            {
                carON = false;
                //string oldText = activitiesLog.Text;
                activitiesLog.Text = DateTime.Now + "   Vehicle Stopped\r\n" + activitiesLog.Text;
            }
        }

        private void fuelTimer_Tick(object sender, EventArgs e)
        {
            if (carON && fuelLevel > 0)
            {
                fuelLevel -= 1;
                fuelLabel.Text = "Fuel: " + fuelLevel + "% .";
                
                if (fuelLevel == 75 || fuelLevel == 50 || fuelLevel == 25)
                {
                    activitiesLog.Text = DateTime.Now + "   Fuel Level: " + fuelLevel + "%\r\n" + activitiesLog.Text;
                }
                else if (fuelLevel <= 0)
                {
                    fuelLevel = 0;
                    activitiesLog.Text = DateTime.Now + "   Fuel Empty!\r\n" + activitiesLog.Text;
                    carON = false;
                    activitiesLog.Text = DateTime.Now + "   Vehicle Stopped\r\n" + activitiesLog.Text;
                    vehicleErrors.Text = "Vehicle died: No Fuel\r\n" + vehicleErrors.Text;
                }
                if (fuelLevel <= 25){
                    fuelLabel.ForeColor = Color.Red;
                }
            }
        }

        private void gasToElecButton_Click(object sender, EventArgs e)
        {
            if(vehicleType == "hybrid")
            {
                vehicleType = "gas";
                typeDisplay.Text = "gas";
                engineTempLabel.Visible = true;
                oilLevelLabel.Visible = true;
                batteryLabel.Visible = true;
            }

            else if (vehicleType == "gas")
            {
                vehicleType = "ev";
                typeDisplay.Text = "ev";
                engineTempLabel.Visible = false;
                oilLevelLabel.Visible = false;
                batteryLabel.Visible = false;
            }

            else if (vehicleType == "ev")
            {
                vehicleType = "hybrid";
                typeDisplay.Text = "hybrid";
                engineTempLabel.Visible = true;
                oilLevelLabel.Visible = true;
                batteryLabel.Visible = true;
            }
        }

        private void driverButton_Click(object sender, EventArgs e)
        {
            addDriverForm newForm = new addDriverForm();
            newForm.ShowDialog();
            string newDriverName = newForm.newDriverName;
            driverDropdown.Items.Add(newDriverName);
            int index = driverDropdown.FindString(newDriverName);
            activitiesLog.Text = DateTime.Now + "   New Driver Created\r\n" + activitiesLog.Text;
            driverDropdown.SelectedIndex = index;
        }

        private void updateBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App Updated");
        }

        public void addNameToDrivers(string name)
        {
            driverDropdown.Items.Add(name);
        }

        private void carApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void driverDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            activitiesLog.Text = DateTime.Now + "   Driver Changed\r\n" + activitiesLog.Text;
        }
    }
}

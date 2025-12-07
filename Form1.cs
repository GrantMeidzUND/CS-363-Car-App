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
        public int fuelLevel = 100;
    
        public carApp()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.car_pic;
            pictureBox2.Image = Properties.Resources.map_pic;

            //creates and shows the controller
            controllerForm controllerForm = new controllerForm(this);
            controllerForm.Show();
            
            // Setup fuel timer
            fuelTimer = new System.Windows.Forms.Timer();
            fuelTimer.Interval = 100;
            fuelTimer.Tick += fuelTimer_Tick;
            fuelTimer.Start();
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

            }
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
                }
            }
        }
    }
}

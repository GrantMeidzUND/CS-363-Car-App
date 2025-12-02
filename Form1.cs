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
                vehicleDataLabel.ForeColor = Color.Black;
                engineTempLabel.ForeColor = Color.Black;
                oilLevelLabel.ForeColor = Color.Black;
                batteryLabel.ForeColor = Color.Black;
                internalTempLabel.ForeColor = Color.Black;
                externalTempLabel.ForeColor = Color.Black;
                errorsLabel.ForeColor = Color.Black;
                errorsListLabel.ForeColor = Color.Black;
                activitiesLabel.ForeColor = Color.Black;
                activitiesLogLabel.ForeColor = Color.Black;
                vehicleNameLabel.ForeColor = Color.Black;
                fuelLabel.ForeColor = Color.Black;
                doorsLabel.ForeColor = Color.Black;
                alarmLabel.ForeColor = Color.Black;
                windowsLabel.ForeColor = Color.Black;

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
            else
            {
                this.BackColor = Color.Black;
                vehicleDataLabel.ForeColor = Color.White;
                engineTempLabel.ForeColor = Color.White;
                oilLevelLabel.ForeColor = Color.White;
                batteryLabel.ForeColor = Color.White;
                internalTempLabel.ForeColor = Color.White;
                externalTempLabel.ForeColor = Color.White;
                errorsLabel.ForeColor = Color.White;
                errorsListLabel.ForeColor = Color.White;
                activitiesLabel.ForeColor = Color.White;
                activitiesLogLabel.ForeColor = Color.White;
                vehicleNameLabel.ForeColor = Color.White;
                fuelLabel.ForeColor = Color.White;
                doorsLabel.ForeColor = Color.White;
                alarmLabel.ForeColor = Color.White;
                windowsLabel.ForeColor = Color.White;

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
    }
}

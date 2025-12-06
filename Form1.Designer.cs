namespace CS_363_Car_App
{
    partial class carApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(carApp));
            this.driverButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vehicleNameLabel = new System.Windows.Forms.Label();
            this.windowsLabel = new System.Windows.Forms.Label();
            this.alarmLabel = new System.Windows.Forms.Label();
            this.doorsLabel = new System.Windows.Forms.Label();
            this.doorUnlockButton = new System.Windows.Forms.Button();
            this.doorLockButton = new System.Windows.Forms.Button();
            this.windowsOpenButton = new System.Windows.Forms.Button();
            this.windowsCloseButton = new System.Windows.Forms.Button();
            this.alarmOFFButton = new System.Windows.Forms.Button();
            this.alarmONButton = new System.Windows.Forms.Button();
            this.vehicleDataLabel = new System.Windows.Forms.Label();
            this.activitiesLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.themeButton = new System.Windows.Forms.Button();
            this.externalTempLabel = new System.Windows.Forms.Label();
            this.internalTempLabel = new System.Windows.Forms.Label();
            this.batteryLabel = new System.Windows.Forms.Label();
            this.oilLevelLabel = new System.Windows.Forms.Label();
            this.engineTempLabel = new System.Windows.Forms.Label();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.currentDriverLabel = new System.Windows.Forms.Label();
            this.activitiesLog = new System.Windows.Forms.TextBox();
            this.vehicleErrors = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // driverButton
            // 
            this.driverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.driverButton.Location = new System.Drawing.Point(12, 12);
            this.driverButton.Name = "driverButton";
            this.driverButton.Size = new System.Drawing.Size(75, 26);
            this.driverButton.TabIndex = 0;
            this.driverButton.Text = "DRIVER";
            this.driverButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = global::CS_363_Car_App.Properties.Resources.map_pic;
            this.pictureBox2.Location = new System.Drawing.Point(786, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(433, 239);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // vehicleNameLabel
            // 
            this.vehicleNameLabel.AutoSize = true;
            this.vehicleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.vehicleNameLabel.Location = new System.Drawing.Point(94, 286);
            this.vehicleNameLabel.Name = "vehicleNameLabel";
            this.vehicleNameLabel.Size = new System.Drawing.Size(269, 46);
            this.vehicleNameLabel.TabIndex = 3;
            this.vehicleNameLabel.Text = "Vehicle Name";
            // 
            // windowsLabel
            // 
            this.windowsLabel.AutoSize = true;
            this.windowsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.windowsLabel.Location = new System.Drawing.Point(5, 576);
            this.windowsLabel.Name = "windowsLabel";
            this.windowsLabel.Size = new System.Drawing.Size(165, 39);
            this.windowsLabel.TabIndex = 4;
            this.windowsLabel.Text = "Windows:";
            // 
            // alarmLabel
            // 
            this.alarmLabel.AutoSize = true;
            this.alarmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.alarmLabel.Location = new System.Drawing.Point(5, 513);
            this.alarmLabel.Name = "alarmLabel";
            this.alarmLabel.Size = new System.Drawing.Size(115, 39);
            this.alarmLabel.TabIndex = 5;
            this.alarmLabel.Text = "Alarm:";
            // 
            // doorsLabel
            // 
            this.doorsLabel.AutoSize = true;
            this.doorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.doorsLabel.Location = new System.Drawing.Point(5, 447);
            this.doorsLabel.Name = "doorsLabel";
            this.doorsLabel.Size = new System.Drawing.Size(117, 39);
            this.doorsLabel.TabIndex = 6;
            this.doorsLabel.Text = "Doors:";
            // 
            // doorUnlockButton
            // 
            this.doorUnlockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.doorUnlockButton.Location = new System.Drawing.Point(140, 455);
            this.doorUnlockButton.Name = "doorUnlockButton";
            this.doorUnlockButton.Size = new System.Drawing.Size(112, 31);
            this.doorUnlockButton.TabIndex = 7;
            this.doorUnlockButton.Text = "UNLOCK";
            this.doorUnlockButton.UseVisualStyleBackColor = true;
            this.doorUnlockButton.Click += new System.EventHandler(this.doorUnlockButton_Click);
            // 
            // doorLockButton
            // 
            this.doorLockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.doorLockButton.Location = new System.Drawing.Point(299, 455);
            this.doorLockButton.Name = "doorLockButton";
            this.doorLockButton.Size = new System.Drawing.Size(112, 31);
            this.doorLockButton.TabIndex = 8;
            this.doorLockButton.Text = "LOCK";
            this.doorLockButton.UseVisualStyleBackColor = true;
            this.doorLockButton.Click += new System.EventHandler(this.doorLockButton_Click);
            // 
            // windowsOpenButton
            // 
            this.windowsOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.windowsOpenButton.Location = new System.Drawing.Point(183, 584);
            this.windowsOpenButton.Name = "windowsOpenButton";
            this.windowsOpenButton.Size = new System.Drawing.Size(112, 31);
            this.windowsOpenButton.TabIndex = 9;
            this.windowsOpenButton.Text = "OPEN";
            this.windowsOpenButton.UseVisualStyleBackColor = true;
            this.windowsOpenButton.Click += new System.EventHandler(this.windowsOpenButton_Click);
            // 
            // windowsCloseButton
            // 
            this.windowsCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.windowsCloseButton.Location = new System.Drawing.Point(334, 584);
            this.windowsCloseButton.Name = "windowsCloseButton";
            this.windowsCloseButton.Size = new System.Drawing.Size(112, 31);
            this.windowsCloseButton.TabIndex = 10;
            this.windowsCloseButton.Text = "CLOSE";
            this.windowsCloseButton.UseVisualStyleBackColor = true;
            this.windowsCloseButton.Click += new System.EventHandler(this.windowsCloseButton_Click);
            // 
            // alarmOFFButton
            // 
            this.alarmOFFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.alarmOFFButton.Location = new System.Drawing.Point(299, 521);
            this.alarmOFFButton.Name = "alarmOFFButton";
            this.alarmOFFButton.Size = new System.Drawing.Size(112, 31);
            this.alarmOFFButton.TabIndex = 11;
            this.alarmOFFButton.Text = "OFF";
            this.alarmOFFButton.UseVisualStyleBackColor = true;
            this.alarmOFFButton.Click += new System.EventHandler(this.alarmOFFButton_Click);
            // 
            // alarmONButton
            // 
            this.alarmONButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.alarmONButton.Location = new System.Drawing.Point(140, 521);
            this.alarmONButton.Name = "alarmONButton";
            this.alarmONButton.Size = new System.Drawing.Size(112, 31);
            this.alarmONButton.TabIndex = 12;
            this.alarmONButton.Text = "ON";
            this.alarmONButton.UseVisualStyleBackColor = true;
            this.alarmONButton.Click += new System.EventHandler(this.alarmONButton_Click);
            // 
            // vehicleDataLabel
            // 
            this.vehicleDataLabel.AutoSize = true;
            this.vehicleDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleDataLabel.Location = new System.Drawing.Point(472, 44);
            this.vehicleDataLabel.Name = "vehicleDataLabel";
            this.vehicleDataLabel.Size = new System.Drawing.Size(259, 46);
            this.vehicleDataLabel.TabIndex = 13;
            this.vehicleDataLabel.Text = "Vehicle Data";
            // 
            // activitiesLabel
            // 
            this.activitiesLabel.AutoSize = true;
            this.activitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activitiesLabel.Location = new System.Drawing.Point(876, 286);
            this.activitiesLabel.Name = "activitiesLabel";
            this.activitiesLabel.Size = new System.Drawing.Size(270, 46);
            this.activitiesLabel.TabIndex = 14;
            this.activitiesLabel.Text = "Activities Log";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.startButton.Location = new System.Drawing.Point(58, 393);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 31);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.stopButton.Location = new System.Drawing.Point(286, 393);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(112, 31);
            this.stopButton.TabIndex = 16;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.fuelLabel.Location = new System.Drawing.Point(153, 345);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(151, 31);
            this.fuelLabel.TabIndex = 17;
            this.fuelLabel.Text = "Fuel: 100%";
            // 
            // themeButton
            // 
            this.themeButton.Location = new System.Drawing.Point(1144, 601);
            this.themeButton.Name = "themeButton";
            this.themeButton.Size = new System.Drawing.Size(86, 23);
            this.themeButton.TabIndex = 18;
            this.themeButton.Text = "DAY/NIGHT";
            this.themeButton.UseVisualStyleBackColor = true;
            this.themeButton.Click += new System.EventHandler(this.themeButton_Click);
            // 
            // externalTempLabel
            // 
            this.externalTempLabel.AutoSize = true;
            this.externalTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.externalTempLabel.Location = new System.Drawing.Point(481, 345);
            this.externalTempLabel.Name = "externalTempLabel";
            this.externalTempLabel.Size = new System.Drawing.Size(258, 31);
            this.externalTempLabel.TabIndex = 19;
            this.externalTempLabel.Text = "External Temp: 20 F";
            // 
            // internalTempLabel
            // 
            this.internalTempLabel.AutoSize = true;
            this.internalTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.internalTempLabel.Location = new System.Drawing.Point(481, 286);
            this.internalTempLabel.Name = "internalTempLabel";
            this.internalTempLabel.Size = new System.Drawing.Size(250, 31);
            this.internalTempLabel.TabIndex = 20;
            this.internalTempLabel.Text = "Internal Temp: 75 F";
            // 
            // batteryLabel
            // 
            this.batteryLabel.AutoSize = true;
            this.batteryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.batteryLabel.Location = new System.Drawing.Point(481, 226);
            this.batteryLabel.Name = "batteryLabel";
            this.batteryLabel.Size = new System.Drawing.Size(185, 31);
            this.batteryLabel.TabIndex = 21;
            this.batteryLabel.Text = "Battery: 100%";
            // 
            // oilLevelLabel
            // 
            this.oilLevelLabel.AutoSize = true;
            this.oilLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.oilLevelLabel.Location = new System.Drawing.Point(481, 166);
            this.oilLevelLabel.Name = "oilLevelLabel";
            this.oilLevelLabel.Size = new System.Drawing.Size(203, 31);
            this.oilLevelLabel.TabIndex = 22;
            this.oilLevelLabel.Text = "Oil Level: 100%";
            // 
            // engineTempLabel
            // 
            this.engineTempLabel.AutoSize = true;
            this.engineTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.engineTempLabel.Location = new System.Drawing.Point(481, 109);
            this.engineTempLabel.Name = "engineTempLabel";
            this.engineTempLabel.Size = new System.Drawing.Size(258, 31);
            this.engineTempLabel.TabIndex = 23;
            this.engineTempLabel.Text = "Engine Temp: 200 F";
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorsLabel.Location = new System.Drawing.Point(472, 407);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(286, 46);
            this.errorsLabel.TabIndex = 24;
            this.errorsLabel.Text = "Vehicle Errors";
            // 
            // currentDriverLabel
            // 
            this.currentDriverLabel.AutoSize = true;
            this.currentDriverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.currentDriverLabel.Location = new System.Drawing.Point(93, 17);
            this.currentDriverLabel.Name = "currentDriverLabel";
            this.currentDriverLabel.Size = new System.Drawing.Size(110, 17);
            this.currentDriverLabel.TabIndex = 27;
            this.currentDriverLabel.Text = "Currrent Driver: ";
            // 
            // activitiesLog
            // 
            this.activitiesLog.BackColor = System.Drawing.Color.White;
            this.activitiesLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.activitiesLog.Location = new System.Drawing.Point(786, 335);
            this.activitiesLog.Multiline = true;
            this.activitiesLog.Name = "activitiesLog";
            this.activitiesLog.ReadOnly = true;
            this.activitiesLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.activitiesLog.Size = new System.Drawing.Size(433, 260);
            this.activitiesLog.TabIndex = 28;
            // 
            // vehicleErrors
            // 
            this.vehicleErrors.BackColor = System.Drawing.Color.White;
            this.vehicleErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vehicleErrors.Location = new System.Drawing.Point(480, 455);
            this.vehicleErrors.Multiline = true;
            this.vehicleErrors.Name = "vehicleErrors";
            this.vehicleErrors.ReadOnly = true;
            this.vehicleErrors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.vehicleErrors.Size = new System.Drawing.Size(278, 169);
            this.vehicleErrors.TabIndex = 29;

            this.battery.AutoSize = true;
            this.battery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.battery.Location = new System.Drawing.Point(450, 200);
            this.battery.Name = "batteryLabel";
            this.battery.Size = new System.Drawing.Size(185, 31);
            this.battery.TabIndex = 21;
            this.battery.Text = "Battery: 100%";
            
            // 
            // carApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 636);
            this.Controls.Add(this.vehicleErrors);
            this.Controls.Add(this.activitiesLog);
            this.Controls.Add(this.currentDriverLabel);
            this.Controls.Add(this.errorsLabel);
            this.Controls.Add(this.engineTempLabel);
            this.Controls.Add(this.oilLevelLabel);
            this.Controls.Add(this.batteryLabel);
            this.Controls.Add(this.internalTempLabel);
            this.Controls.Add(this.externalTempLabel);
            this.Controls.Add(this.themeButton);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.activitiesLabel);
            this.Controls.Add(this.vehicleDataLabel);
            this.Controls.Add(this.alarmONButton);
            this.Controls.Add(this.alarmOFFButton);
            this.Controls.Add(this.windowsCloseButton);
            this.Controls.Add(this.windowsOpenButton);
            this.Controls.Add(this.doorLockButton);
            this.Controls.Add(this.doorUnlockButton);
            this.Controls.Add(this.doorsLabel);
            this.Controls.Add(this.alarmLabel);
            this.Controls.Add(this.windowsLabel);
            this.Controls.Add(this.vehicleNameLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.driverButton);
            this.Name = "carApp";
            this.Text = "Car_App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button driverButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label vehicleNameLabel;
        private System.Windows.Forms.Label windowsLabel;
        private System.Windows.Forms.Label alarmLabel;
        private System.Windows.Forms.Label doorsLabel;
        private System.Windows.Forms.Button doorUnlockButton;
        private System.Windows.Forms.Button doorLockButton;
        private System.Windows.Forms.Button windowsOpenButton;
        private System.Windows.Forms.Button windowsCloseButton;
        private System.Windows.Forms.Button alarmOFFButton;
        private System.Windows.Forms.Button alarmONButton;
        private System.Windows.Forms.Label vehicleDataLabel;
        private System.Windows.Forms.Label activitiesLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button themeButton;
        private System.Windows.Forms.Label errorsLabel;
        private System.Windows.Forms.Label currentDriverLabel;
        public System.Windows.Forms.Label fuelLabel;
        public System.Windows.Forms.Label externalTempLabel;
        public System.Windows.Forms.Label internalTempLabel;
        public System.Windows.Forms.Label batteryLabel;
        public System.Windows.Forms.Label oilLevelLabel;
        public System.Windows.Forms.Label engineTempLabel;
        public System.Windows.Forms.TextBox activitiesLog;
        public System.Windows.Forms.TextBox vehicleErrors;
    }
}


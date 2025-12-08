namespace CS_363_Car_App
{
    partial class startMenu
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
            this.startingDriver = new System.Windows.Forms.ComboBox();
            this.beginButton = new System.Windows.Forms.Button();
            this.driverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startingDriver
            // 
            this.startingDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startingDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.startingDriver.FormattingEnabled = true;
            this.startingDriver.Items.AddRange(new object[] {
            "Grant",
            "Carson",
            "Navy"});
            this.startingDriver.Location = new System.Drawing.Point(226, 104);
            this.startingDriver.Name = "startingDriver";
            this.startingDriver.Size = new System.Drawing.Size(307, 46);
            this.startingDriver.TabIndex = 0;
            this.startingDriver.SelectedIndexChanged += new System.EventHandler(this.startingDriver_SelectedIndexChanged);
            // 
            // beginButton
            // 
            this.beginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.beginButton.Location = new System.Drawing.Point(253, 243);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(245, 81);
            this.beginButton.TabIndex = 1;
            this.beginButton.Text = "START";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // driverButton
            // 
            this.driverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.driverButton.Location = new System.Drawing.Point(256, 190);
            this.driverButton.Name = "driverButton";
            this.driverButton.Size = new System.Drawing.Size(242, 47);
            this.driverButton.TabIndex = 2;
            this.driverButton.Text = "ADD DRIVER";
            this.driverButton.UseVisualStyleBackColor = true;
            this.driverButton.Click += new System.EventHandler(this.driverButton_Click);
            // 
            // startMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.driverButton);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.startingDriver);
            this.Name = "startMenu";
            this.Text = "Start Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button beginButton;
        public System.Windows.Forms.ComboBox startingDriver;
        private System.Windows.Forms.Button driverButton;
    }
}
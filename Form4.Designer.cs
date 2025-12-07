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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.beginButton = new System.Windows.Forms.Button();
            this.driverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Grant",
            "Carson",
            "Navy"});
            this.comboBox1.Location = new System.Drawing.Point(226, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 46);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.Controls.Add(this.comboBox1);
            this.Name = "startMenu";
            this.Text = "Start Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button beginButton;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button driverButton;
    }
}
namespace CS_363_Car_App
{
    partial class addDriverForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.newDriverNameBox = new System.Windows.Forms.TextBox();
            this.addToDriversButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // newDriverNameBox
            // 
            this.newDriverNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.newDriverNameBox.Location = new System.Drawing.Point(174, 37);
            this.newDriverNameBox.Name = "newDriverNameBox";
            this.newDriverNameBox.Size = new System.Drawing.Size(323, 45);
            this.newDriverNameBox.TabIndex = 1;
            // 
            // addToDriversButton
            // 
            this.addToDriversButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.addToDriversButton.Location = new System.Drawing.Point(218, 108);
            this.addToDriversButton.Name = "addToDriversButton";
            this.addToDriversButton.Size = new System.Drawing.Size(99, 44);
            this.addToDriversButton.TabIndex = 2;
            this.addToDriversButton.Text = "ADD";
            this.addToDriversButton.UseVisualStyleBackColor = true;
            this.addToDriversButton.Click += new System.EventHandler(this.addToDriversButton_Click);
            // 
            // addDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 215);
            this.Controls.Add(this.addToDriversButton);
            this.Controls.Add(this.newDriverNameBox);
            this.Controls.Add(this.label1);
            this.Name = "addDriverForm";
            this.Text = "Add Driver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newDriverNameBox;
        private System.Windows.Forms.Button addToDriversButton;
    }
}
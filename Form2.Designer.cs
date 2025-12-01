namespace CS_363_Car_App
{
    partial class Form2
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
            this.breakInButton = new System.Windows.Forms.Button();
            this.driveButton = new System.Windows.Forms.Button();
            this.errorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // breakInButton
            // 
            this.breakInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.breakInButton.Location = new System.Drawing.Point(12, 12);
            this.breakInButton.Name = "breakInButton";
            this.breakInButton.Size = new System.Drawing.Size(94, 35);
            this.breakInButton.TabIndex = 0;
            this.breakInButton.Text = "Break In";
            this.breakInButton.UseVisualStyleBackColor = true;
            // 
            // driveButton
            // 
            this.driveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.driveButton.Location = new System.Drawing.Point(12, 71);
            this.driveButton.Name = "driveButton";
            this.driveButton.Size = new System.Drawing.Size(94, 35);
            this.driveButton.TabIndex = 1;
            this.driveButton.Text = "Drive";
            this.driveButton.UseVisualStyleBackColor = true;
            // 
            // errorButton
            // 
            this.errorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.errorButton.Location = new System.Drawing.Point(12, 127);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(113, 35);
            this.errorButton.TabIndex = 2;
            this.errorButton.Text = "Sim Error";
            this.errorButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.errorButton);
            this.Controls.Add(this.driveButton);
            this.Controls.Add(this.breakInButton);
            this.Name = "Form2";
            this.Text = "Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button breakInButton;
        private System.Windows.Forms.Button driveButton;
        private System.Windows.Forms.Button errorButton;
    }
}
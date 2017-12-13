namespace ImgProcessing
{
    partial class Form1
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
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnGray = new System.Windows.Forms.Button();
            this.BtnLGray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(848, 50);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(553, 451);
            this.pictureBoxResult.TabIndex = 0;
            this.pictureBoxResult.TabStop = false;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(87, 50);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(553, 451);
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(87, 546);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(212, 72);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnGray
            // 
            this.BtnGray.Location = new System.Drawing.Point(848, 535);
            this.BtnGray.Name = "BtnGray";
            this.BtnGray.Size = new System.Drawing.Size(148, 83);
            this.BtnGray.TabIndex = 1;
            this.BtnGray.Text = "Gray";
            this.BtnGray.UseVisualStyleBackColor = true;
            this.BtnGray.Click += new System.EventHandler(this.BtnGray_Click);
            // 
            // BtnLGray
            // 
            this.BtnLGray.Location = new System.Drawing.Point(1013, 535);
            this.BtnLGray.Name = "BtnLGray";
            this.BtnLGray.Size = new System.Drawing.Size(148, 83);
            this.BtnLGray.TabIndex = 1;
            this.BtnLGray.Text = "Lumunoisity Gray";
            this.BtnLGray.UseVisualStyleBackColor = true;
            this.BtnLGray.Click += new System.EventHandler(this.BtnLGray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 690);
            this.Controls.Add(this.BtnLGray);
            this.Controls.Add(this.BtnGray);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.pictureBoxResult);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnGray;
        private System.Windows.Forms.Button BtnLGray;
    }
}


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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLighten = new System.Windows.Forms.Button();
            this.comboBoxLighten = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(849, 302);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(800, 600);
            this.pictureBoxResult.TabIndex = 0;
            this.pictureBoxResult.TabStop = false;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(28, 302);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(800, 600);
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(28, 941);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(212, 72);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnGray
            // 
            this.BtnGray.Location = new System.Drawing.Point(849, 988);
            this.BtnGray.Name = "BtnGray";
            this.BtnGray.Size = new System.Drawing.Size(148, 83);
            this.BtnGray.TabIndex = 1;
            this.BtnGray.Text = "Gray";
            this.BtnGray.UseVisualStyleBackColor = true;
            this.BtnGray.Click += new System.EventHandler(this.BtnGray_Click);
            // 
            // BtnLGray
            // 
            this.BtnLGray.Location = new System.Drawing.Point(1014, 988);
            this.BtnLGray.Name = "BtnLGray";
            this.BtnLGray.Size = new System.Drawing.Size(148, 83);
            this.BtnLGray.TabIndex = 1;
            this.BtnLGray.Text = "Lumunoisity Gray";
            this.BtnLGray.UseVisualStyleBackColor = true;
            this.BtnLGray.Click += new System.EventHandler(this.BtnLGray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Processing";
            // 
            // BtnLighten
            // 
            this.BtnLighten.Location = new System.Drawing.Point(849, 1087);
            this.BtnLighten.Name = "BtnLighten";
            this.BtnLighten.Size = new System.Drawing.Size(148, 83);
            this.BtnLighten.TabIndex = 3;
            this.BtnLighten.Text = "Lighten";
            this.BtnLighten.UseVisualStyleBackColor = true;
            this.BtnLighten.Click += new System.EventHandler(this.BtnLighten_Click);
            // 
            // comboBoxLighten
            // 
            this.comboBoxLighten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLighten.FormattingEnabled = true;
            this.comboBoxLighten.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7",
            "0,8",
            "0,9",
            "1"});
            this.comboBoxLighten.Location = new System.Drawing.Point(849, 1176);
            this.comboBoxLighten.Name = "comboBoxLighten";
            this.comboBoxLighten.Size = new System.Drawing.Size(148, 33);
            this.comboBoxLighten.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 1219);
            this.Controls.Add(this.comboBoxLighten);
            this.Controls.Add(this.BtnLighten);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnGray;
        private System.Windows.Forms.Button BtnLGray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLighten;
        private System.Windows.Forms.ComboBox comboBoxLighten;
    }
}


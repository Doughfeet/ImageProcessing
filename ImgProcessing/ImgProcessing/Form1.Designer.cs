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
            this.BtnDarken = new System.Windows.Forms.Button();
            this.comboBoxDarken = new System.Windows.Forms.ComboBox();
            this.BtnNegative = new System.Windows.Forms.Button();
            this.BtnBlur = new System.Windows.Forms.Button();
            this.TrackbarBlur = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarBlur)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(849, 128);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(800, 600);
            this.pictureBoxResult.TabIndex = 0;
            this.pictureBoxResult.TabStop = false;
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(28, 128);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(800, 600);
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(28, 760);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(148, 111);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnGray
            // 
            this.BtnGray.Location = new System.Drawing.Point(849, 749);
            this.BtnGray.Name = "BtnGray";
            this.BtnGray.Size = new System.Drawing.Size(148, 122);
            this.BtnGray.TabIndex = 1;
            this.BtnGray.Text = "Gray";
            this.BtnGray.UseVisualStyleBackColor = true;
            this.BtnGray.Click += new System.EventHandler(this.BtnGray_Click);
            // 
            // BtnLGray
            // 
            this.BtnLGray.Location = new System.Drawing.Point(1162, 749);
            this.BtnLGray.Name = "BtnLGray";
            this.BtnLGray.Size = new System.Drawing.Size(148, 122);
            this.BtnLGray.TabIndex = 1;
            this.BtnLGray.Text = "Lumunoisity Gray";
            this.BtnLGray.UseVisualStyleBackColor = true;
            this.BtnLGray.Click += new System.EventHandler(this.BtnLGray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Processing";
            // 
            // BtnLighten
            // 
            this.BtnLighten.Location = new System.Drawing.Point(1327, 749);
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
            "0",
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
            this.comboBoxLighten.Location = new System.Drawing.Point(1327, 838);
            this.comboBoxLighten.Name = "comboBoxLighten";
            this.comboBoxLighten.Size = new System.Drawing.Size(148, 33);
            this.comboBoxLighten.TabIndex = 4;
            this.comboBoxLighten.TextChanged += new System.EventHandler(this.comboBoxLighten_TextChanged);
            // 
            // BtnDarken
            // 
            this.BtnDarken.Location = new System.Drawing.Point(1501, 749);
            this.BtnDarken.Name = "BtnDarken";
            this.BtnDarken.Size = new System.Drawing.Size(148, 83);
            this.BtnDarken.TabIndex = 3;
            this.BtnDarken.Text = "Darken";
            this.BtnDarken.UseVisualStyleBackColor = true;
            this.BtnDarken.Click += new System.EventHandler(this.BtnDarken_Click);
            // 
            // comboBoxDarken
            // 
            this.comboBoxDarken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDarken.FormattingEnabled = true;
            this.comboBoxDarken.Items.AddRange(new object[] {
            "0",
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
            this.comboBoxDarken.Location = new System.Drawing.Point(1501, 838);
            this.comboBoxDarken.Name = "comboBoxDarken";
            this.comboBoxDarken.Size = new System.Drawing.Size(148, 33);
            this.comboBoxDarken.TabIndex = 4;
            this.comboBoxDarken.TextChanged += new System.EventHandler(this.comboBoxDarken_TextChanged);
            // 
            // BtnNegative
            // 
            this.BtnNegative.Location = new System.Drawing.Point(1003, 749);
            this.BtnNegative.Name = "BtnNegative";
            this.BtnNegative.Size = new System.Drawing.Size(148, 122);
            this.BtnNegative.TabIndex = 1;
            this.BtnNegative.Text = "Negative";
            this.BtnNegative.UseVisualStyleBackColor = true;
            this.BtnNegative.Click += new System.EventHandler(this.BtnNegative_Click);
            // 
            // BtnBlur
            // 
            this.BtnBlur.Location = new System.Drawing.Point(849, 889);
            this.BtnBlur.Name = "BtnBlur";
            this.BtnBlur.Size = new System.Drawing.Size(148, 122);
            this.BtnBlur.TabIndex = 1;
            this.BtnBlur.Text = "Blur";
            this.BtnBlur.UseVisualStyleBackColor = true;
            this.BtnBlur.Click += new System.EventHandler(this.BtnBlur_Click);
            // 
            // TrackbarBlur
            // 
            this.TrackbarBlur.Location = new System.Drawing.Point(849, 1017);
            this.TrackbarBlur.Name = "TrackbarBlur";
            this.TrackbarBlur.Size = new System.Drawing.Size(148, 90);
            this.TrackbarBlur.TabIndex = 5;
            this.TrackbarBlur.Value = 1;
            this.TrackbarBlur.Scroll += new System.EventHandler(this.UpdateBlur);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 1219);
            this.Controls.Add(this.TrackbarBlur);
            this.Controls.Add(this.comboBoxDarken);
            this.Controls.Add(this.BtnDarken);
            this.Controls.Add(this.comboBoxLighten);
            this.Controls.Add(this.BtnLighten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLGray);
            this.Controls.Add(this.BtnNegative);
            this.Controls.Add(this.BtnBlur);
            this.Controls.Add(this.BtnGray);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.pictureBoxResult);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarBlur)).EndInit();
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
        private System.Windows.Forms.Button BtnDarken;
        private System.Windows.Forms.ComboBox comboBoxDarken;
        private System.Windows.Forms.Button BtnNegative;
        private System.Windows.Forms.Button BtnBlur;
        private System.Windows.Forms.TrackBar TrackbarBlur;
    }
}


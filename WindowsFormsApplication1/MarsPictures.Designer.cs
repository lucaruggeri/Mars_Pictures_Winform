namespace MP
{
    partial class MarsPictures
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
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.txtSelectedSol = new System.Windows.Forms.Label();
            this.barSol = new System.Windows.Forms.HScrollBar();
            this.radCuriosity = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radSpirit = new System.Windows.Forms.RadioButton();
            this.radOpportunity = new System.Windows.Forms.RadioButton();
            this.btnLoadPicture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.lstPictures = new System.Windows.Forms.ListBox();
            this.txtMaxSol = new System.Windows.Forms.Label();
            this.txtMinSol = new System.Windows.Forms.Label();
            this.txtCameraInfo = new System.Windows.Forms.Label();
            this.btnChangeNasaKey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPicture
            // 
            this.picPicture.BackColor = System.Drawing.Color.Black;
            this.picPicture.Location = new System.Drawing.Point(12, 72);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(1181, 619);
            this.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPicture.TabIndex = 0;
            this.picPicture.TabStop = false;
            // 
            // txtSelectedSol
            // 
            this.txtSelectedSol.AutoSize = true;
            this.txtSelectedSol.Location = new System.Drawing.Point(538, 734);
            this.txtSelectedSol.Name = "txtSelectedSol";
            this.txtSelectedSol.Size = new System.Drawing.Size(22, 13);
            this.txtSelectedSol.TabIndex = 3;
            this.txtSelectedSol.Text = "Sol";
            // 
            // barSol
            // 
            this.barSol.Location = new System.Drawing.Point(12, 694);
            this.barSol.Name = "barSol";
            this.barSol.Size = new System.Drawing.Size(1181, 35);
            this.barSol.TabIndex = 5;
            this.barSol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.barSol_Scroll);
            this.barSol.ValueChanged += new System.EventHandler(this.barSol_ValueChanged);
            this.barSol.KeyUp += new System.Windows.Forms.KeyEventHandler(this.barSol_KeyUp);
            // 
            // radCuriosity
            // 
            this.radCuriosity.AutoSize = true;
            this.radCuriosity.Location = new System.Drawing.Point(3, 3);
            this.radCuriosity.Name = "radCuriosity";
            this.radCuriosity.Size = new System.Drawing.Size(64, 17);
            this.radCuriosity.TabIndex = 6;
            this.radCuriosity.TabStop = true;
            this.radCuriosity.Text = "Curiosity";
            this.radCuriosity.UseVisualStyleBackColor = true;
            this.radCuriosity.CheckedChanged += new System.EventHandler(this.radCuriosity_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radSpirit);
            this.panel1.Controls.Add(this.radOpportunity);
            this.panel1.Controls.Add(this.radCuriosity);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 25);
            this.panel1.TabIndex = 7;
            // 
            // radSpirit
            // 
            this.radSpirit.AutoSize = true;
            this.radSpirit.Location = new System.Drawing.Point(158, 3);
            this.radSpirit.Name = "radSpirit";
            this.radSpirit.Size = new System.Drawing.Size(48, 17);
            this.radSpirit.TabIndex = 8;
            this.radSpirit.TabStop = true;
            this.radSpirit.Text = "Spirit";
            this.radSpirit.UseVisualStyleBackColor = true;
            this.radSpirit.CheckedChanged += new System.EventHandler(this.radSpirit_CheckedChanged);
            // 
            // radOpportunity
            // 
            this.radOpportunity.AutoSize = true;
            this.radOpportunity.Location = new System.Drawing.Point(73, 3);
            this.radOpportunity.Name = "radOpportunity";
            this.radOpportunity.Size = new System.Drawing.Size(79, 17);
            this.radOpportunity.TabIndex = 7;
            this.radOpportunity.TabStop = true;
            this.radOpportunity.Text = "Opportunity";
            this.radOpportunity.UseVisualStyleBackColor = true;
            this.radOpportunity.CheckedChanged += new System.EventHandler(this.radOpportunity_CheckedChanged);
            // 
            // btnLoadPicture
            // 
            this.btnLoadPicture.Location = new System.Drawing.Point(12, 773);
            this.btnLoadPicture.Name = "btnLoadPicture";
            this.btnLoadPicture.Size = new System.Drawing.Size(1181, 53);
            this.btnLoadPicture.TabIndex = 8;
            this.btnLoadPicture.Text = "Load Picture";
            this.btnLoadPicture.UseVisualStyleBackColor = true;
            this.btnLoadPicture.Click += new System.EventHandler(this.btnLoadPicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Camera:";
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(796, 16);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(397, 21);
            this.cmbCamera.TabIndex = 11;
            this.cmbCamera.SelectedIndexChanged += new System.EventHandler(this.cmbCamera_SelectedIndexChanged);
            // 
            // lstPictures
            // 
            this.lstPictures.FormattingEnabled = true;
            this.lstPictures.Location = new System.Drawing.Point(1199, 17);
            this.lstPictures.Name = "lstPictures";
            this.lstPictures.Size = new System.Drawing.Size(133, 745);
            this.lstPictures.TabIndex = 12;
            this.lstPictures.SelectedIndexChanged += new System.EventHandler(this.lstPictures_SelectedIndexChanged);
            // 
            // txtMaxSol
            // 
            this.txtMaxSol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMaxSol.Location = new System.Drawing.Point(1065, 724);
            this.txtMaxSol.Name = "txtMaxSol";
            this.txtMaxSol.Size = new System.Drawing.Size(128, 23);
            this.txtMaxSol.TabIndex = 13;
            this.txtMaxSol.Text = "Max sol = ";
            this.txtMaxSol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMinSol
            // 
            this.txtMinSol.AutoSize = true;
            this.txtMinSol.Location = new System.Drawing.Point(12, 734);
            this.txtMinSol.Name = "txtMinSol";
            this.txtMinSol.Size = new System.Drawing.Size(52, 13);
            this.txtMinSol.TabIndex = 14;
            this.txtMinSol.Text = "Min sol = ";
            // 
            // txtCameraInfo
            // 
            this.txtCameraInfo.AutoSize = true;
            this.txtCameraInfo.Location = new System.Drawing.Point(12, 53);
            this.txtCameraInfo.Name = "txtCameraInfo";
            this.txtCameraInfo.Size = new System.Drawing.Size(35, 13);
            this.txtCameraInfo.TabIndex = 15;
            this.txtCameraInfo.Text = "label2";
            // 
            // btnChangeNasaKey
            // 
            this.btnChangeNasaKey.Location = new System.Drawing.Point(1199, 773);
            this.btnChangeNasaKey.Name = "btnChangeNasaKey";
            this.btnChangeNasaKey.Size = new System.Drawing.Size(133, 53);
            this.btnChangeNasaKey.TabIndex = 16;
            this.btnChangeNasaKey.Text = "Change your Nasa Api key";
            this.btnChangeNasaKey.UseVisualStyleBackColor = true;
            this.btnChangeNasaKey.Click += new System.EventHandler(this.btnChangeNasaKey_Click);
            // 
            // MarsPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 838);
            this.Controls.Add(this.btnChangeNasaKey);
            this.Controls.Add(this.txtCameraInfo);
            this.Controls.Add(this.txtMinSol);
            this.Controls.Add(this.txtMaxSol);
            this.Controls.Add(this.lstPictures);
            this.Controls.Add(this.cmbCamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadPicture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barSol);
            this.Controls.Add(this.txtSelectedSol);
            this.Controls.Add(this.picPicture);
            this.Name = "MarsPictures";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.Label txtSelectedSol;
        private System.Windows.Forms.HScrollBar barSol;
        private System.Windows.Forms.RadioButton radCuriosity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radSpirit;
        private System.Windows.Forms.RadioButton radOpportunity;
        private System.Windows.Forms.Button btnLoadPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.ListBox lstPictures;
        private System.Windows.Forms.Label txtMaxSol;
        private System.Windows.Forms.Label txtMinSol;
        private System.Windows.Forms.Label txtCameraInfo;
        private System.Windows.Forms.Button btnChangeNasaKey;
    }
}


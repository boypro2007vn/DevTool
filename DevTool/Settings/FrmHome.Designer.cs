namespace DevTool.Settings
{
    partial class FrmHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblGeneralSettings = new System.Windows.Forms.Label();
            this.BtnGeneralSettingsHelp = new System.Windows.Forms.Button();
            this.LblAlwayOnTop = new System.Windows.Forms.Label();
            this.ChkALONTOPCtrl = new System.Windows.Forms.CheckBox();
            this.PnlD0 = new System.Windows.Forms.Panel();
            this.TxtALONTOP = new System.Windows.Forms.TextBox();
            this.ChkALONTOPAlt = new System.Windows.Forms.CheckBox();
            this.ChkALONTOPShift = new System.Windows.Forms.CheckBox();
            this.PnlD0.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblGeneralSettings
            // 
            this.LblGeneralSettings.AutoSize = true;
            this.LblGeneralSettings.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGeneralSettings.ForeColor = System.Drawing.Color.White;
            this.LblGeneralSettings.Location = new System.Drawing.Point(38, 40);
            this.LblGeneralSettings.Name = "LblGeneralSettings";
            this.LblGeneralSettings.Size = new System.Drawing.Size(239, 34);
            this.LblGeneralSettings.TabIndex = 0;
            this.LblGeneralSettings.Text = "General Settings";
            // 
            // BtnGeneralSettingsHelp
            // 
            this.BtnGeneralSettingsHelp.BackgroundImage = global::DevTool.Properties.Resources.info_icon;
            this.BtnGeneralSettingsHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGeneralSettingsHelp.FlatAppearance.BorderSize = 0;
            this.BtnGeneralSettingsHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeneralSettingsHelp.Location = new System.Drawing.Point(283, 44);
            this.BtnGeneralSettingsHelp.Name = "BtnGeneralSettingsHelp";
            this.BtnGeneralSettingsHelp.Size = new System.Drawing.Size(37, 37);
            this.BtnGeneralSettingsHelp.TabIndex = 1;
            this.BtnGeneralSettingsHelp.UseVisualStyleBackColor = true;
            // 
            // LblAlwayOnTop
            // 
            this.LblAlwayOnTop.AutoSize = true;
            this.LblAlwayOnTop.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlwayOnTop.ForeColor = System.Drawing.Color.White;
            this.LblAlwayOnTop.Location = new System.Drawing.Point(40, 26);
            this.LblAlwayOnTop.Name = "LblAlwayOnTop";
            this.LblAlwayOnTop.Size = new System.Drawing.Size(138, 21);
            this.LblAlwayOnTop.TabIndex = 2;
            this.LblAlwayOnTop.Text = "Alway On Tops:";
            // 
            // ChkALONTOPCtrl
            // 
            this.ChkALONTOPCtrl.AutoSize = true;
            this.ChkALONTOPCtrl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkALONTOPCtrl.ForeColor = System.Drawing.Color.White;
            this.ChkALONTOPCtrl.Location = new System.Drawing.Point(44, 59);
            this.ChkALONTOPCtrl.Name = "ChkALONTOPCtrl";
            this.ChkALONTOPCtrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkALONTOPCtrl.Size = new System.Drawing.Size(61, 25);
            this.ChkALONTOPCtrl.TabIndex = 0;
            this.ChkALONTOPCtrl.Text = "Ctrl";
            this.ChkALONTOPCtrl.UseVisualStyleBackColor = true;
            // 
            // PnlD0
            // 
            this.PnlD0.Controls.Add(this.TxtALONTOP);
            this.PnlD0.Controls.Add(this.ChkALONTOPAlt);
            this.PnlD0.Controls.Add(this.ChkALONTOPShift);
            this.PnlD0.Controls.Add(this.ChkALONTOPCtrl);
            this.PnlD0.Controls.Add(this.LblAlwayOnTop);
            this.PnlD0.Location = new System.Drawing.Point(0, 108);
            this.PnlD0.Name = "PnlD0";
            this.PnlD0.Size = new System.Drawing.Size(779, 418);
            this.PnlD0.TabIndex = 4;
            // 
            // TxtALONTOP
            // 
            this.TxtALONTOP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtALONTOP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtALONTOP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtALONTOP.Location = new System.Drawing.Point(278, 59);
            this.TxtALONTOP.MaxLength = 3;
            this.TxtALONTOP.Name = "TxtALONTOP";
            this.TxtALONTOP.Size = new System.Drawing.Size(37, 21);
            this.TxtALONTOP.TabIndex = 3;
            this.TxtALONTOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtALONTOP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtALONTOP_KeyDown);
            // 
            // ChkALONTOPAlt
            // 
            this.ChkALONTOPAlt.AutoSize = true;
            this.ChkALONTOPAlt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkALONTOPAlt.ForeColor = System.Drawing.Color.White;
            this.ChkALONTOPAlt.Location = new System.Drawing.Point(201, 59);
            this.ChkALONTOPAlt.Name = "ChkALONTOPAlt";
            this.ChkALONTOPAlt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkALONTOPAlt.Size = new System.Drawing.Size(55, 25);
            this.ChkALONTOPAlt.TabIndex = 2;
            this.ChkALONTOPAlt.Text = "Alt";
            this.ChkALONTOPAlt.UseVisualStyleBackColor = true;
            // 
            // ChkALONTOPShift
            // 
            this.ChkALONTOPShift.AutoSize = true;
            this.ChkALONTOPShift.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkALONTOPShift.ForeColor = System.Drawing.Color.White;
            this.ChkALONTOPShift.Location = new System.Drawing.Point(122, 59);
            this.ChkALONTOPShift.Name = "ChkALONTOPShift";
            this.ChkALONTOPShift.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkALONTOPShift.Size = new System.Drawing.Size(65, 25);
            this.ChkALONTOPShift.TabIndex = 1;
            this.ChkALONTOPShift.Text = "Shift";
            this.ChkALONTOPShift.UseVisualStyleBackColor = true;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.BtnGeneralSettingsHelp);
            this.Controls.Add(this.LblGeneralSettings);
            this.Controls.Add(this.PnlD0);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmHome";
            this.Size = new System.Drawing.Size(779, 526);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.PnlD0.ResumeLayout(false);
            this.PnlD0.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGeneralSettings;
        private System.Windows.Forms.Button BtnGeneralSettingsHelp;
        private System.Windows.Forms.Label LblAlwayOnTop;
        private System.Windows.Forms.CheckBox ChkALONTOPCtrl;
        private System.Windows.Forms.Panel PnlD0;
        private System.Windows.Forms.CheckBox ChkALONTOPAlt;
        private System.Windows.Forms.CheckBox ChkALONTOPShift;
        private System.Windows.Forms.TextBox TxtALONTOP;
    }
}

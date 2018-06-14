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
            this.PnlD0 = new DevTool.CustomControl.CustomPanel();
            this.customCheckbox1 = new DevTool.CustomControl.CustomCheckbox();
            this.BtnDefault = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblRunAtStatup = new System.Windows.Forms.Label();
            this.TxtALONTOP = new System.Windows.Forms.TextBox();
            this.ChkALONTOPAlt = new System.Windows.Forms.CheckBox();
            this.ChkALONTOPShift = new System.Windows.Forms.CheckBox();
            this.ChkALONTOPCtrl = new System.Windows.Forms.CheckBox();
            this.LblAlwayOnTop = new System.Windows.Forms.Label();
            this.PnlHelpDetail = new DevTool.CustomControl.CustomPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTitleHelper = new System.Windows.Forms.Label();
            this.PnlD0.SuspendLayout();
            this.PnlHelpDetail.SuspendLayout();
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
            // PnlD0
            // 
            this.PnlD0.BorderColor = System.Drawing.Color.Transparent;
            this.PnlD0.Controls.Add(this.customCheckbox1);
            this.PnlD0.Controls.Add(this.BtnDefault);
            this.PnlD0.Controls.Add(this.BtnSave);
            this.PnlD0.Controls.Add(this.LblRunAtStatup);
            this.PnlD0.Controls.Add(this.TxtALONTOP);
            this.PnlD0.Controls.Add(this.ChkALONTOPAlt);
            this.PnlD0.Controls.Add(this.ChkALONTOPShift);
            this.PnlD0.Controls.Add(this.ChkALONTOPCtrl);
            this.PnlD0.Controls.Add(this.LblAlwayOnTop);
            this.PnlD0.Location = new System.Drawing.Point(0, 108);
            this.PnlD0.Name = "PnlD0";
            this.PnlD0.Size = new System.Drawing.Size(802, 400);
            this.PnlD0.TabIndex = 4;
            // 
            // customCheckbox1
            // 
            this.customCheckbox1.BorderColor = System.Drawing.Color.LightGray;
            this.customCheckbox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customCheckbox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customCheckbox1.IsOn = true;
            this.customCheckbox1.Location = new System.Drawing.Point(190, 110);
            this.customCheckbox1.Name = "customCheckbox1";
            this.customCheckbox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customCheckbox1.Size = new System.Drawing.Size(50, 27);
            this.customCheckbox1.TabIndex = 13;
            this.customCheckbox1.TextEnabled = true;
            // 
            // BtnDefault
            // 
            this.BtnDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(165)))), ((int)(((byte)(104)))));
            this.BtnDefault.FlatAppearance.BorderSize = 0;
            this.BtnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDefault.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefault.ForeColor = System.Drawing.Color.White;
            this.BtnDefault.Location = new System.Drawing.Point(179, 305);
            this.BtnDefault.Name = "BtnDefault";
            this.BtnDefault.Size = new System.Drawing.Size(99, 32);
            this.BtnDefault.TabIndex = 12;
            this.BtnDefault.Text = "Default";
            this.BtnDefault.UseVisualStyleBackColor = false;
            this.BtnDefault.Click += new System.EventHandler(this.BtnDefault_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(165)))), ((int)(((byte)(104)))));
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(44, 305);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(99, 32);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblRunAtStatup
            // 
            this.LblRunAtStatup.AutoSize = true;
            this.LblRunAtStatup.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRunAtStatup.ForeColor = System.Drawing.Color.White;
            this.LblRunAtStatup.Location = new System.Drawing.Point(40, 113);
            this.LblRunAtStatup.Name = "LblRunAtStatup";
            this.LblRunAtStatup.Size = new System.Drawing.Size(135, 21);
            this.LblRunAtStatup.TabIndex = 4;
            this.LblRunAtStatup.Text = "Run at Startup:";
            // 
            // TxtALONTOP
            // 
            this.TxtALONTOP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtALONTOP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtALONTOP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtALONTOP.Location = new System.Drawing.Point(278, 65);
            this.TxtALONTOP.MaxLength = 3;
            this.TxtALONTOP.Name = "TxtALONTOP";
            this.TxtALONTOP.Size = new System.Drawing.Size(35, 21);
            this.TxtALONTOP.TabIndex = 3;
            this.TxtALONTOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtALONTOP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtALONTOP_KeyDown);
            // 
            // ChkALONTOPAlt
            // 
            this.ChkALONTOPAlt.AutoSize = true;
            this.ChkALONTOPAlt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkALONTOPAlt.ForeColor = System.Drawing.Color.White;
            this.ChkALONTOPAlt.Location = new System.Drawing.Point(201, 65);
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
            this.ChkALONTOPShift.Location = new System.Drawing.Point(122, 65);
            this.ChkALONTOPShift.Name = "ChkALONTOPShift";
            this.ChkALONTOPShift.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkALONTOPShift.Size = new System.Drawing.Size(65, 25);
            this.ChkALONTOPShift.TabIndex = 1;
            this.ChkALONTOPShift.Text = "Shift";
            this.ChkALONTOPShift.UseVisualStyleBackColor = true;
            // 
            // ChkALONTOPCtrl
            // 
            this.ChkALONTOPCtrl.AutoSize = true;
            this.ChkALONTOPCtrl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkALONTOPCtrl.ForeColor = System.Drawing.Color.White;
            this.ChkALONTOPCtrl.Location = new System.Drawing.Point(44, 65);
            this.ChkALONTOPCtrl.Name = "ChkALONTOPCtrl";
            this.ChkALONTOPCtrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkALONTOPCtrl.Size = new System.Drawing.Size(61, 25);
            this.ChkALONTOPCtrl.TabIndex = 0;
            this.ChkALONTOPCtrl.Text = "Ctrl";
            this.ChkALONTOPCtrl.UseVisualStyleBackColor = true;
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
            // PnlHelpDetail
            // 
            this.PnlHelpDetail.BackColor = System.Drawing.Color.Indigo;
            this.PnlHelpDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(43)))), ((int)(((byte)(62)))));
            this.PnlHelpDetail.Controls.Add(this.label6);
            this.PnlHelpDetail.Controls.Add(this.label5);
            this.PnlHelpDetail.Controls.Add(this.label4);
            this.PnlHelpDetail.Controls.Add(this.LblTitleHelper);
            this.PnlHelpDetail.ForeColor = System.Drawing.Color.White;
            this.PnlHelpDetail.Location = new System.Drawing.Point(0, 0);
            this.PnlHelpDetail.Name = "PnlHelpDetail";
            this.PnlHelpDetail.Size = new System.Drawing.Size(807, 224);
            this.PnlHelpDetail.TabIndex = 14;
            this.PnlHelpDetail.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Something";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Something";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pin Window to Top with shortcut key";
            // 
            // LblTitleHelper
            // 
            this.LblTitleHelper.AutoSize = true;
            this.LblTitleHelper.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleHelper.ForeColor = System.Drawing.Color.White;
            this.LblTitleHelper.Location = new System.Drawing.Point(41, 28);
            this.LblTitleHelper.Name = "LblTitleHelper";
            this.LblTitleHelper.Size = new System.Drawing.Size(208, 30);
            this.LblTitleHelper.TabIndex = 0;
            this.LblTitleHelper.Text = "General Settings";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.PnlHelpDetail);
            this.Controls.Add(this.BtnGeneralSettingsHelp);
            this.Controls.Add(this.LblGeneralSettings);
            this.Controls.Add(this.PnlD0);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmHome";
            this.Size = new System.Drawing.Size(805, 508);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.PnlD0.ResumeLayout(false);
            this.PnlD0.PerformLayout();
            this.PnlHelpDetail.ResumeLayout(false);
            this.PnlHelpDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGeneralSettings;
        private System.Windows.Forms.Button BtnGeneralSettingsHelp;
        private System.Windows.Forms.Label LblAlwayOnTop;
        private System.Windows.Forms.CheckBox ChkALONTOPCtrl;
        private System.Windows.Forms.CheckBox ChkALONTOPAlt;
        private System.Windows.Forms.CheckBox ChkALONTOPShift;
        private System.Windows.Forms.TextBox TxtALONTOP;
        private CustomControl.CustomPanel PnlD0;
        private System.Windows.Forms.Label LblRunAtStatup;
        private System.Windows.Forms.Button BtnDefault;
        private System.Windows.Forms.Button BtnSave;
        private CustomControl.CustomCheckbox customCheckbox1;
        private CustomControl.CustomPanel PnlHelpDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTitleHelper;
    }
}

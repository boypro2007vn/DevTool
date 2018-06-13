namespace DevTool.Settings
{
    partial class FrmTranslate
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
            this.BtnTranslateSettingsHelp = new System.Windows.Forms.Button();
            this.LblTranslateSettings = new System.Windows.Forms.Label();
            this.PnlHelpDetail = new System.Windows.Forms.Panel();
            this.PnlD0 = new DevTool.CustomControl.CustomPanel();
            this.BtnDefault = new System.Windows.Forms.Button();
            this.ChkEnableTranslate = new System.Windows.Forms.CheckBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ChkCopyToClipboard = new System.Windows.Forms.CheckBox();
            this.CboOutLang = new System.Windows.Forms.ComboBox();
            this.CboInLang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAlwayOnTop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlHelpDetail.SuspendLayout();
            this.PnlD0.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTranslateSettingsHelp
            // 
            this.BtnTranslateSettingsHelp.BackgroundImage = global::DevTool.Properties.Resources.info_icon;
            this.BtnTranslateSettingsHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnTranslateSettingsHelp.FlatAppearance.BorderSize = 0;
            this.BtnTranslateSettingsHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTranslateSettingsHelp.Location = new System.Drawing.Point(283, 44);
            this.BtnTranslateSettingsHelp.Name = "BtnTranslateSettingsHelp";
            this.BtnTranslateSettingsHelp.Size = new System.Drawing.Size(37, 37);
            this.BtnTranslateSettingsHelp.TabIndex = 3;
            this.BtnTranslateSettingsHelp.UseVisualStyleBackColor = true;
            this.BtnTranslateSettingsHelp.Click += new System.EventHandler(this.BtnTranslateSettingsHelp_Click);
            // 
            // LblTranslateSettings
            // 
            this.LblTranslateSettings.AutoSize = true;
            this.LblTranslateSettings.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTranslateSettings.ForeColor = System.Drawing.Color.White;
            this.LblTranslateSettings.Location = new System.Drawing.Point(38, 40);
            this.LblTranslateSettings.Name = "LblTranslateSettings";
            this.LblTranslateSettings.Size = new System.Drawing.Size(248, 34);
            this.LblTranslateSettings.TabIndex = 2;
            this.LblTranslateSettings.Text = "Translate Settings";
            // 
            // PnlHelpDetail
            // 
            this.PnlHelpDetail.BackColor = System.Drawing.Color.Blue;
            this.PnlHelpDetail.Controls.Add(this.label6);
            this.PnlHelpDetail.Controls.Add(this.label5);
            this.PnlHelpDetail.Controls.Add(this.label4);
            this.PnlHelpDetail.Controls.Add(this.label3);
            this.PnlHelpDetail.Location = new System.Drawing.Point(3, 0);
            this.PnlHelpDetail.Name = "PnlHelpDetail";
            this.PnlHelpDetail.Size = new System.Drawing.Size(794, 224);
            this.PnlHelpDetail.TabIndex = 6;
            this.PnlHelpDetail.Visible = false;
            this.PnlHelpDetail.Click += new System.EventHandler(this.PnlD0_Click);
            // 
            // PnlD0
            // 
            this.PnlD0.BorderColor = System.Drawing.Color.Transparent;
            this.PnlD0.Controls.Add(this.BtnDefault);
            this.PnlD0.Controls.Add(this.ChkEnableTranslate);
            this.PnlD0.Controls.Add(this.BtnSave);
            this.PnlD0.Controls.Add(this.ChkCopyToClipboard);
            this.PnlD0.Controls.Add(this.CboOutLang);
            this.PnlD0.Controls.Add(this.CboInLang);
            this.PnlD0.Controls.Add(this.label2);
            this.PnlD0.Controls.Add(this.label1);
            this.PnlD0.Controls.Add(this.LblAlwayOnTop);
            this.PnlD0.ForeColor = System.Drawing.Color.White;
            this.PnlD0.Location = new System.Drawing.Point(0, 108);
            this.PnlD0.Name = "PnlD0";
            this.PnlD0.Size = new System.Drawing.Size(800, 400);
            this.PnlD0.TabIndex = 5;
            this.PnlD0.Click += new System.EventHandler(this.PnlD0_Click);
            // 
            // BtnDefault
            // 
            this.BtnDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(165)))), ((int)(((byte)(104)))));
            this.BtnDefault.FlatAppearance.BorderSize = 0;
            this.BtnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDefault.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefault.Location = new System.Drawing.Point(179, 305);
            this.BtnDefault.Name = "BtnDefault";
            this.BtnDefault.Size = new System.Drawing.Size(99, 32);
            this.BtnDefault.TabIndex = 10;
            this.BtnDefault.Text = "Default";
            this.BtnDefault.UseVisualStyleBackColor = false;
            this.BtnDefault.Click += new System.EventHandler(this.BtnDefault_Click);
            // 
            // ChkEnableTranslate
            // 
            this.ChkEnableTranslate.AutoSize = true;
            this.ChkEnableTranslate.Location = new System.Drawing.Point(283, 26);
            this.ChkEnableTranslate.Name = "ChkEnableTranslate";
            this.ChkEnableTranslate.Size = new System.Drawing.Size(52, 23);
            this.ChkEnableTranslate.TabIndex = 9;
            this.ChkEnableTranslate.Text = "On";
            this.ChkEnableTranslate.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(165)))), ((int)(((byte)(104)))));
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(44, 305);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(99, 32);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ChkCopyToClipboard
            // 
            this.ChkCopyToClipboard.AutoSize = true;
            this.ChkCopyToClipboard.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkCopyToClipboard.ForeColor = System.Drawing.Color.White;
            this.ChkCopyToClipboard.Location = new System.Drawing.Point(44, 184);
            this.ChkCopyToClipboard.Name = "ChkCopyToClipboard";
            this.ChkCopyToClipboard.Size = new System.Drawing.Size(325, 25);
            this.ChkCopyToClipboard.TabIndex = 7;
            this.ChkCopyToClipboard.Text = "Copy to Clipboard after translated";
            this.ChkCopyToClipboard.UseVisualStyleBackColor = true;
            // 
            // CboOutLang
            // 
            this.CboOutLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboOutLang.FormattingEnabled = true;
            this.CboOutLang.Location = new System.Drawing.Point(283, 122);
            this.CboOutLang.Name = "CboOutLang";
            this.CboOutLang.Size = new System.Drawing.Size(195, 25);
            this.CboOutLang.TabIndex = 6;
            // 
            // CboInLang
            // 
            this.CboInLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboInLang.FormattingEnabled = true;
            this.CboInLang.Location = new System.Drawing.Point(283, 72);
            this.CboInLang.Name = "CboInLang";
            this.CboInLang.Size = new System.Drawing.Size(195, 25);
            this.CboInLang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Translate Language:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source Language:";
            // 
            // LblAlwayOnTop
            // 
            this.LblAlwayOnTop.AutoSize = true;
            this.LblAlwayOnTop.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlwayOnTop.ForeColor = System.Drawing.Color.White;
            this.LblAlwayOnTop.Location = new System.Drawing.Point(40, 26);
            this.LblAlwayOnTop.Name = "LblAlwayOnTop";
            this.LblAlwayOnTop.Size = new System.Drawing.Size(72, 21);
            this.LblAlwayOnTop.TabIndex = 2;
            this.LblAlwayOnTop.Text = "Enable:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Translation Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Copy the text to  clipboard after translated";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Speech the text when click on Volume Icon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Translate the text selected or double click in this";
            // 
            // FrmTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.PnlHelpDetail);
            this.Controls.Add(this.PnlD0);
            this.Controls.Add(this.BtnTranslateSettingsHelp);
            this.Controls.Add(this.LblTranslateSettings);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTranslate";
            this.Size = new System.Drawing.Size(800, 508);
            this.Load += new System.EventHandler(this.FrmTranslate_Load);
            this.PnlHelpDetail.ResumeLayout(false);
            this.PnlHelpDetail.PerformLayout();
            this.PnlD0.ResumeLayout(false);
            this.PnlD0.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTranslateSettingsHelp;
        private System.Windows.Forms.Label LblTranslateSettings;
        private CustomControl.CustomPanel PnlD0;
        private System.Windows.Forms.Label LblAlwayOnTop;
        private System.Windows.Forms.ComboBox CboOutLang;
        private System.Windows.Forms.ComboBox CboInLang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkCopyToClipboard;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.CheckBox ChkEnableTranslate;
        private System.Windows.Forms.Button BtnDefault;
        private System.Windows.Forms.Panel PnlHelpDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

namespace DevTool.Settings
{
    partial class FrmSetting
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
            this.Tab01 = new System.Windows.Forms.TabControl();
            this.TabCommon = new System.Windows.Forms.TabPage();
            this.TabTranslation = new System.Windows.Forms.TabPage();
            this.ChkCopyClipBoard = new System.Windows.Forms.CheckBox();
            this.CboOutLang = new System.Windows.Forms.ComboBox();
            this.Lbl020 = new System.Windows.Forms.Label();
            this.CboInLang = new System.Windows.Forms.ComboBox();
            this.Lbl010 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.PnlF0 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCopyright = new System.Windows.Forms.Label();
            this.Tab01.SuspendLayout();
            this.TabTranslation.SuspendLayout();
            this.PnlF0.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab01
            // 
            this.Tab01.Controls.Add(this.TabCommon);
            this.Tab01.Controls.Add(this.TabTranslation);
            this.Tab01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab01.Location = new System.Drawing.Point(0, 0);
            this.Tab01.Name = "Tab01";
            this.Tab01.SelectedIndex = 0;
            this.Tab01.Size = new System.Drawing.Size(839, 514);
            this.Tab01.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tab01.TabIndex = 1;
            // 
            // TabCommon
            // 
            this.TabCommon.Location = new System.Drawing.Point(4, 25);
            this.TabCommon.Name = "TabCommon";
            this.TabCommon.Padding = new System.Windows.Forms.Padding(3);
            this.TabCommon.Size = new System.Drawing.Size(831, 485);
            this.TabCommon.TabIndex = 0;
            this.TabCommon.Text = "Common";
            this.TabCommon.UseVisualStyleBackColor = true;
            // 
            // TabTranslation
            // 
            this.TabTranslation.Controls.Add(this.ChkCopyClipBoard);
            this.TabTranslation.Controls.Add(this.CboOutLang);
            this.TabTranslation.Controls.Add(this.Lbl020);
            this.TabTranslation.Controls.Add(this.CboInLang);
            this.TabTranslation.Controls.Add(this.Lbl010);
            this.TabTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTranslation.Location = new System.Drawing.Point(4, 25);
            this.TabTranslation.Name = "TabTranslation";
            this.TabTranslation.Padding = new System.Windows.Forms.Padding(3);
            this.TabTranslation.Size = new System.Drawing.Size(831, 485);
            this.TabTranslation.TabIndex = 1;
            this.TabTranslation.Text = "Translation";
            this.TabTranslation.UseVisualStyleBackColor = true;
            // 
            // ChkCopyClipBoard
            // 
            this.ChkCopyClipBoard.AutoSize = true;
            this.ChkCopyClipBoard.Checked = true;
            this.ChkCopyClipBoard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCopyClipBoard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkCopyClipBoard.Location = new System.Drawing.Point(243, 176);
            this.ChkCopyClipBoard.Name = "ChkCopyClipBoard";
            this.ChkCopyClipBoard.Size = new System.Drawing.Size(315, 24);
            this.ChkCopyClipBoard.TabIndex = 18;
            this.ChkCopyClipBoard.Text = "Copy text to clipboard after translation";
            this.ChkCopyClipBoard.UseVisualStyleBackColor = true;
            // 
            // CboOutLang
            // 
            this.CboOutLang.FormattingEnabled = true;
            this.CboOutLang.Location = new System.Drawing.Point(342, 111);
            this.CboOutLang.Name = "CboOutLang";
            this.CboOutLang.Size = new System.Drawing.Size(241, 28);
            this.CboOutLang.TabIndex = 17;
            // 
            // Lbl020
            // 
            this.Lbl020.AutoSize = true;
            this.Lbl020.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl020.Location = new System.Drawing.Point(165, 114);
            this.Lbl020.Name = "Lbl020";
            this.Lbl020.Size = new System.Drawing.Size(162, 20);
            this.Lbl020.TabIndex = 16;
            this.Lbl020.Text = "Translate Language:";
            // 
            // CboInLang
            // 
            this.CboInLang.FormattingEnabled = true;
            this.CboInLang.Location = new System.Drawing.Point(342, 64);
            this.CboInLang.Name = "CboInLang";
            this.CboInLang.Size = new System.Drawing.Size(241, 28);
            this.CboInLang.TabIndex = 15;
            // 
            // Lbl010
            // 
            this.Lbl010.AutoSize = true;
            this.Lbl010.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lbl010.Location = new System.Drawing.Point(182, 67);
            this.Lbl010.Name = "Lbl010";
            this.Lbl010.Size = new System.Drawing.Size(145, 20);
            this.Lbl010.TabIndex = 14;
            this.Lbl010.Text = "Source Language:";
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnOk.Location = new System.Drawing.Point(264, 11);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(90, 34);
            this.BtnOk.TabIndex = 27;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // PnlF0
            // 
            this.PnlF0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlF0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlF0.Controls.Add(this.BtnCancel);
            this.PnlF0.Controls.Add(this.BtnOk);
            this.PnlF0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlF0.Location = new System.Drawing.Point(0, 458);
            this.PnlF0.Name = "PnlF0";
            this.PnlF0.Size = new System.Drawing.Size(839, 56);
            this.PnlF0.TabIndex = 3;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel.Location = new System.Drawing.Point(485, 11);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 34);
            this.BtnCancel.TabIndex = 28;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblCopyright);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 27);
            this.panel1.TabIndex = 2;
            // 
            // LblCopyright
            // 
            this.LblCopyright.AutoSize = true;
            this.LblCopyright.Location = new System.Drawing.Point(336, 4);
            this.LblCopyright.Name = "LblCopyright";
            this.LblCopyright.Size = new System.Drawing.Size(160, 17);
            this.LblCopyright.TabIndex = 0;
            this.LblCopyright.Text = "Fujinet Copyright@2018";
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 541);
            this.Controls.Add(this.PnlF0);
            this.Controls.Add(this.Tab01);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.Tab01.ResumeLayout(false);
            this.TabTranslation.ResumeLayout(false);
            this.TabTranslation.PerformLayout();
            this.PnlF0.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab01;
        private System.Windows.Forms.TabPage TabCommon;
        private System.Windows.Forms.TabPage TabTranslation;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.CheckBox ChkCopyClipBoard;
        private System.Windows.Forms.ComboBox CboOutLang;
        private System.Windows.Forms.Label Lbl020;
        private System.Windows.Forms.ComboBox CboInLang;
        private System.Windows.Forms.Label Lbl010;
        private System.Windows.Forms.Panel PnlF0;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblCopyright;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PnlTabBar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnTran = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.frmHome1 = new DevTool.Settings.FrmHome();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl010 = new System.Windows.Forms.Label();
            this.PnlHeader.SuspendLayout();
            this.PnlTabBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(76)))));
            this.PnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlHeader.Controls.Add(this.Lbl010);
            this.PnlHeader.Controls.Add(this.pictureBox1);
            this.PnlHeader.Controls.Add(this.BtnHelp);
            this.PnlHeader.Controls.Add(this.BtnMinimize);
            this.PnlHeader.Controls.Add(this.BtnClose);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(957, 53);
            this.PnlHeader.TabIndex = 0;
            // 
            // BtnHelp
            // 
            this.BtnHelp.FlatAppearance.BorderSize = 0;
            this.BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelp.Image = global::DevTool.Properties.Resources.help_icon;
            this.BtnHelp.Location = new System.Drawing.Point(799, 3);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(45, 47);
            this.BtnHelp.TabIndex = 4;
            this.BtnHelp.TabStop = false;
            this.BtnHelp.UseVisualStyleBackColor = true;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Image = global::DevTool.Properties.Resources.minimize_icon;
            this.BtnMinimize.Location = new System.Drawing.Point(854, 3);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(45, 47);
            this.BtnMinimize.TabIndex = 3;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = global::DevTool.Properties.Resources.close_icon;
            this.BtnClose.Location = new System.Drawing.Point(909, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(45, 47);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PnlTabBar
            // 
            this.PnlTabBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.PnlTabBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTabBar.Controls.Add(this.button2);
            this.PnlTabBar.Controls.Add(this.BtnTran);
            this.PnlTabBar.Controls.Add(this.BtnHome);
            this.PnlTabBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlTabBar.Location = new System.Drawing.Point(0, 53);
            this.PnlTabBar.Name = "PnlTabBar";
            this.PnlTabBar.Size = new System.Drawing.Size(143, 522);
            this.PnlTabBar.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::DevTool.Properties.Resources.home_icon;
            this.button2.Location = new System.Drawing.Point(3, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 105);
            this.button2.TabIndex = 2;
            this.button2.Text = "Home";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnTran
            // 
            this.BtnTran.FlatAppearance.BorderSize = 0;
            this.BtnTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTran.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTran.ForeColor = System.Drawing.Color.White;
            this.BtnTran.Image = global::DevTool.Properties.Resources.trans_icon;
            this.BtnTran.Location = new System.Drawing.Point(3, 108);
            this.BtnTran.Name = "BtnTran";
            this.BtnTran.Size = new System.Drawing.Size(137, 105);
            this.BtnTran.TabIndex = 1;
            this.BtnTran.Text = "Translator";
            this.BtnTran.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTran.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnTran.UseVisualStyleBackColor = true;
            // 
            // BtnHome
            // 
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Image = global::DevTool.Properties.Resources.home_icon;
            this.BtnHome.Location = new System.Drawing.Point(3, 1);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(137, 105);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnHome.UseVisualStyleBackColor = true;
            // 
            // frmHome1
            // 
            this.frmHome1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.frmHome1.Location = new System.Drawing.Point(140, 53);
            this.frmHome1.Name = "frmHome1";
            this.frmHome1.Size = new System.Drawing.Size(817, 522);
            this.frmHome1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DevTool.Properties.Resources.logo_icon;
            this.pictureBox1.Location = new System.Drawing.Point(18, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl010
            // 
            this.Lbl010.AutoSize = true;
            this.Lbl010.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl010.ForeColor = System.Drawing.Color.White;
            this.Lbl010.Location = new System.Drawing.Point(73, 17);
            this.Lbl010.Name = "Lbl010";
            this.Lbl010.Size = new System.Drawing.Size(96, 23);
            this.Lbl010.TabIndex = 5;
            this.Lbl010.Text = "Dev Tool";
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 575);
            this.Controls.Add(this.frmHome1);
            this.Controls.Add(this.PnlTabBar);
            this.Controls.Add(this.PnlHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.PnlTabBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel PnlTabBar;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnTran;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnMinimize;
        private FrmHome frmHome1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl010;
    }
}
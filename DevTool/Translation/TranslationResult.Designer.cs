using System.Windows.Forms;

namespace DevTool.Translation
{
    partial class TranslationResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslationResult));
            this.LblInLang = new System.Windows.Forms.Label();
            this.TxtInlang = new System.Windows.Forms.TextBox();
            this.TxtOutlang = new System.Windows.Forms.TextBox();
            this.LblOutLang = new System.Windows.Forms.Label();
            this.LblSeeMore = new System.Windows.Forms.LinkLabel();
            this.LblClose = new System.Windows.Forms.Label();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.BtnSpeakResult = new System.Windows.Forms.Button();
            this.BtnSpeakSource = new System.Windows.Forms.Button();
            this.LblTranslationTime = new System.Windows.Forms.Label();
            this.BtnTranslate = new System.Windows.Forms.Button();
            this.PnlForm = new DevTool.CustomControl.CustomPanel();
            this.SuspendLayout();
            // 
            // LblInLang
            // 
            this.LblInLang.AutoSize = true;
            this.LblInLang.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInLang.ForeColor = System.Drawing.Color.White;
            this.LblInLang.Location = new System.Drawing.Point(56, 47);
            this.LblInLang.Name = "LblInLang";
            this.LblInLang.Size = new System.Drawing.Size(51, 21);
            this.LblInLang.TabIndex = 0;
            this.LblInLang.Text = "Auto";
            // 
            // TxtInlang
            // 
            this.TxtInlang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtInlang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInlang.Location = new System.Drawing.Point(25, 82);
            this.TxtInlang.Multiline = true;
            this.TxtInlang.Name = "TxtInlang";
            this.TxtInlang.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtInlang.Size = new System.Drawing.Size(521, 144);
            this.TxtInlang.TabIndex = 0;
            this.TxtInlang.TabStop = false;
            this.TxtInlang.Validated += new System.EventHandler(this.TxtInlang_Validated);
            // 
            // TxtOutlang
            // 
            this.TxtOutlang.AcceptsReturn = true;
            this.TxtOutlang.AcceptsTab = true;
            this.TxtOutlang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOutlang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutlang.Location = new System.Drawing.Point(25, 287);
            this.TxtOutlang.Multiline = true;
            this.TxtOutlang.Name = "TxtOutlang";
            this.TxtOutlang.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtOutlang.Size = new System.Drawing.Size(521, 144);
            this.TxtOutlang.TabIndex = 1;
            this.TxtOutlang.TabStop = false;
            this.TxtOutlang.Validated += new System.EventHandler(this.TxtOutlang_Validated);
            // 
            // LblOutLang
            // 
            this.LblOutLang.AutoSize = true;
            this.LblOutLang.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutLang.ForeColor = System.Drawing.Color.White;
            this.LblOutLang.Location = new System.Drawing.Point(57, 252);
            this.LblOutLang.Name = "LblOutLang";
            this.LblOutLang.Size = new System.Drawing.Size(63, 21);
            this.LblOutLang.TabIndex = 2;
            this.LblOutLang.Text = "English";
            // 
            // LblSeeMore
            // 
            this.LblSeeMore.AutoSize = true;
            this.LblSeeMore.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeeMore.LinkColor = System.Drawing.Color.Aqua;
            this.LblSeeMore.Location = new System.Drawing.Point(411, 452);
            this.LblSeeMore.Name = "LblSeeMore";
            this.LblSeeMore.Size = new System.Drawing.Size(114, 21);
            this.LblSeeMore.TabIndex = 4;
            this.LblSeeMore.TabStop = true;
            this.LblSeeMore.Text = "See More >>";
            this.LblSeeMore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblSeeMore_LinkClicked);
            // 
            // LblClose
            // 
            this.LblClose.AutoSize = true;
            this.LblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.LblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClose.ForeColor = System.Drawing.Color.White;
            this.LblClose.Location = new System.Drawing.Point(522, 9);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(24, 24);
            this.LblClose.TabIndex = 5;
            this.LblClose.Text = "X";
            this.LblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // BtnCopy
            // 
            this.BtnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(165)))), ((int)(((byte)(104)))));
            this.BtnCopy.FlatAppearance.BorderSize = 0;
            this.BtnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopy.ForeColor = System.Drawing.Color.White;
            this.BtnCopy.Location = new System.Drawing.Point(461, 251);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(85, 27);
            this.BtnCopy.TabIndex = 2;
            this.BtnCopy.TabStop = false;
            this.BtnCopy.Text = "Copy";
            this.BtnCopy.UseVisualStyleBackColor = false;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // BtnSpeakResult
            // 
            this.BtnSpeakResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSpeakResult.BackgroundImage")));
            this.BtnSpeakResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSpeakResult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSpeakResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSpeakResult.Location = new System.Drawing.Point(24, 246);
            this.BtnSpeakResult.Name = "BtnSpeakResult";
            this.BtnSpeakResult.Size = new System.Drawing.Size(29, 31);
            this.BtnSpeakResult.TabIndex = 6;
            this.BtnSpeakResult.TabStop = false;
            this.BtnSpeakResult.UseVisualStyleBackColor = true;
            this.BtnSpeakResult.Click += new System.EventHandler(this.BtnSpeakResult_Click);
            // 
            // BtnSpeakSource
            // 
            this.BtnSpeakSource.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSpeakSource.BackgroundImage")));
            this.BtnSpeakSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSpeakSource.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSpeakSource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnSpeakSource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnSpeakSource.Location = new System.Drawing.Point(24, 41);
            this.BtnSpeakSource.Name = "BtnSpeakSource";
            this.BtnSpeakSource.Size = new System.Drawing.Size(29, 31);
            this.BtnSpeakSource.TabIndex = 7;
            this.BtnSpeakSource.TabStop = false;
            this.BtnSpeakSource.UseVisualStyleBackColor = true;
            this.BtnSpeakSource.Click += new System.EventHandler(this.BtnSpeakSource_Click);
            // 
            // LblTranslationTime
            // 
            this.LblTranslationTime.AutoSize = true;
            this.LblTranslationTime.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTranslationTime.ForeColor = System.Drawing.Color.White;
            this.LblTranslationTime.Location = new System.Drawing.Point(22, 452);
            this.LblTranslationTime.Name = "LblTranslationTime";
            this.LblTranslationTime.Size = new System.Drawing.Size(204, 21);
            this.LblTranslationTime.TabIndex = 8;
            this.LblTranslationTime.Text = "Translation in 0 seconds";
            // 
            // BtnTranslate
            // 
            this.BtnTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(165)))), ((int)(((byte)(104)))));
            this.BtnTranslate.FlatAppearance.BorderSize = 0;
            this.BtnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTranslate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTranslate.ForeColor = System.Drawing.Color.White;
            this.BtnTranslate.Location = new System.Drawing.Point(461, 46);
            this.BtnTranslate.Name = "BtnTranslate";
            this.BtnTranslate.Size = new System.Drawing.Size(85, 27);
            this.BtnTranslate.TabIndex = 9;
            this.BtnTranslate.TabStop = false;
            this.BtnTranslate.Text = "Translate";
            this.BtnTranslate.UseVisualStyleBackColor = false;
            this.BtnTranslate.Click += new System.EventHandler(this.BtnTranslate_Click);
            // 
            // PnlForm
            // 
            this.PnlForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.PnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlForm.Location = new System.Drawing.Point(0, 0);
            this.PnlForm.Name = "PnlForm";
            this.PnlForm.Size = new System.Drawing.Size(565, 492);
            this.PnlForm.TabIndex = 10;
            // 
            // TranslationResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(565, 492);
            this.ControlBox = false;
            this.Controls.Add(this.BtnTranslate);
            this.Controls.Add(this.LblTranslationTime);
            this.Controls.Add(this.BtnSpeakSource);
            this.Controls.Add(this.BtnSpeakResult);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.LblClose);
            this.Controls.Add(this.LblSeeMore);
            this.Controls.Add(this.TxtOutlang);
            this.Controls.Add(this.LblOutLang);
            this.Controls.Add(this.TxtInlang);
            this.Controls.Add(this.LblInLang);
            this.Controls.Add(this.PnlForm);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TranslationResult";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Translation Result";
            this.Load += new System.EventHandler(this.TranslationResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInLang;
        private System.Windows.Forms.TextBox TxtInlang;
        private System.Windows.Forms.TextBox TxtOutlang;
        private System.Windows.Forms.Label LblOutLang;
        private System.Windows.Forms.LinkLabel LblSeeMore;
        private System.Windows.Forms.Label LblClose;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Button BtnSpeakResult;
        private System.Windows.Forms.Button BtnSpeakSource;
        private Label LblTranslationTime;
        private Button BtnTranslate;
        private CustomControl.CustomPanel PnlForm;
    }
}
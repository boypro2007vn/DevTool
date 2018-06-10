using System.Windows.Forms;

namespace DevTool.Translation
{
    partial class TranslationButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslationButton));
            this.BtnTran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTran
            // 
            this.BtnTran.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTran.BackgroundImage")));
            this.BtnTran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTran.FlatAppearance.BorderSize = 0;
            this.BtnTran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTran.Location = new System.Drawing.Point(-1, -1);
            this.BtnTran.Name = "BtnTran";
            this.BtnTran.Size = new System.Drawing.Size(33, 33);
            this.BtnTran.TabIndex = 1;
            this.BtnTran.UseVisualStyleBackColor = true;
            this.BtnTran.Click += new System.EventHandler(this.BtnTran_Click);
            // 
            // TranslationButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(31, 31);
            this.ControlBox = false;
            this.Controls.Add(this.BtnTran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(37, 37);
            this.MinimumSize = new System.Drawing.Size(37, 37);
            this.Name = "TranslationButton";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTran;
    }
}

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
            this.BtnTrans = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTrans
            // 
            this.BtnTrans.Image = global::DevTool.Properties.Resources.btnTran;
            this.BtnTrans.Location = new System.Drawing.Point(-3, -3);
            this.BtnTrans.Name = "BtnTrans";
            this.BtnTrans.Size = new System.Drawing.Size(36, 37);
            this.BtnTrans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnTrans.TabIndex = 0;
            this.BtnTrans.TabStop = false;
            this.BtnTrans.Click += new System.EventHandler(this.BtnTran_Click);
            // 
            // TranslationButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(31, 31);
            this.ControlBox = false;
            this.Controls.Add(this.BtnTrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(37, 37);
            this.MinimumSize = new System.Drawing.Size(37, 37);
            this.Name = "TranslationButton";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.TranslationButton_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.BtnTrans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox BtnTrans;
    }
}

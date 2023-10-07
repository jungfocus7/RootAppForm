namespace AppNormalForm
{
    partial class NormalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NormalForm));
            this.m_txb31 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_txb31
            // 
            this.m_txb31.Location = new System.Drawing.Point(12, 12);
            this.m_txb31.Multiline = true;
            this.m_txb31.Name = "m_txb31";
            this.m_txb31.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_txb31.Size = new System.Drawing.Size(676, 735);
            this.m_txb31.TabIndex = 0;
            this.m_txb31.WordWrap = false;
            // 
            // NormalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 800);
            this.Controls.Add(this.m_txb31);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NormalForm";
            this.ShowInTaskbar = false;
            this.Text = "NormalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txb31;
    }
}
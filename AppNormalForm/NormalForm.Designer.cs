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
            this.m_btn31 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_txb31
            // 
            this.m_txb31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txb31.Location = new System.Drawing.Point(12, 12);
            this.m_txb31.Multiline = true;
            this.m_txb31.Name = "m_txb31";
            this.m_txb31.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_txb31.Size = new System.Drawing.Size(676, 649);
            this.m_txb31.TabIndex = 0;
            this.m_txb31.WordWrap = false;
            // 
            // m_btn31
            // 
            this.m_btn31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btn31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_btn31.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_btn31.Location = new System.Drawing.Point(550, 667);
            this.m_btn31.Name = "m_btn31";
            this.m_btn31.Size = new System.Drawing.Size(138, 55);
            this.m_btn31.TabIndex = 1;
            this.m_btn31.Text = "기능 메뉴";
            this.m_btn31.UseVisualStyleBackColor = true;
            // 
            // NormalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 800);
            this.Controls.Add(this.m_btn31);
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
        internal System.Windows.Forms.Button m_btn31;
    }
}
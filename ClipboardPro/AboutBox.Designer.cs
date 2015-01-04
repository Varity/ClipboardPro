namespace ClipboardPro
{
    partial class AboutBox
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.okButton = new System.Windows.Forms.Button();
            this.labelProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelVersion1 = new System.Windows.Forms.Label();
            this.labelProductName1 = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(15, 92);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(254, 84);
            this.textBoxDescription.TabIndex = 27;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Beschreibung";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClipboardPro.Properties.Resources.clipboard;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 74);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(194, 182);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 29;
            this.okButton.Text = "&OK";
            // 
            // labelProductName
            // 
            this.labelProductName.Location = new System.Drawing.Point(102, 12);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(0, 17);
            this.labelProductName.TabIndex = 30;
            this.labelProductName.Text = "Produktname";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(102, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Produktname";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(102, 31);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(0, 17);
            this.labelVersion.TabIndex = 32;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion1
            // 
            this.labelVersion1.AutoSize = true;
            this.labelVersion1.Location = new System.Drawing.Point(12, 187);
            this.labelVersion1.Name = "labelVersion1";
            this.labelVersion1.Size = new System.Drawing.Size(42, 13);
            this.labelVersion1.TabIndex = 33;
            this.labelVersion1.Text = "Version";
            // 
            // labelProductName1
            // 
            this.labelProductName1.AutoSize = true;
            this.labelProductName1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName1.Location = new System.Drawing.Point(100, 23);
            this.labelProductName1.Name = "labelProductName1";
            this.labelProductName1.Size = new System.Drawing.Size(74, 29);
            this.labelProductName1.TabIndex = 34;
            this.labelProductName1.Text = "Name";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(175, 51);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(71, 13);
            this.lblAutor.TabIndex = 35;
            this.lblAutor.Text = "Burak Bektas";
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.labelProductName1);
            this.Controls.Add(this.labelVersion1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelVersion1;
        private System.Windows.Forms.Label labelProductName1;
        private System.Windows.Forms.Label lblAutor;





    }
}

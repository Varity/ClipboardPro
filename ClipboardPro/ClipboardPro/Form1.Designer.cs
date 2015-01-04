namespace ClipboardPro
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOnlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutClipboardProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.cmbModifier = new System.Windows.Forms.ComboBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOnlineHelpToolStripMenuItem,
            this.featureRequestToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutClipboardProToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewOnlineHelpToolStripMenuItem
            // 
            this.viewOnlineHelpToolStripMenuItem.Name = "viewOnlineHelpToolStripMenuItem";
            this.viewOnlineHelpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewOnlineHelpToolStripMenuItem.Text = "View Online Help";
            // 
            // featureRequestToolStripMenuItem
            // 
            this.featureRequestToolStripMenuItem.Name = "featureRequestToolStripMenuItem";
            this.featureRequestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.featureRequestToolStripMenuItem.Text = "Feature Request";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutClipboardProToolStripMenuItem
            // 
            this.aboutClipboardProToolStripMenuItem.Name = "aboutClipboardProToolStripMenuItem";
            this.aboutClipboardProToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutClipboardProToolStripMenuItem.Text = "About ClipboardPro";
            this.aboutClipboardProToolStripMenuItem.Click += new System.EventHandler(this.aboutClipboardProToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbKey);
            this.groupBox1.Controls.Add(this.cmbModifier);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier + Hotkey";
            // 
            // cmbKey
            // 
            this.cmbKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClipboardPro.Properties.Settings.Default, "SavedKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbKey.FormattingEnabled = true;
            this.cmbKey.Location = new System.Drawing.Point(131, 20);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(122, 21);
            this.cmbKey.TabIndex = 1;
            this.cmbKey.Text = global::ClipboardPro.Properties.Settings.Default.SavedKey;
            // 
            // cmbModifier
            // 
            this.cmbModifier.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClipboardPro.Properties.Settings.Default, "SavedModifier", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbModifier.FormattingEnabled = true;
            this.cmbModifier.Location = new System.Drawing.Point(7, 20);
            this.cmbModifier.Name = "cmbModifier";
            this.cmbModifier.Size = new System.Drawing.Size(122, 21);
            this.cmbModifier.TabIndex = 0;
            this.cmbModifier.Text = global::ClipboardPro.Properties.Settings.Default.SavedModifier;
            // 
            // txtContent
            // 
            this.txtContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClipboardPro.Properties.Settings.Default, "SavedClipboardContent", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtContent.Location = new System.Drawing.Point(7, 45);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(246, 20);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = global::ClipboardPro.Properties.Settings.Default.SavedClipboardContent;
            // 
            // txtInput
            // 
            this.txtInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClipboardPro.Properties.Settings.Default, "SavedClipboardInformationPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtInput.Location = new System.Drawing.Point(7, 19);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(246, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = global::ClipboardPro.Properties.Settings.Default.SavedClipboardInformationPath;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInput);
            this.groupBox2.Controls.Add(this.txtContent);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(13, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 86);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "ClipboardPro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOnlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutClipboardProToolStripMenuItem;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbKey;
        private System.Windows.Forms.ComboBox cmbModifier;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


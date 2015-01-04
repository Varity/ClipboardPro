using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ClipboardPro.Properties;

namespace ClipboardPro
{
    public partial class frmMain : Form
    {
        private String _content;
        private String _keyFrm;
        private String _modkeyFrm;
        private String _path;
        private readonly KeyboardHook hook = new KeyboardHook();

        public frmMain()
        {
            InitializeComponent();

            // register the event that is fired after the key press.
            hook.KeyPressed +=
                hook_KeyPressed;
            // register the control + L combination as hot key.
            hook.RegisterHotKey(KeyboardHook.ModKeys.Control, Keys.L);
        }

        private void hook_KeyPressed(object sender, KeyboardHook.KeyPressedEventArgs e)
        {
            _path = Settings.Default.SavedClipboardInformationPath;
            _content = Settings.Default.SavedClipboardContent;

            // set content to clipboard and send control + v
            Clipboard.SetText(_content);
            SendKeys.Send("^{v}");
        }

        #region OpenfileDialog

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = string.Empty;
            var content = string.Empty;
            Stream myStream = null;
            var openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Settings.Default.SavedClipboardInformationPath;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            var sr = new StreamReader(openFileDialog1.FileName, Encoding.UTF8);
                            path = openFileDialog1.FileName;

                            txtContent.Text = sr.ReadLine();
                            content = txtContent.Text;
                            txtInput.Text = openFileDialog1.FileName;

                            Settings.Default.SavedClipboardInformationPath = path;
                            Settings.Default.SavedClipboardContent = content;
                            Settings.Default.Save();
                            sr.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        #endregion
        #region AboutBox
        private void aboutClipboardProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
        }
        #endregion
        #region Exit Application

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
/* Burak Bektas 
 * 04.12.2014
 * KeyboardHook :    Author: Christian Liensberger
                     Class from: http://www.liensberger.it/web/blog/?p=207
 */

using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ClipboardPro.Properties;


namespace ClipboardPro
{
    public partial class frmMain : Form
    {
        //private String _keyFrm;
        //private String _modkeyFrm;
        private String _content;
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

        #region Open

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = string.Empty;
            var content = string.Empty;
            Stream myStream = null;
            var openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Settings.Default.SavedClipboardInformationPath;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
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
                    MessageBox.Show(ex.Message);
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

        #region Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fs = new FileStream(txtInput.Text, FileMode.Append, FileAccess.Write))
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(txtContent.Text);
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }
        #endregion

        #region Save As
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            var saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    var wText = new StreamWriter(myStream);

                    wText.Write(txtContent.Text);
                    wText.AutoFlush = true;
                    wText.Close();
                    myStream.Close();
                }
            }
        }
        #endregion

        #region Request a Feature | TODO
        private void featureRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
    }
}
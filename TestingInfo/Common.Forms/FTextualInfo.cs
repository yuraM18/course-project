using System;
using System.IO;
using System.Windows.Forms;

namespace Common.Forms
{
    public partial class FTextualInfo : Form
    {
        public FTextualInfo()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return Text; }
            set { Text = value; }
        }

        public string Information
        {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void ToolStripMenuItemFileSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, Information);
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

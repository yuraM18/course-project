using System;
using System.Diagnostics;
using System.Windows.Forms;
using TestingInfo.FormsEditor.Models;

namespace TestingInfo.FormsEditor.Editors
{
    public partial class FTestEditor : Form
    {
        public TestModel Model { get; set; }

        public FTestEditor()
        {
            InitializeComponent();
        }

        //public void SetTestsNames(string[] names)
        //{
        //    comboBoxTopicName.Items.Clear();
        //    comboBoxTopicName.Items.Add(names);
        //}

        public bool readOnly;

        public bool ReadOnly
        {
            get { return readOnly; }
            set { readOnly = value;
                SetControlsState();
            }
        }

        private void SetControlsState()
        {
            buttonOk.Visible = !readOnly;
            buttonCancel.Text = readOnly ? "Ok" : "Відмінити";
            textBoxName.ReadOnly = readOnly;
            //comboBoxTopicName.DropDownStyle =
            //    readOnly ? ComboBoxStyle.Simple : ComboBoxStyle.DropDown;
            textBoxTopic.ReadOnly = readOnly;
            numericUpDownBales.ReadOnly = readOnly;
            richTextBoxDescription.ReadOnly = readOnly;
        }

        private void ShowData()
        {
            textBoxName.Text = Model.Name;
            textBoxTopic.Text = Model.Topic;
            numericUpDownBales.Text = Model.MaxBales.HasValue ?
                Model.MaxBales.Value.ToString() : "";
            richTextBoxDescription.Text = Model.Description;
        }

        private void FTestEditor_Shown(object sender, EventArgs e)
        {
            ShowData();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Model.Name = textBoxName.Text;
            Model.Topic = textBoxTopic.Text;
            Model.MaxBales = numericUpDownBales.Text == "" ? (int?)null
                : int.Parse(numericUpDownBales.Text);
            Model.Description = richTextBoxDescription.Text;
            DialogResult = DialogResult.OK;
        }

        private void richTextBoxDescription_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void comboBoxTopicName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ReadOnly;
        }

        private void comboBoxTopicName_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = ReadOnly;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

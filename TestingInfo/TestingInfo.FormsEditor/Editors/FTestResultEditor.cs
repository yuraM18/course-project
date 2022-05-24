using System;
using System.Diagnostics;
using System.Windows.Forms;
using TestingInfo.Data;
using TestingInfo.FormsEditor.Models;

namespace TestingInfo.FormsEditor.Editors
{
    public partial class FTestResultEditor : Form
    {
        public TestResultModel Model { get; set; }

        public FTestResultEditor()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyy/MM/dd hh:mm:ss";
        }

        private void numericUpDownBales_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDownBales.Maximum = DataContext
        }

        public void SetTestsNames(string[] names)
        {
            comboBoxTest.Items.Clear();

            comboBoxTest.Items.AddRange(names);
        }

        public void SetPersonNames(string[] names)
        {
            comboBoxPerson.Items.Clear();
            comboBoxPerson.Items.AddRange(names);
        }

        private bool readOnly;

        public bool ReadOnly { get { return readOnly; } set
            {
                readOnly = value;
                SetControlsState();
            } 
        }

        private void SetControlsState()
        {
            buttonOk.Visible = !readOnly;
            buttonCancel.Text = readOnly ? "Ok" : "Відмінити";
            comboBoxPerson.DropDownStyle =
                readOnly ? ComboBoxStyle.Simple : ComboBoxStyle.DropDown;
            comboBoxTest.DropDownStyle =
                readOnly ? ComboBoxStyle.Simple : ComboBoxStyle.DropDown;
            dateTimePicker1.Enabled = !readOnly;
            numericUpDownBales.ReadOnly = readOnly;
            richTextBoxNote.ReadOnly = readOnly;
            richTextBoxResult.ReadOnly = readOnly;
        }

        private void FTestResultEditor_Shown(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            comboBoxPerson.Text = Model.Person;
            comboBoxTest.Text = Model.Test;
            dateTimePicker1.Checked = Model.DateTime.HasValue;
            if (Model.DateTime.HasValue) { dateTimePicker1.Checked = Model.DateTime.HasValue; }
            numericUpDownBales.Text = Model.Bales.HasValue ?
                Model.Bales.Value.ToString() : "";
            richTextBoxNote.Text = Model.Note;
            richTextBoxResult.Text = Model.Result;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Model.Person = comboBoxPerson.Text;
            Model.Test = comboBoxTest.Text;
            Model.DateTime = dateTimePicker1.Checked ? dateTimePicker1.Value : (DateTime?)null;
            Model.Bales = numericUpDownBales.Text == "" ? (int?)null
                : int.Parse(numericUpDownBales.Text);
            Model.Note = richTextBoxNote.Text;
            Model.Result = richTextBoxResult.Text;
            DialogResult = DialogResult.OK;
        }

        private void richTextBoxNote_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void comboBoxTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ReadOnly;
        }

        private void comboBoxTest_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = ReadOnly;
        }
    }
}

using Common.Forms;
using Common.Interfaces;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TestingInfo.Data;
using TestingInfo.Entity;
using TestingInfo.FormsEditor.Editors;
using TestingInfo.FormsEditor.Extensions;
using TestingInfo.FormsEditor.Models;
using TestingInfo.FormsEditor.Selector;

namespace TestingInfo.FormsEditor
{
    public partial class FMain : Form
    {
        bool vis = true;

        public DataContext DataContext { get; set; }
        public FSelector TestsSelector { get; set; }
        public FTestResultSelector TestResultSelector { get; set; }
        FTestResultEditor editor = new FTestResultEditor();
        FTestEditor testEditor = new FTestEditor();

        public FMain()
        {
            InitializeComponent();
            VisibleElementsWithStart();
        }

        private void VisibleElementsWithStart()
        {
            statusStrip1.Visible = false;
            menuStrip1.Visible = false;
            listBoxTest.Visible = false;
            dataGridView1.Visible = false;
            panelBack.Dock = DockStyle.Fill;
            buttonMax.Visible = false;
            buttonMin.Visible = false;
            buttonTestCreate.Visible = false;
            buttonExitUser.Visible = false;
            panelBar.Visible = false;
            buttonCreateTestReasult.Visible = false;
        }

        FTextualInfo fTextualInfo = new FTextualInfo()
        {
            Title = "ПО\"Країни\""
        };

        public static string ident;


        private void ToolStripMenuItemDataAsText_Click(object sender, EventArgs e)
        {
            fTextualInfo.Information = DataContext.ToString();
            fTextualInfo.ShowDialog();
        }

        private void ToolStripMenuItemDataTest_Click(object sender, EventArgs e)
        {
            TestsSelector.ShowDialog();
        }

        private void ToolStripMenuItemDataTestResult_Click(object sender, EventArgs e)
        {
            TestResultSelector.ShowDialog();
        }

        private void menuDataTestingMin_Click(object sender, EventArgs e)
        {
            DataContext.CreateTestingData();
        }

        private void ToolStripMenuItemFileDataSave_Click(object sender, EventArgs e)
        {
            DataContext.Save();
        }

        private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDateTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void ToolStripMenuItemDataTesting_Click(object sender, EventArgs e)
        {
            if (DataContext.IsEmpty())
            {
                DataContext.CreateTestingData();
            }
        }

        FAboutBox fAboutBox = new FAboutBox();

        private void ToolStripMenuItemDataHelpAbout_Click(object sender, EventArgs e)
        {
            fAboutBox.ShowDialog();
        }

        private void panelBack_Resize(object sender, EventArgs e)
        {
            panelAuthoriation.Top = panelBack.Height / 2 - 76;
            panelAuthoriation.Left = panelBack.Width / 15;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (vis)
            {
                textBoxPass.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
                vis = true;
            }
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            ident = textBoxLog.Text;
            foreach (var obj in DataContext.Users)
            {
                if (obj.UserLog == textBoxLog.Text && obj.UserPass== textBoxPass.Text)
                {
                    panelAuthoriation.Visible = false;
                    panelBack.BackgroundImage = null;
                    menuStrip1.Visible = true;
                    statusStrip1.Visible = true;
                    listBoxTest.Visible = true;
                    listBoxTest.Top = menuStrip1.Height + 1;
                    listBoxTest.Left = panelBack.Left;
                    listBoxTest.Height = panelBack.Height - statusStrip1.Height - 2 - menuStrip1.Height;
                    listBoxTest.Width = panelBack.Width / 3;

                    dataGridView1.Visible = true;
                    dataGridView1.ColumnCount = 6;
                    dataGridView1.Columns[0].Name = "Студент";
                    dataGridView1.Columns[1].Name = "Дата і час";
                    dataGridView1.Columns[2].Name = "Бал";
                    dataGridView1.Top = menuStrip1.Height + 2;
                    dataGridView1.Height = panelBack.Height - statusStrip1.Height - 30 - menuStrip1.Height;
                    dataGridView1.Width = panelBack.Width / 3 + listBoxTest.Width;
                    dataGridView1.Left = listBoxTest.Right;

                    dataGridView1.Columns[0].Width = dataGridView1.Width / 3;
                    dataGridView1.Columns[1].Width = dataGridView1.Width / 4;
                    dataGridView1.Columns[3].Width = dataGridView1.Width / 8;
                    dataGridView1.Columns[4].Width = dataGridView1.Width / 10;
                    dataGridView1.Columns[5].Width = dataGridView1.Width / 10;

                    buttonCreateTestReasult.Visible = true;
                    buttonCreateTestReasult.Left = menuStrip1.Width / 3;
                    buttonCreateTestReasult.Top = statusStrip1.Top - 30;



                    buttonMin.Top = statusStrip1.Top - 30;
                    buttonMin.Left = panelBack.Left;

                    buttonTestCreate.Visible = true;
                    buttonTestCreate.Top = statusStrip1.Top - 30;
                    buttonTestCreate.Left = listBoxTest.Width / 2 - 111;

                    buttonMax.Top = statusStrip1.Top - 30;
                    buttonMax.Left = listBoxTest.Width - buttonMax.Width;

                    buttonExitUser.Visible = true;
                    buttonExitUser.Top = statusStrip1.Top - 30;
                    buttonExitUser.Left = panelBack.Width - 85;



                    CreateControls();
                }
            }
        }

        int top, k = 0, kMax = 10, countControler = 0;

        private void FMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                buttonLog_Click(buttonLog, null);
            }
        }

        private void CreateControls()
        {
            if (DataContext != null)
            {
                UpdateTest();
            }
        }

        private void UpdateTest()
        {
            listBoxTest.Controls.Clear();
            top = 0;
            foreach (var obj in DataContext.Tests)
            {
                if (obj.User.UserLog == textBoxLog.Text)
                {
                    if (k <= countControler && countControler <= kMax)
                    {
                        Control control = new Button();
                        control.Text = obj.Name;
                        control.Width = listBoxTest.Width - 5;
                        control.Height = listBoxTest.Height / 10 - 2;
                        control.Top = listBoxTest.Height / 10 * top - 1;
                        control.Margin = new Padding(0);
                        control.MouseEnter += new EventHandler(this.button_MouseEnter);
                        control.MouseLeave += new EventHandler(this.button_MouseLeave);
                        control.MouseClick += new MouseEventHandler(this.button_MouseClick);
                        bunifuElipse1.ElipseRadius = 9;
                        bunifuElipse1.TargetControl = control;
                        listBoxTest.Controls.Add(control);
                        top++;
                    }
                    countControler++;
                }
                panelBar.Visible = false;
            }

            if (k >= 10 && countControler > kMax)
            {
                buttonMin.Visible = true;
                buttonMax.Visible = true;
            }
            else if (countControler > kMax)
            {
                buttonMax.Visible = true;
                buttonMin.Visible = false;
            }
            else if (countControler < kMax && k >= 10)
            {
                buttonMin.Visible = true;
                buttonMax.Visible = false;
            }
            else
            {
                buttonMax.Visible = false;
                buttonMin.Visible = false;
            }
            countControler = 0;
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.Orange;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.Control;
        }

        int i, j;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string znach = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            j = e.RowIndex;
            if (znach == "редагувати")
            {
                i = e.ColumnIndex - 3;
                PrepareEditor(SelectedInstance1, false);
                if (editor.ShowDialog() != DialogResult.OK)
                    return;
                UpdateInstance(SelectedInstance1, editor.Model);
                UpdataTestRes(buttonClick);
            }
            if (znach == "перегляд")
            {
                i = e.ColumnIndex - 4;
                PrepareEditor(SelectedInstance1, true);
                editor.ShowDialog();
            }
            if (znach == "удалити")
            {
                i = e.ColumnIndex - 5;
                DataContext.TestResults.Remove(SelectedInstance1);
                UpdataTestRes(buttonClick);
            }
        }

        private void UpdateInstance(TestResult inst, TestResultModel model)
        {
            inst.Person = model.Person;
            inst.Test = DataContext.Tests
                .First(e => e.Name == model.Test);
            inst.DateTime = model.DateTime;
            inst.Bales = model.Bales;
            inst.Result = model.Result;
            inst.Note = model.Note;
        }

        protected virtual TestResult SelectedInstance1
        {
            get { return SelectedInstance as TestResult; }
        }


        protected virtual IStringIdentified SelectedInstance
        {
            get
            {
                return DataContext.TestResults.First(
                    el => el.StringIdentifier == (string)dataGridView1[i, j].Value.ToString()) as TestResult;
            }
        }

        private void PrepareEditor(TestResult inst, bool readOnly)
        {
            int contComboBoxTest = 0;
            foreach (var m in DataContext.Tests)
            {
                if (m.User.UserLog.ToString() == textBoxLog.Text)
                {
                    contComboBoxTest++;
                }
            }
            string[] testResultNames = new string[contComboBoxTest];
            contComboBoxTest = 0;
            foreach (var m in DataContext.Tests)
            {
                if(m.User.UserLog.ToString() == textBoxLog.Text)
                {
                    testResultNames[contComboBoxTest] = m.Name;
                    contComboBoxTest++;
                }
            }

            string[] PersonNames = new string[DataContext.TestResults.Count];
            int countComboBoxPerson = 0;
            foreach (var n in DataContext.TestResults)
            {
                PersonNames[countComboBoxPerson] = n.Person;
                countComboBoxPerson++;
            }

            editor.SetPersonNames(PersonNames);
            editor.SetTestsNames(testResultNames);
            editor.Model = inst == null ? new TestResultModel()
                : (TestResultModel)inst;
            editor.ReadOnly = readOnly;
        }

        public string buttonClick;

        private void buttonCreateTestReasult_Click(object sender, EventArgs e)
        {
            PrepareEditor(null, false);
            if (editor.ShowDialog() != DialogResult.OK)
                return;
            TestResult newInst = editor.Model.ToTestResult(
                DataContext.Tests);
            newInst.Id = DataContext.TestResults.Count == 0 ? 1
                : DataContext.TestResults.Select(el => el.Id).Max() + 1;
            DataContext.TestResults.Add(newInst);
            UpdataTestRes(buttonClick);
        }

        private void buttonTestCreate_Click(object sender, EventArgs e)
        {
            PrepareTestEditor(null, false);
            if (testEditor.ShowDialog() != DialogResult.OK)
                return;
            testEditor.Model.User = textBoxLog.Text;
            Test newInst = testEditor.Model.ToTest(DataContext.Users);
            newInst.User = DataContext.Users.First(el => el.UserLog == textBoxLog.Text);
            newInst.Id = DataContext.TestResults.Count == 0 ? 1
                : DataContext.Tests.Select(el => el.Id).Max() + 1;
            DataContext.Tests.Add(newInst);

            UpdateTest();
        }

        

        private void PrepareTestEditor(Test inst, bool readOnly)
        {

            testEditor.Model = inst == null ? new TestModel()
                : (TestModel)inst;
            testEditor.ReadOnly = readOnly;
        }

        private void buttonExitUser_Click(object sender, EventArgs e)
        {
            VisibleElementsWithStart();
            panelAuthoriation.Visible = true;
            textBoxLog.Text = null;
            textBoxPass.Text = null;
        }

        private void ToolStripMenuItemDataTest_Click_1(object sender, EventArgs e)
        {
            foreach(var m in DataContext.Tests)
            {
                if(m.Name == buttonClick)
                {
                    const string message = "Ви дійсно бажаєте видалити тест?";
                    const string caption = "Form Closing";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DataContext.Tests.Remove(m);
                        break;
                    }
                }
            }
            UpdateTest();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            k -= 10;
            kMax -= 10;
            CreateControls();
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            k += 10;
            kMax += 10;
            CreateControls();
        }

        private void button_MouseClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            panelBar.Visible = true;
            panelBar.Top = button.Top + menuStrip1.Height + 2;
            panelBar.Height = button.Height;
            panelBar.Left = button.Right - 8;

            dataGridView1.Rows.Clear();

            buttonClick = button.Text;

            top = 0;
            UpdataTestRes(buttonClick);
            button_MouseEnter(sender, e);
            button_MouseLeave(sender, e);
        }

        private void UpdataTestRes(string button)
        {
            dataGridView1.Rows.Clear();
            foreach (var obj in DataContext.TestResults)
            {
                if (obj.Test.Name == button)
                {
                    string[] row = new string[] { obj.Person, obj.DateTime.ToString(), obj.Bales.ToString(), "редагувати", "перегляд", "удалити" };
                    dataGridView1.Rows.Add(row);
                }
            }
        }
    }
}

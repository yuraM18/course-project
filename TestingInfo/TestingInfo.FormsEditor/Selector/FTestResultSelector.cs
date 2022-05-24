using Common.Forms;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TestingInfo.Data;
using TestingInfo.Entity;
using TestingInfo.FormsEditor.Editors;
using TestingInfo.FormsEditor.Extensions;
using TestingInfo.FormsEditor.Models;

namespace TestingInfo.FormsEditor.Selector
{
    public partial class FTestResultSelector : FBaseSelector
    {
        DataContext dataContext;
        FTestResultEditor editor = new FTestResultEditor();

        public FTestResultSelector(DataContext dataContext) : base(dataContext.TestResults)
        {
            this.dataContext = dataContext;
            InitializeComponent();
        }

        protected internal FTestResultSelector()
        {
            InitializeComponent();
        }

        protected override void DoCreateTestingData()
        {
            if (dataContext.IsEmpty())
            {
                dataContext.CreateTestingData();
                UpdateInfo();
                ShowStatusMessage("Тестові дані створено!");
            }
            else
            {
                ShowStatusMessage("Помилка! Сховище не порожнє!");
            }
        }

        protected new virtual TestResult SelectedInstance
        {
            get { return base.SelectedInstance as TestResult; }
        }

        protected override void DoShowDetails()
        {
            PrepareEditor(SelectedInstance, true);
            editor.ShowDialog();
        }

        private void PrepareEditor(TestResult inst, bool readOnly)
        {
            string[] macroregionsNames = dataContext.Tests
                .Select(el => el.Name).ToArray();
            editor.SetTestsNames(macroregionsNames);
            editor.Model = inst == null ? new TestResultModel()
                : (TestResultModel)inst;
            editor.ReadOnly = readOnly;
        }

        protected override void DoCreate()
        {
            PrepareEditor(null, false);
            if (editor.ShowDialog() != DialogResult.OK)
                return;
            TestResult newInst = editor.Model.ToTestResult(dataContext.Tests);
            newInst.Id = dataContext.TestResults.Count == 0 ? 1
                : dataContext.TestResults.Select(el => el.Id).Max() + 1;
            dataContext.TestResults.Add(newInst);
            UpdateInfo();
        }

        protected override void DoEdit()
        {
            PrepareEditor(SelectedInstance, false);
            if (editor.ShowDialog() != DialogResult.OK)
                return;
            UpdateInstance(SelectedInstance, editor.Model);
            UpdateInfo();
        }

        private void UpdateInstance(TestResult inst, TestResultModel model)
        {
            inst.Person = model.Person;
            inst.Test = dataContext.Tests
                .First(e => e.Name == model.Test);
            inst.DateTime = model.DateTime;
            inst.Bales = model.Bales;
            inst.Result = model.Result;
            inst.Note = model.Note;
        }


        protected override void DoDelete()
        {
            dataContext.TestResults.Remove(SelectedInstance);
            UpdateInfo();
        }

        protected override void DoSave()
        {
            dataContext.Save();
        }

        protected override void DoClear()
        {
            dataContext.Clear();
            UpdateInfo();
            ShowStatusMessage("Дані було видалено!");
        }
    }
}

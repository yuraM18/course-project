using Common.Events;
using Common.Forms;
using System.Linq;
using System.Windows.Forms;
using TestingInfo.Data;
using TestingInfo.Entity;
using TestingInfo.FormsEditor.Editors;
using TestingInfo.FormsEditor.Extensions;
using TestingInfo.FormsEditor.Models;

namespace TestingInfo.FormsEditor.Controllers
{
    public class TestsController
    {
        FSelector selector;
        DataContext dataContext;
        FTestEditor editor = new FTestEditor();

        public TestsController(DataContext dataContext, FSelector selector)
        {
            this.dataContext = dataContext;
            dataContext.DataChanged += DataContext_DataChanged;
            this.selector = selector;
            selector.TestingDataCreating += Selector_TestingDataCreating;
            selector.ObjectCreating += Selector_ObjectCreating;
            selector.ObjectReading += Selector_ObjectReading;
            selector.ObjectUpdating += Selector_ObjectUpdating;
            selector.ObjectDeleting += Selector_ObjectDeleting;
            selector.DataSaving += Selector_DataSaving;
        }

        private void Selector_DataSaving(object sender, CancelingEventArgs e)
        {
            dataContext.Save();
        }

        private void DataContext_DataChanged(object sender, System.EventArgs e)
        {
            selector.UpdateInfo();
        }

        private void Selector_ObjectCreating(object sender, ObjectEventArgs e)
        {
            //PrepareEditor(null, false);
            //if (editor.ShowDialog() != DialogResult.OK)
            //    return;
            //Test newInst = editor.Model.ToTest(dataContext.Test);
            //newInst.Id = dataContext.TestResults.Count == 0 ? 1
            //    : dataContext.TestResults.Select(el => el.Id).Max() + 1;
            //dataContext.Tests.Add(newInst);
            //UpdateViews();
        }

        private void PrepareEditor(Test inst, bool readOnly)
        {
            string[] testsNames = dataContext.Tests
                .Select(el => el.Name).ToArray();
            //editor.SetTestsNames(testsNames);
            editor.Model = inst == null ? new TestModel()
                : (TestModel)inst;
            editor.ReadOnly = readOnly;
        }

        private void UpdateViews()
        {
            selector.UpdateInfo();
        }

        private void Selector_ObjectReading(object sender, ObjectEventArgs e)
        {
            Test inst = e.Instance as Test;
            PrepareEditor(inst, true);
            editor.ShowDialog();
        }

        private void Selector_ObjectUpdating(object sender, ObjectEventArgs e)
        {
            Test inst = e.Instance as Test;
            PrepareEditor(inst, false);
            if (editor.ShowDialog() != DialogResult.OK)
                return;
            UpdateInstance(inst, editor.Model);
            UpdateViews();
        }

        private void UpdateInstance(Test inst, TestModel model)
        {
            inst.Name = model.Name;
            //inst.Topic = dataContext.Tests
            //    .First(e => e.Name == model.Topic);
            inst.Topic = model.Topic;
            inst.Bales = model.MaxBales;
            inst.Description = model.Description;
        }

        private void Selector_ObjectDeleting(object sender, ObjectEventArgs e)
        {
            Test inst = e.Instance as Test;
            dataContext.Tests.Remove(inst);
            UpdateViews();
        }

        private void Selector_TestingDataCreating(object sender, CancelingEventArgs e)
        {
            if (dataContext.IsEmpty())
            {
                dataContext.CreateTestingData();
                selector.UpdateInfo();
            }
            else
            {
                e.Cancel = true;
                e.Message = "Помилка! Сховище не порожнє!";
            }
        }
    }
}

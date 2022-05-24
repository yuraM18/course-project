using Common.Events;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Common.Forms
{
    public partial class FSelector : Form
    {
        IEnumerable<IStringIdentified> collection;

        public FSelector(IEnumerable<IStringIdentified> collection)
        {
            this.collection = collection;
            InitializeComponent();
        }

        internal FSelector()
        {
            InitializeComponent();
        }

        private void FSelector_Load(object sender, EventArgs e)
        {
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            ShowStatusMessage("Привіт!");
            SetControlsState();
        }

        private void SetControlsState()
        {
            ToolStripMenuItemDataRecordDetails.Enabled = listBoxIdentifiers.SelectedItems.Count == 1;
            ToolStripMenuItemDataRecordEdit.Enabled = ToolStripMenuItemDataRecordDetails.Enabled;
            ToolStripMenuItemDataRecordDelete.Enabled = listBoxIdentifiers.SelectedItems.Count > 0;
        }

        protected void ShowStatusMessage(string message)
        {
            toolStripStatusLabelMessage.Text = message;
        }

        public void UpdateInfo()
        {
            ShowIdentifiers();
            SetControlsState();
        }

        private void ShowIdentifiers()
        {
            listBoxIdentifiers.Items.Clear();
            listBoxIdentifiers.Items.AddRange(
                collection.Select(e => e.StringIdentifier).ToArray());
        }

        private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripMenuItemFileDataSave_Click(object sender, EventArgs e)
        {
            CancelingEventArgs eventArgs = new CancelingEventArgs();
            OnDataSaving(eventArgs);
            if (eventArgs.Cancel)
            {
                ShowStatusMessage(eventArgs.Message);
            }
            else
            {
                ShowStatusMessage("Дані збережено");
            }
        }

        public event EventHandler<CancelingEventArgs> DataSaving;

        protected virtual void OnDataSaving(CancelingEventArgs eventArgs)
        {
            if (DataSaving != null)
            {
                DataSaving.Invoke(this, eventArgs);
            }
        }

        private void ToolStripMenuItemDataTesting_Click(object sender, EventArgs e)
        {
            CancelingEventArgs eventArgs = new CancelingEventArgs();
            OnTestingDataCreating(eventArgs);
            if (eventArgs.Cancel)
            {
                ShowStatusMessage(eventArgs.Message);
            }
            else
            {
                ShowStatusMessage("Відображено тестові дані");
            }
        }

        public event EventHandler<CancelingEventArgs> TestingDataCreating;

        protected virtual void OnTestingDataCreating(CancelingEventArgs eventArgs)
        {
            if (TestingDataCreating != null)
            {
                TestingDataCreating.Invoke(this, eventArgs);
            }
        }

        private IStringIdentified SelectedInstance
        {
            get
            {
                return collection.First(
                    el => el.StringIdentifier == (string)listBoxIdentifiers.SelectedItem);
            }
        }

        public event EventHandler<ObjectEventArgs> ObjectReading;

        private void ToolStripMenuItemDataRecordDetails_Click(object sender, EventArgs e)
        {
            ObjectReading.Invoke(this, new ObjectEventArgs(SelectedInstance));
        }

        public event EventHandler<ObjectEventArgs> ObjectCreating;

        private void ToolStripMenuItemDataRecordCreate_Click(object sender, EventArgs e)
        {
            ObjectCreating.Invoke(this, new ObjectEventArgs(null));
        }

        public event EventHandler<ObjectEventArgs> ObjectUpdating;

        private void ToolStripMenuItemDataRecordEdit_Click(object sender, EventArgs e)
        {
            ObjectUpdating.Invoke(this, new ObjectEventArgs(SelectedInstance));
        }

        public event EventHandler<ObjectEventArgs> ObjectDeleting;

        private void ToolStripMenuItemDataRecordDelete_Click(object sender, EventArgs e)
        {
            ObjectDeleting.Invoke(this, new ObjectEventArgs(SelectedInstance));
        }

        private void listBoxIdentifiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetControlsState();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Common.Forms
{
    public partial class FBaseSelector : Form
    {
        IEnumerable<IStringIdentified> collection;

        public FBaseSelector(IEnumerable<IStringIdentified> collection)
        {
            this.collection = collection;
            InitializeComponent();
        }

        protected internal FBaseSelector()
        {
            InitializeComponent();
        }

        private void FBaseSelector_Load(object sender, EventArgs e)
        {
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            ShowStatusMessage("Привіт!");
            SetControlsState();
        }

        private void SetControlsState()
        {
            ToolStripMenuItemDataRecordDetails.Enabled =
                listBoxIdentifiers.SelectedItems.Count == 1;
            ToolStripMenuItemDataRecordEdit.Enabled =
                ToolStripMenuItemDataRecordDetails.Enabled;
            ToolStripMenuItemDataRecordDelete.Enabled =
                listBoxIdentifiers.SelectedItems.Count > 0;
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
            if (collection == null)
                return;
            listBoxIdentifiers.Items.Clear();
            listBoxIdentifiers.Items.AddRange(
                collection.Select(e => e.StringIdentifier).ToArray());
        }

        private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual IStringIdentified SelectedInstance
        {
            get
            {
                return collection.First(
                    el => el.StringIdentifier == (string)listBoxIdentifiers.SelectedItem);
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void ToolStripMenuItemFileDataSave_Click(object sender, EventArgs e)
        {
            DoSave();
        }

        protected virtual void DoSave()
        {
            throw new NotImplementedException();
        }

        private void ToolStripMenuItemDataTesting_Click(object sender, EventArgs e)
        {
            DoCreateTestingData();
        }

        protected virtual void DoCreateTestingData()
        {
            throw new NotImplementedException();
        }

        private void ToolStripMenuItemDataRecordDetails_Click(object sender, EventArgs e)
        {
            DoShowDetails();
        }

        protected virtual void DoShowDetails()
        {
            throw new NotImplementedException();
        }

        private void ToolStripMenuItemDataRecordCreate_Click(object sender, EventArgs e)
        {
            DoCreate();
        }

        protected virtual void DoCreate()
        {
            throw new NotImplementedException();
        }

        private void ToolStripMenuItemDataRecordEdit_Click(object sender, EventArgs e)
        {
            DoEdit();
        }

        protected virtual void DoEdit()
        {
            throw new NotImplementedException();
        }

        private void ToolStripMenuItemDataRecordDelete_Click(object sender, EventArgs e)
        {
            DoDelete();
        }

        protected virtual void DoDelete()
        {
            throw new NotImplementedException();
        }

        private void FBaseSelector_Shown_1(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void listBoxIdentifiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetControlsState();
        }

        private void ToolStripMenuItemDataClear_Click(object sender, EventArgs e)
        {
            DoClear();
        }

        protected virtual void DoClear()
        {
            throw new NotImplementedException();
        }
    }
}

using Common.Context.Extensions;
using Common.Context.LineIndents;
using System;
using System.Collections.Generic;
using TestingInfo.Entity;
using TestingInfo.Interfaces;
using TestingInfo.IO;

namespace TestingInfo.Data
{
    public partial  class DataContext
    {
        protected readonly DataSet dataSet = new DataSet();

        public ICollection<User> Users
        {
            get { return dataSet.Users; }
        }

        public ICollection<Test> Tests
        {
            get { return dataSet.Tests; }
        }

        public ICollection<TestResult> TestResults
        {
            get { return dataSet.TestResults; }
        }

        public bool IsEmpty()
        {
            return Tests.Count == 0 && TestResults.Count == 0 && Users.Count == 0;
        }

        //protected XmlFileIoController xmlFileIoController = new XmlFileIoController();

        private IFileIoController fileIoController;

        public IFileIoController FileIoController
        {
            get {
                if(fileIoController == null)
                {
                    fileIoController = new XmlFileIoController();
                }
                return fileIoController; }
            set { fileIoController = value; }
        }

        public static string fileName = "TestingInfo";

        public void Save()
        {
            FileIoController.Save(dataSet, fileName);
        }

        public void Load()
        {
            FileIoController.Load(dataSet, fileName);
            OnDataChanged();
        }

        public event EventHandler DataChanged;

        protected void OnDataChanged()
        {
            if(DataChanged != null)
            {
                DataChanged.Invoke(this, EventArgs.Empty);
            }
        }

        public override string ToString()
        {
            string s = "Інформація про об`єкти ПО \"Тести\"\n";
            LineIndent.Current.Increase();
            s += Users.ToIndentLineList(Test.EntityPluralName);
            s += Tests.ToIndentLineList(Test.EntityPluralName);
            s += TestResults.ToIndentLineList(TestResult.EntityPluralName);
            LineIndent.Current.Decrease();
            return s;
        }

        public void Clear()
        {
            Users.Clear();
            TestResults.Clear();
            Tests.Clear();
            OnDataChanged();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using TestingInfo.Data;
using TestingInfo.Entity;
using TestingInfo.Interfaces;

namespace TestingInfo.IO
{
    public class XmlFileIoController : IFileIoController
    {
        public string FileExtension { get; set; }

        public XmlFileIoController()
        {
            FileExtension = ".xml";
        }

        public void Save(DataSet dataSet, string fileName)
        {
            fileName = Path.ChangeExtension(fileName, FileExtension);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.Unicode;
            XmlWriter writer = null;
            try { writer = XmlWriter.Create(fileName, settings);
                WriteData(dataSet, writer);
            }
            catch (Exception) { throw; }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        void WriteData(DataSet dataSet, XmlWriter writer)
        {
            writer.WriteStartDocument();
            writer.WriteStartElement("TestinfInfo");
            WriteTest(dataSet.Tests, writer);
            WriteTestResult(dataSet.TestResults, writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
        }

        void WriteTestResult(IEnumerable<TestResult> collection, XmlWriter writer)
        {
            writer.WriteStartElement("TestResultsData");
            foreach( var inst in collection)
            {
                writer.WriteStartElement("TestResult");
                writer.WriteElementString("Id", inst.Id.ToString());
                writer.WriteElementString("Person", inst.Person.ToString());
                int testId = inst.Test == null ? 0 : inst.Test.Id;
                writer.WriteElementString("TestId", testId.ToString());
                writer.WriteElementString("Datetime", inst.DateTime.ToString());
                writer.WriteElementString("Bales", inst.Bales.ToString());
                writer.WriteElementString("Result", inst.Result);
                writer.WriteElementString("Note", inst.Note);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        void WriteTest(IEnumerable<Test> collection, XmlWriter writer)
        {
            writer.WriteStartElement("TestsData");
            foreach(var inst in collection)
            {
                writer.WriteStartElement("Test");
                writer.WriteElementString("Id", inst.Id.ToString());
                writer.WriteElementString("Name", inst.Name.ToString());
                writer.WriteElementString("Topic", inst.Topic.ToString());
                writer.WriteElementString("MaxBales", inst.Bales.ToString());
                writer.WriteElementString("Description", inst.Description);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        /*------------*\
        \*------------*/

        public void Load(DataSet dataSet, string fileName)
        {
            fileName = Path.ChangeExtension(fileName, FileExtension);
            if (!File.Exists(fileName)) return;

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            using (XmlReader reader = XmlReader.Create(fileName, settings))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        switch (reader.Name)
                        {
                            case "Test":
                                ReadTest(reader, dataSet);
                                break;
                            case "TestResult":
                                ReadTestResult(reader, dataSet);
                                break;
                        }
                    }
                }
            }
        }

        //void ReadTest(XmlReader reader, ICollection<Test> collection)
        void ReadTest(XmlReader reader, DataSet dataSet)
        {
            //reader.ReadStartElement("Test");
            //int id = reader.ReadElementContentAsInt();
            //string name = reader.ReadElementContentAsString();
            ////int topicId = reader.ReadElementContentAsInt();
            ////Test topic = collection
            ////    .FirstOrDefault(e => e.Id == topicId);
            //string topic = reader.ReadElementContentAsString();

            //Test inst = new Test(name, topic) { Id = id };
            //string bales = reader.ReadElementContentAsString();
            //inst.Bales = string.IsNullOrEmpty(bales)
            //    ? (int?)null : int.Parse(bales);
            //inst.Description = reader.ReadElementContentAsString();
            //collection.Add(inst);

            Test inst = new Test();
            reader.ReadStartElement("Test");
            inst.Id = reader.ReadElementContentAsInt();
            inst.Name = reader.ReadElementContentAsString();
            inst.Topic = reader.ReadElementContentAsString();
            //int userId = reader.ReadElementContentAsInt();
            //inst.Test = dataSet.Tests
            //    .FirstOrDefault(e => e.Id == testId);
            
            string bales = reader.ReadElementContentAsString();
            inst.Bales = string.IsNullOrEmpty(bales)
                ? (int?)null : int.Parse(bales);
            inst.Description = reader.ReadElementContentAsString();
            dataSet.Tests.Add(inst);
        }

        void ReadTestResult(XmlReader reader, DataSet dataSet)
        {
            TestResult inst = new TestResult();
            reader.ReadStartElement("TestResult");
            inst.Id = reader.ReadElementContentAsInt();
            inst.Person = reader.ReadElementContentAsString();
            int testId = reader.ReadElementContentAsInt();
            inst.Test = dataSet.Tests
                .FirstOrDefault(e => e.Id == testId);
            string date = reader.ReadElementContentAsString();
            inst.DateTime = string.IsNullOrEmpty(date)
                ? (DateTime?)null : DateTime.Parse(date);
            string bales = reader.ReadElementContentAsString();
            inst.Bales = string.IsNullOrEmpty(bales)
                ? (int?)null : int.Parse(bales);
            inst.Result = reader.ReadElementContentAsString();
            inst.Note = reader.ReadElementContentAsString();
            dataSet.TestResults.Add(inst);
        }
    }
}

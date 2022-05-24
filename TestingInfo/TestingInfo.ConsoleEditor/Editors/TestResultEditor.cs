using Common.ConsoleIO;
using Common.ConsoleUI;
using Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using TestingInfo.Data;
using TestingInfo.Entity;

namespace TestingInfo.ConsoleEditor.Editors
{
    public class TestResultEditor : CommandManager
    {
        protected override void IniCommandsInfo()
        {
            commandsInfo = new CommandInfo[] {
                new CommandInfo("вийти", null,() => true),
                new CommandInfo("додати запис ...", Add,() => true),
                new CommandInfo("видалити запис ...", Remove,() => dataContext.TestResults.Count > 0),
                new CommandInfo("сортувати за назвою", SortByName,() => dataContext.TestResults.Count > 0),
                new CommandInfo("сортувати за назвою тетсу", SortByTest,() => dataContext.TestResults.Count > 0),
                new CommandInfo("сортувати за датою", SortByDateTime,() => dataContext.TestResults.Count > 0),
                new CommandInfo("сортувати за балами", SortByBales,() => dataContext.TestResults.Count > 0),
            };
        }

        private readonly DataContext dataContext;
        IEnumerable<TestResult> sortingCollection;

        public TestResultEditor (DataContext dataContext)
        {
            if (dataContext == null)
            {
                throw new ArgumentNullException("dataContext");
            }
            this.dataContext = dataContext;
            sortingCollection = dataContext.TestResults;
        }

        protected override void PrepareScreen()
        {
            Console.Clear();
            OutData();
            Console.WriteLine(); 
        }

        private void OutData()
        {
            Console.WriteLine("Результати тетсування:");
            foreach (var obj in sortingCollection)
            {
                Console.WriteLine($"{obj.Id,7} {obj.Person,-15} {(obj.Test == null ? "" : obj.Test.StringIdentifier),-20}" +
                    $"дата:{obj.DateTime,-15} бали:{obj.Bales}");
            }
        }

        public void Add()
        {
            TestResult inst = new TestResult();
            inst.Person = Entering.EnterString("ПІБ особи");
            inst.Test = SelectTest();
            inst.DateTime = Entering.DateTime("Дата і час:");
            inst.Bales = Entering.EnterInt32("Бали", 0, 5);
            inst.Result = Entering.EnterString("Результат");
            inst.Note = Entering.EnterString("Примітка");
            try { inst.Id = dataContext.TestResults.Select(e => e.Id).Max() + 1; }
            catch { inst.Id = 1; }
            dataContext.TestResults.Add(inst);
        }


        private Test SelectTest()
        {
            string testName = Entering.EnterString("назва тесту:");
            Test inst = dataContext.Tests.FirstOrDefault(e => e.Name == testName);
            return inst;
        }

        public void Remove()
        {
            int id = Entering.EnterInt32("Введіть код об`єкта");
            TestResult inst = dataContext.TestResults.FirstOrDefault(e => e.Id == id);
            dataContext.TestResults.Remove(inst);
        }

        private void SortByName()
        {
            sortingCollection = sortingCollection.OrderBy(e => e.Person);
        }

        private void SortByTest()
        {
            sortingCollection = sortingCollection.OrderBy(e => e.Test.Name);
        }

        private void SortByDateTime()
        {
            sortingCollection = sortingCollection.OrderBy(e => e.DateTime);
        }

        private void SortByBales()
        {
            sortingCollection = sortingCollection.OrderBy(e => e.Bales);
        }
    }
}

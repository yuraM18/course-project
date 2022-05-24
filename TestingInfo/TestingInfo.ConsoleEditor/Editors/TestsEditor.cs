using Common.ConsoleIO;
using Common.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using TestingInfo.Data;
using TestingInfo.Entity;

namespace TestingInfo.ConsoleEditor.Editors
{
    public class TestsEditor : CommandManager
    {
        protected override void IniCommandsInfo()
        {
            commandsInfo = new CommandInfo[] {
                new CommandInfo("вийти", null,() => true),
                new CommandInfo("додати запис ...", Add,() => true),
                new CommandInfo("видалити запис ...", Remove,() => dataContext.Tests.Count > 0),
                new CommandInfo("сортувати за назвою", Sort,() => dataContext.Tests.Count > 0),
                new CommandInfo("сортувати за темою",
                    SortByTopic,() => dataContext.Tests.Count > 0),
                new CommandInfo("сортувати за балами", SortByMaxBales,() => dataContext.Tests.Count > 0),
           };
        }

        protected override void PrepareScreen()
        {
            Console.Clear();
            OutData();
            Console.WriteLine();
        }

        private void OutData()
        {
            Console.WriteLine("Тести:");
            foreach (var obj in sortingCollection)
            {
                Console.WriteLine("{0,7} {1,-24}",
                    obj.Id, obj.Name);
            }
        }

        private readonly DataContext dataContext;
        private IEnumerable<Test> sortingCollection;

        public TestsEditor(DataContext dataContext)
        {
            if(dataContext == null)
            {
                throw new ArgumentNullException("dataContext");
            }
            this.dataContext = dataContext;
            sortingCollection = dataContext.Tests;
        }

        public void Add()
        {
            string name = Entering.EnterString("Назва тесту");
            //Test topic = SelectTopic();
            string topic = Entering.EnterString("Назва теми");
            User user = new User("admin", "admin");
            Test inst = new Test("Ієрархія класів", null, user);
            inst.Bales = Entering.EnterInt32("Максимальний бал");
            inst.Description = Entering.EnterString("Опис");
            try { inst.Id = dataContext.Tests.Select(e => e.Id).Max() + 1; }
            catch { inst.Id = 1; }
            dataContext.Tests.Add(inst);
        }

        private Test SelectTopic()
        {
            string testName = Entering.EnterString("Назва теми");
            Test inst = dataContext.Tests.FirstOrDefault(e => e.Name == testName);
            return inst;
        }

        public void Remove()
        {
            int id = Entering.EnterInt32("Введіть код об`єкта");
            Test inst = dataContext.Tests.FirstOrDefault(e => e.Id == id);
            //if (DeletingIsAcceptable(inst))
            //{
            //    dataContext.Tests.Remove(inst);
            //}
            dataContext.Tests.Remove(inst);
        }

        //private bool DeletingIsAcceptable(Test inst)
        //{
        //    if (dataContext.Tests.Any(e => e.Topic == inst))
        //    {
        //        Console.WriteLine("Спроба видалити об'єкт, "
        //            + " що представляє назву теста \""
        //            + inst.Name + "\", який є об'єктом "
        //            + "вищого рівня ієрархії (Test)");
        //        RequestForContinuation();
        //        return false;
        //    }
        //    if (dataContext.TestResults.Any(e => e.Test == inst))
        //    {
        //        Console.WriteLine("Спроба видалити об'єкт, "
        //            + "що представляє назву теста \""
        //            + inst.Name + "\"");
        //        RequestForContinuation();
        //        return false;
        //    }
        //    return true;
        //}

        private void Sort()
        {
            sortingCollection = sortingCollection.OrderBy(e => e);
        }

        private void SortByTopic()
        {
            sortingCollection = sortingCollection.OrderBy(e => e.Topic/* == null ? null : e.Topic.Name*/);
        }

        private void SortByMaxBales()
        {
            sortingCollection = sortingCollection.OrderBy(e => e.Bales);
        }
    }
}

using Common.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingInfo.ConsoleEditor.Editors;
using TestingInfo.Data;

namespace TestingInfo.ConsoleEditor.ConsoleUI
{
    public class MainManager : CommandManager
    {
        protected override void IniCommandsInfo()
        {
            commandsInfo = new CommandInfo[] {
                new CommandInfo("завершити роботу", null,() => true),
                new CommandInfo("створити тестові дані", CreateTestingData,() => dataContext.Tests.Count == 0),
                new CommandInfo("зберегти дані", Save,() => dataContext.Tests.Count > 0),
                new CommandInfo("показати як текст", ShowAsText,() => dataContext.Tests.Count > 0),
                new CommandInfo("видалити всі дані", Clear,() => dataContext.Tests.Count > 0),
                new CommandInfo("редагування даних про тест ->", RunTestsEditing,() => true),
                new CommandInfo("редагування даних про результат тестування ->",
                    RunTestResultEditing,() => dataContext.Tests.Count > 0),
            };
        }

        private DataContext dataContext;
        private TestsEditor testsEditor;
        private TestResultEditor testResultEditor;

        public MainManager(DataContext dataContext)
        {
            this.dataContext = dataContext;
            testsEditor = new TestsEditor(dataContext);
            testResultEditor = new TestResultEditor(dataContext);
        }

        protected override void PrepareScreen()
        {
            Console.Clear();
            OutStatistics();
        }

        private void OutStatistics()
        {
            Console.WriteLine("Інформація про об`єкти ПО \"Тести\"");
            Console.WriteLine("\n Представлено:\n" +
                $"{dataContext.Tests.Count,7} тестів\n" +
                $"{dataContext.TestResults.Count,7} результатів тестів\n");
        }

        protected override void PrepareRunning()
        {
            dataContext.Load();
        }

        private void CreateTestingData()
        {
            dataContext.CreateTestingData();
        }

        private void Save()
        {
            dataContext.Save();
            Console.WriteLine("\n Дані збережено");
            RequestForContinuation();
        }

        private void ShowAsText()
        {
            Console.WriteLine();
            Console.WriteLine(dataContext);
            RequestForContinuation();
        }

        private void Clear()
        {
            dataContext.Clear();
        }

        private void RunTestsEditing()
        {
            testsEditor.Run();
        }

        private void RunTestResultEditing()
        {
            testResultEditor.Run();
        }
    }
}

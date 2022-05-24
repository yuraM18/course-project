using Common.ConsoleIO;
using System;
using TestingInfo.ConsoleEditor.ConsoleUI;
using TestingInfo.Data;

namespace TestingInfo.ConsoleEditor
{
    class Program
    {
        static DataContext dataContext;
        static MainManager mainManager;

        static void Main(string[] args)
        {
            Console.Title = "TestingInfo.ConsoleEditor";
            Settings.SetConsoleParam();
            Console.WriteLine("Редактор даних предменої області");

            dataContext = new DataContext();
            mainManager = new MainManager(dataContext);
            mainManager.Run();
        }
    }
}

using Common.ConsoleIO;
using System;

namespace Common.ConsoleUI
{
    public abstract class CommandManager
    {
        protected CommandInfo[] commandsInfo;

        protected abstract void IniCommandsInfo();

        protected abstract void PrepareScreen();

        public CommandManager()
        {
            IniCommandsInfo();
        }

        protected virtual void PrepareRunning() { }

        public void Run()
        {
            PrepareRunning();
            while (true)
            {
                PrepareScreen();
                ShowCommandsMenu();
                Command command = EnterCommand();
                if (command == null)
                {
                    return;
                }
                command();
            }
        }

        private void ShowCommandsMenu()
        {
            Console.WriteLine("  Список команд меню:");
            for (int i = 0; i < commandsInfo.Length; i++)
            {
                if (commandsInfo[i].isVisible())
                    Console.WriteLine($"\t{i,2} - {commandsInfo[i].name}");
            }
        }

        private Command EnterCommand()
        {
            Console.WriteLine();
            int number = Entering.EnterInt32(
                "Введіть номер команди меню", 0, commandsInfo.Length - 1);
            return commandsInfo[number].command;
        }

        protected virtual void RequestForContinuation()
        {
            Console.Write("\nДля продовження роботи програми "
                + "натисніть довільну клавішу...");
            Console.ReadKey(true);
        }
    }
}

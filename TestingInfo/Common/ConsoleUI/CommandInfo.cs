namespace Common.ConsoleUI
{
    public delegate void Command();
    public delegate bool IsVisible();

    public struct CommandInfo
    {
        public bool IsTrue() { return true; }

        public string name;
        public Command command;
        public IsVisible isVisible;

        public CommandInfo(string name, Command command,
                IsVisible isVisible)
        {
            this.name = name;
            this.command = command;
            this.isVisible = isVisible;
        }
    }
}

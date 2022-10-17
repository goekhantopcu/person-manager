namespace verwaltungsapp.view;

public class ExitCommand: ICommand
{
    public string Name() => "beenden";

    public void Execute(string[] args)
    {
        Console.WriteLine("[SYSTEM] Das Programm wird beendet");
        Environment.Exit(0);
    }
}
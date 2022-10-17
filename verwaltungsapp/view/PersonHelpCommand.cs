namespace verwaltungsapp.view;

public class PersonHelpCommand: ICommand
{
    public string Name() => "hilfe";

    public void Execute(string[] args)
    {
        Console.WriteLine(" ");
        Console.WriteLine("[SYSTEM] beenden");
        Console.WriteLine("[SYSTEM] anlegen <Vorname> <Nachname> <Geburtsdatum>");
        Console.WriteLine("[SYSTEM] löschen <Id>");
        Console.WriteLine("[SYSTEM] filtern <Nachname>");
        Console.WriteLine("[SYSTEM] auflisten");
        Console.WriteLine("[SYSTEM] laden");
        Console.WriteLine("[SYSTEM] sichern");
        Console.WriteLine(" ");
    }
}
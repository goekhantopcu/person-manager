using verwaltungsapp.control;

namespace verwaltungsapp.view;

public class PersonFilterCommand: ICommand
{
    private readonly PersonManager _manager;

    public PersonFilterCommand(PersonManager manager)
    {
        _manager = manager;
    }

    public string Name() => "filtern";

    public void Execute(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("[SYSTEM] Verwende: filtern <Nachname>");
            return;
        }
        var lastName = args[0];
        var filtered = _manager.FilterPerson(lastName);
        if (filtered.Count <= 0)
        {
            Console.WriteLine("[SYSTEM] Es gibt keine Einträge zu '"+lastName+"'");
            return;
        }
        filtered.ForEach(person => Console.WriteLine(person.ToString()));
    }
}
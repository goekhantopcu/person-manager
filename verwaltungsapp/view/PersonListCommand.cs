using verwaltungsapp.control;

namespace verwaltungsapp.view;

public class PersonListCommand: ICommand
{
    private readonly PersonManager _manager;

    public PersonListCommand(PersonManager manager)
    {
        _manager = manager;
    }

    public string Name() => "auflisten";

    public void Execute(string[] args)
    {
        var persons = _manager.Persons;
        if (persons.Count <= 0)
        {
            Console.WriteLine("[SYSTEM] Die Liste der Personen ist leer!");
            return;
        }
        persons.ForEach(person => Console.WriteLine(person.ToString()));
    }
}
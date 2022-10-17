using verwaltungsapp.control;

namespace verwaltungsapp.view;

public class PersonSaveCommand: ICommand
{
    private readonly PersonManager _manager;

    public PersonSaveCommand(PersonManager manager)
    {
        _manager = manager;
    }

    public string Name() => "sichern";

    public void Execute(string[] args)
    {
        var persons = _manager.Persons.ConvertAll(person => person.ToString());
        File.WriteAllLines(Directory.GetCurrentDirectory() + "/persons.txt", persons);
    }
}
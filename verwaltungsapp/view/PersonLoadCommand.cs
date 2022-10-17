using System.Globalization;
using System.Text;
using verwaltungsapp.control;
using verwaltungsapp.model;

namespace verwaltungsapp.view;

public class PersonLoadCommand: ICommand
{
    private readonly PersonManager _manager;

    public PersonLoadCommand(PersonManager manager)
    {
        _manager = manager;
    }

    public string Name() => "laden";

    public void Execute(string[] args)
    {
        var values = File.ReadAllLines(Directory.GetCurrentDirectory() + "/persons.txt", Encoding.UTF8).ToList();
        values.ForEach(Load);
    }

    private void Load(string value)
    {
        var data = value.Split(",");
        var id = int.Parse(data[0]);
        var firstName = data[1];
        var lastName = data[2];
        var fromCulture = new CultureInfo("de-DE");
        if (
                DateTime.TryParseExact(
                    data[3],
                    fromCulture.DateTimeFormat.ShortDatePattern,
                    fromCulture,
                    DateTimeStyles.None, 
                    out var dateOfBirth
                )
            )
        {
            var person = new Person(id, firstName, lastName, dateOfBirth);
            _manager.AddPerson(person);
            Console.WriteLine("[SYSTEM] Person " + firstName + " " + lastName + " geladen");
        }
        else
        {
            Console.WriteLine("[SYSTEM] Konnte Person nicht laden");
        }
    }
}
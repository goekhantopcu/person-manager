using System.Globalization;
using verwaltungsapp.control;
using verwaltungsapp.model;

namespace verwaltungsapp.view;

public class PersonCreateCommand: ICommand
{
    private readonly PersonManager _manager;

    public PersonCreateCommand(PersonManager manager)
    {
        _manager = manager;
    }

    public string Name() => "anlegen";

    public void Execute(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("[SYSTEM] Verwende: anlegen <Vorname> <Nachname> <Geburtsdatum>");
            return;
        }
        var firstName = args[0];
        var lastName = args[1];
        CultureInfo fromCulture = new CultureInfo("de-DE");
        DateTime tryParseDateTime;
        if (DateTime.TryParseExact(args[2], fromCulture.DateTimeFormat.ShortDatePattern, fromCulture, DateTimeStyles.None, out tryParseDateTime))
        {
            var person = new Person(
                _manager.Persons.Count + 1,
                firstName,
                lastName,
                tryParseDateTime
            );
            _manager.AddPerson(person);
            Console.WriteLine("[SYSTEM] Person " + firstName + " " + lastName + " hinzugefügt");
        }
        else
        {
            Console.WriteLine("[SYSTEM] Falsches Format für das Geburtsdatum angegeben (dd.MM.yyyy)");
        }
    }
}
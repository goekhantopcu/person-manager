using verwaltungsapp.model;

namespace verwaltungsapp.control;

public class PersonManager
{
    private readonly List<Person> _persons = new();

    public List<Person> Persons => _persons;

    public bool Exists(string firstName, string lastName)
    {
        return _persons.Exists(person =>
            person.FirstName.ToLower().Equals(firstName.ToLower()) &&
            person.LastName.ToLower().Equals(lastName.ToLower())
        );
    }
    
    public bool RemovePerson(int id)
    {
        return _persons.RemoveAll(person => person.Id.Equals(id)) != 0;
    }

    public void AddPerson(Person person)
    {
        _persons.Add(person);
    }

    public List<Person> FilterPerson(string lastName)
    {
        return _persons.FindAll(person => person.LastName.ToLower().Equals(lastName.ToLower()));
    }

    /*
     * X Alle Personen auflisten
     * X Eine Person löschen
     * X Eine Person hinzufügen
     * X Nach Personen mit bestimmtem Nachnamen suchen
     */
}
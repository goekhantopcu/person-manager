namespace verwaltungsapp.model;

public class Person
{
    private readonly int _id;

    public int Id => _id;

    private string _firstName;
    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }
    
    private string _lastName;
    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }
    
    private DateTime _dateOfBirth;
    public DateTime DateOfBirth
    {
        get => _dateOfBirth;
        set => _dateOfBirth = value;
    }

    public Person(int id, string firstName, string lastName, DateTime dateOfBirth)
    {
        _id = id;
        _firstName = firstName;
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
    }

    public override string ToString()
    {
        return _id + "," + _firstName + "," + _lastName + "," + _dateOfBirth.ToString("dd.MM.yyyy");
    }
}
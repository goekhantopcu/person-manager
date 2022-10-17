namespace verwaltungsapp;

public class Student : Person
{
    public DateTime TimeOfMatriculation;
    public string FieldOfStudy;

    public Student(
        string firstName,
        string lastName,
        DateTime dateOfBirth,
        DateTime timeOfMatriculation,
        string fieldOfStudy
    ) : base(firstName, lastName, dateOfBirth)
    {
        TimeOfMatriculation = timeOfMatriculation;
        FieldOfStudy = fieldOfStudy;
    }
}
namespace SingleResponsibilityPrinciple;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public override string ToString()
    {
        return $"{LastName} {FirstName}, {DateOfBirth:d}";
    }
}
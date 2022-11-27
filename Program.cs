using SingleResponsibilityPrinciple;

var person = new Person
{
    FirstName = "Andrey",
    LastName = "Starinin",
    DateOfBirth = new DateTime(1986, 2, 18)
};

ConsolePrint.PrintInfo($"Персона: {person}");
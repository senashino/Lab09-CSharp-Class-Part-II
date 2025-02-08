Person.name = "Kannika";
Console.WriteLine(Person.GetName());
var student = new Student();
student.name = "Phugun";
Console.WriteLine(Person.GetName());
Console.WriteLine($"Student name: {student.name}");
static class Person
{
    static public string? name;
    static public string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student 
{
    public string? name;
}
﻿Person.name = "Kannika";
Console.WriteLine(Person.GetName());

static class Person
{
    static public string? name;
    static public string GetName()
    {
        return $"Hello form {name}";
    }
}
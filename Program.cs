using System;
using System.Collections.Generic;
using System.Text.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Example
{
    public static void Main()
    {
        List<Person> people = new List<Person>()
        {
            new Person { Name = "John", Age = 42 },
            new Person { Name = "Jane", Age = 36 },
            new Person { Name = "Joe", Age = 28 }
        };

        string jsonString = JsonSerializer.Serialize(people);
        Console.WriteLine(jsonString);
    }
}

using System.Text.Json;

namespace JsonTest;

public class Json{
    public static void Run(){
        var person = new Person{Id = 42, Name = "Towel"};
        var jsonPerson = JsonSerializer.Serialize(person);
        Console.WriteLine(jsonPerson);

        var jsonToConvert = "{\"Id\": 42, \"Name\": \"Towel\"}";
        var convertedPerson = JsonSerializer.Deserialize<Person>(jsonToConvert);
        Console.WriteLine(convertedPerson.Id);
        Console.WriteLine(convertedPerson.Name);
    }
}

public class Person{
    public int Id { get; set; }
    public string Name { get; set; }
}

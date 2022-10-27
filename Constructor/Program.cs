internal class Program
{
    private static void Main(string[] args)
    {
        ExampleClass example = new ExampleClass(1,"Sahin");

        ExampleClass example2 = new ExampleClass(example);

        //Person p = new Person();
        
    }
}

public class ExampleClass
{
    public int Id { get; set; }
    public string Name { get; set; }

    public static decimal MinSalary { get; set; }

    static ExampleClass()
    {
        MinSalary = 10000;
        Console.WriteLine("Assigned minimum salary");
    }

    public ExampleClass(int id,string name)
    {
        Name = name;
        Id = id;
    }
    public ExampleClass(ExampleClass entity) 
    {
        Id = entity.Id;
        Name = entity.Name;
    }
}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    private Person()
    {
        Id = 0;
        Name = "John";
        Surname = "Doe";
    }
}

public class StaticConstructorClass
{
    public string Name { get; set; }
    public string Surname { get; set; }

    // Parametresiz olmalidir.

    //static StaticConstructorClass(string name,string surname)
    //{
    //    Name = name;
    //    Surname = surname;
    //}
}


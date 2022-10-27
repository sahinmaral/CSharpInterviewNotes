// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class StructVsClass
{
    public static void Main(string[] args)
    {
        // Struct lar uzerinden miras alinamaz
        
        // Struct is value type but Class is reference type
        
        // Structs' property's default access modifier is public but
        // Class' property/s default access modifier is private
        
        // Due to struct placed at stack , struct is faster than class 
        
        Square square = new Square();
        square.width = 2;
        square.height = 2;
        
        Console.WriteLine(square.calculateArea());
        
        Person person = new Person();
        person.height = 1.73M;
        Console.WriteLine(person.height);
    }
    
}

public class Shape{
   public decimal width;
   public decimal height;
}

public class Square:Shape{
    public decimal calculateArea(){
        return this.width * this.height;
    }
}

public struct Person{
    public decimal height;
    public decimal width;
    
    /*
    public Person(){
        
    }
    */
}

/*
public struct Employee:Person{
    
} */

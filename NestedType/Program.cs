using System;

public class NestedType
{
    public static void Main(string[] args)
    {
		Shape.Molecule molecule = new Shape.Molecule();
		molecule.density = 1.2m;
		
		Console.WriteLine(molecule.density);
		
    }
    
}

public class Shape{
   public decimal width;
   public decimal height;
   
   public class Molecule{
	   public decimal density;
   }
}

public class Square:Shape{
    public decimal calculateArea(){
        return this.width * this.height;
    }
}


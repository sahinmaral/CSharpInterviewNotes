internal class Program{
	private static void Main(string[] args){
		
		// Person.MinSalary = 10000;
		
		Employee e = new Employee("Jack","Johnson","Hardware");

		
		e.Name = "Jack";
		e.Surname = "Johnson";

		Console.WriteLine(e.Name);
		Console.WriteLine(e.Surname);

		// Cannot create new instance
		// Person p = new Person();
		
		e.Work();
		e.GetSalary();
		e.Live();
		
		Console.WriteLine("-----------------------------");
		
		Person p = new Manager();
		p.Name = "Adam";
		p.Surname = "Johnson";
		
		// Cannot access static property
		// p.MinSalary = 10000;
		
		p.GetSalary();
		p.Live();
		p.ShowMinSalary();
		
		Employee e1 = new Employee("Sahin","MARAL","Hardware");
		e1.ShowMinSalary();
		Console.WriteLine($"e1 name : {e1.Name}");
	}
}

public class Employee : Person{
	public string WorkingProject {get;set;}
	
	public Employee(string name,string surname,string workingProject):base(name,surname){
		base.Name = name;
		base.Surname = surname;
		WorkingProject = workingProject;
	}
	
	public override void Work(){
		Console.WriteLine("Employee is working");
	}
	
	public override void GetSalary(){
		Console.WriteLine("Employee got their salary");
	}
}

public class Manager : Person{	
	public string Department {get;set;}
	
	public override void Work(){
		Console.WriteLine("Manager is working");
	}
	
	public override void GetSalary(){
		Console.WriteLine("Manager got their salary");
	}
}

public abstract class Person {
	public string Name {get;set;}
	public string Surname {get;set;}
	
	public static decimal MinSalary {get;set;}
	
	public Person(){
		MinSalary = 20000;
	}
	
	public Person(string name,string surname,decimal minSalary){
		Name = name;
		Surname = surname;
		MinSalary = minSalary;
	}
	
	public Person(string name,string surname):base(){
		Name = name;
		Surname = surname;
		
	}
	
	public virtual void Work(){
		Console.WriteLine("Person is working");
	}
	
	public abstract void GetSalary();
	
	public void Live(){
		Console.WriteLine("Person is living");
	}
	
	public void ShowMinSalary(){
		Console.WriteLine($"MinSalary : {MinSalary}");
	}
}

// private interface IDatabaseService{
	
// }

// Abstract ve interface farklari

/* 
	Interface ler uzerinde property ve metotlara sahip olurken
	Abstract larda property , field ve metotlara da sahip olabilir.
	
	Abstract siniflar sadece tek bir siniftan miras alabilirken
	interface ler birden fazla interface ler ile miras alabilir.
	
	Interface uzerinde erisim belirleyici yokken abstract siniflarda vardir
	
	Interface lerde metot govdeli olamazken abstract siniflarda mevcuttur
	
	
*/


	
	
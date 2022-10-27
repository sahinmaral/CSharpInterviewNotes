internal class Program
{

    private static void Main(string[] args)
    {
        HelloDelegate helloDelegate2 = new HelloDelegate(WriteHello);
        helloDelegate2 += WriteTest;
        helloDelegate2 += WriteHello;
        helloDelegate2("test");

        Console.WriteLine("----------");

        HelloDelegate helloDelegate = WriteHello;
        helloDelegate += WriteTest;

        //helloDelegate.Invoke("test");

        helloDelegate("test");

        Console.WriteLine("----------");

        Employee e1 = new Employee("Sahin","MARAL",1000,1);
        Employee e2 = new Employee("Ali","MARAL",2000,2);
        Employee e3 = new Employee("Ahmet","MARAL",3000,3);
        Employee e4 = new Employee("Hasan","MARAL",4000,4);
        Employee e5 = new Employee("Mehmet","MARAL",5000,5);

        List<Employee> employees = new List<Employee>();
        employees.Add(e1);
        employees.Add(e2);
        employees.Add(e3);
        employees.Add(e4);
        employees.Add(e5);

        //PromotionBySalary(employees, 3000);
        //PromotionByExperience(employees, 3);

        // Best practice

        Employee.PromotionFilter(employees, e => e.Salary > 2000 && e.Experience == 3);
    }

    public static void WriteHello(string message)
    {
        Console.WriteLine($"Message : Hello , world");
    }

    public static void WriteTest(string message)
    {
        Console.WriteLine($"Message : Test");
    }

}

public delegate void HelloDelegate(string message);
//public delegate bool PromotionByFilterDelegate(Employee employee);

public class Employee
{
    public decimal Salary { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Experience { get; set; }

    public Employee(string name, string surname, decimal salary,int experience)
    {
        Experience = experience;
        Surname = surname;
        Name = name;
        Salary = salary;
    }

    //public static void PromotionBySalary(List<Employee> employees, decimal salary)
    //{
    //    foreach (Employee employee in employees)
    //    {
    //        if (employee.Salary >= salary)
    //        {
    //            Console.WriteLine($"{employee.Name} , {employee.Surname}");
    //        }
    //    }
    //}

    //public static void PromotionByExperience(List<Employee> employees, int experience)
    //{
    //    foreach (Employee employee in employees)
    //    {
    //        if (employee.Experience >= experience)
    //        {
    //            Console.WriteLine($"{employee.Name} , {employee.Surname}");
    //        }
    //    }
    //}

    public static void PromotionFilter(List<Employee> employees, Func<Employee,bool> promotionDelegate)
    {
        foreach (Employee employee in employees)
        {
            if (promotionDelegate(employee))
            {
                Console.WriteLine($"{employee.Name} , {employee.Surname}");
            }
        }
    }
}



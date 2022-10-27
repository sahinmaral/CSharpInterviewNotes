using CommonTopics;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SumAllValues(1, 2, 3, 4, 5));

        int value = 5;
        Console.WriteLine(value.Sum(3));

        // Kacis karakterleri

        Console.WriteLine("Sahin \nMARAL");
        Console.WriteLine("Sahin \\MARAL");
        Console.WriteLine("Sahin \"MARAL\"");

        Console.WriteLine(Sum(1, 2));
        Console.WriteLine(Sum(1, 2, 5));
    }

    // Method overloading

    public static int Sum(int value1, int value2)
    {
        return value1 + value2;
    }

    public static int Sum(params int[] values)
    {
        return values.Sum(x => x);
    }

    /// <summary>
    /// Params kullanimi
    /// </summary>
    /// <param name="numbers">Sinirsiz sayida parametre yazacaksak</param>
    /// <returns></returns>
    public static int SumAllValues(params int[] numbers)
    {
        return numbers.Sum(x => x);
    }
}
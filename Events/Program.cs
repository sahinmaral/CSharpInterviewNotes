internal class Program
{
    private static void Main(string[] args)
    {
        Car c = new Car();
        c.Model = "BMW";
        c.Speed = 50;

        //c.speedEvent += SpeedEventTriggered;
        c.speedEvent += (speedValue) =>
        {
            Console.WriteLine($"You crossed speed limit \nCurrent speed limit {speedValue}");
        };

        c.Speed += 40;

    }

    private static void SpeedEventTriggered(int speedValue)
    {
        Console.WriteLine($"You crossed speed limit \nCurrent speed limit {speedValue}");
    }
}

//public delegate void SpeedDelegate(int speedValue);

public class Car
{
    private int _speed;
    public event Action<int> speedEvent;

    public string Model { get; set; }
    public int Speed { get { return _speed; } set 
        {
            if(value > 80 && speedEvent != null)
            {
                speedEvent(value);
            }
            else
            {
                _speed = value;
            }
        } 
    
    }
}
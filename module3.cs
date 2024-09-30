public class Car
{
    public string Make { get; }
    public string Model { get; }
    public int Year { get; }

    // Overloaded constructors
    public Car(string make, string model)
    {
        Make = make;
        Model = model;
        Year = 2024; // default year
    }

    public Car(string make, string model, int year) : this(make, model)
    {
        Year = year;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Car: {Make} {Model} {Year}");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car("Toyota", "Corolla");
        Car car2 = new Car("Ford", "Mustang", 1967);

        car1.PrintDetails(); // Output: Car: Toyota Corolla 2024
        car2.PrintDetails(); // Output: Car: Ford Mustang 1967
    }
}
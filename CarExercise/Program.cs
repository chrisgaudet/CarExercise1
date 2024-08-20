using System;

namespace CarExercise;

public class Program
{
    public static void Main(string[] args)
    {
        Car carSpecs = new Car();

        carSpecs.Make = "Ford";
        carSpecs.Model = "F-150";
        carSpecs.Year = 2024;

        var Toyota = new Car("Toyota", "Camry", 2022);

        var carList = new List<Car>() { carSpecs, Toyota };
        
        foreach (var car in carList)
        {
            Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Task1;
internal class Program
{
    private static void Main(string[] arg)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        List<Vehicle> cars = new List<Vehicle>
        {
            new Truck("Kenworth", "W990", 2019, 7055000, 36, 3),
            new Car("Daewoo", "Lanos", 2004, 85000, 4, "Petrol"),
            new Motorcycle("Harley-Davidson", "CVO Road Glide ST", 2025, 3015000, 1977, false),
        };
        
        Console.WriteLine("=== Інформація про транспортні засоби ===\n");
        double totalTax = 0;
        Vehicle fastest = cars[0];
        foreach (Vehicle vehicle in cars)
        {
            Console.WriteLine(vehicle.DisplayInfo());
            totalTax += vehicle.CalculateTax();
            if (vehicle.GetMaxSpeed() > fastest.GetMaxSpeed()) fastest = vehicle;
        }
        Console.WriteLine($"Загальна сума податків: {totalTax} грн");
        Console.WriteLine($"Найшвидший транспорт {fastest.GetBrand()} {fastest.GetModel()} {fastest.GetYear()} зі швидкістю {fastest.GetMaxSpeed()} км/год");
    }
}
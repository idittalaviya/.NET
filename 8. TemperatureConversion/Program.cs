using System;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1. To convert Celsius to Fahrenheit");
            Console.WriteLine("2. To convert Fahrenheit to Celsius");
            int choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    Console.WriteLine("Enter a value in Celsius:");
                    float Celsius = float.Parse(Console.ReadLine());
                    float Fahrenheit = Celsius * (9.0f / 5.0f) + 32;
                    Console.WriteLine($"Fahrenheit: {Fahrenheit}");
                    break;
                case 2:
                    Console.WriteLine("Enter a value in Fahrenheit:");
                    Fahrenheit = float.Parse(Console.ReadLine());
                    Celsius = (Fahrenheit - 32) * (5.0f / 9.0f);
                    Console.WriteLine($"Celsius: {Celsius}");
                    break;
                default: Console.WriteLine("Invalid Option Selected.");
                    break;
            }
        }
    }
}

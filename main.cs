using System;

class Program {
  public static void Main (string[] args)
  {
    const double CentimetersPerInch = 2.54;
    Console.Write("Enter Inches:");
    string input = Console.ReadLine();
    if (double.TryParse(input, out double inches))
        {
            double centimeters = inches * CentimetersPerInch;
            Console.WriteLine($"{inches} inches is {centimeters} centimeters");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number of inches.");
        }
    }
}
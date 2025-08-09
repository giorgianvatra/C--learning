// See https://aka.ms/new-console-template for more informatio


using System.ComponentModel.Design.Serialization;

static class AverageCalculator
{
    public static void Main()
    {

        Console.WriteLine("Insert First Number: ");
        int FirstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert Second Number: ");
        int SecondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert Third Number: ");
        int ThirdNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert Forth Number: ");
        int ForthNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Average: {0}", (FirstNumber + SecondNumber + ThirdNumber + ForthNumber)/4);

    }
}

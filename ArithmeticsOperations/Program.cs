// See https://aka.ms/new-console-template for more information


static class ArithmeticsOperations
{
    static public void Main()
    {
        Console.WriteLine("Inset First Number:");
        int FirstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert Second Number:");
        int SecondNumber = int.Parse(Console.ReadLine());
        int sum = FirstNumber + SecondNumber;
        int division = FirstNumber - SecondNumber;
        int multipication = FirstNumber * SecondNumber;
        int substration = FirstNumber / SecondNumber;
        int mod = FirstNumber % SecondNumber;
        Console.WriteLine($"{FirstNumber} + {SecondNumber} = {sum}");
        Console.WriteLine($"{FirstNumber} - {SecondNumber} = {division}");
        Console.WriteLine($"{FirstNumber} * {SecondNumber} = {multipication}");
        Console.WriteLine($"{FirstNumber} / {SecondNumber} = {substration}");
        Console.WriteLine($"{FirstNumber} mod {SecondNumber} = {mod}");
    }
}
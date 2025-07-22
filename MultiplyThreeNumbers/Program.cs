

static class MultiplyThreeNumbers
{
    static public void Main()
    {

        int FirstNumber, SecondNumber, ThirdNumber;

        Console.Write("Input the First Number: ");
        FirstNumber = int.Parse(Console.ReadLine());


        Console.Write("Input the Second Number: ");
        SecondNumber = int.Parse(Console.ReadLine());


        Console.Write("Input the Third Number: ");
        ThirdNumber = int.Parse(Console.ReadLine());


        Console.WriteLine("First Number: " + FirstNumber);
        Console.WriteLine("Second Number: " + SecondNumber);
        Console.WriteLine("Third Number: " + ThirdNumber);

        int Multiplication = FirstNumber * SecondNumber * ThirdNumber;
        Console.WriteLine("Total : {0} + {1} + {2} = {3}", FirstNumber, SecondNumber, ThirdNumber, Multiplication); 


    }
}
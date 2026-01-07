

using System.Globalization;

public class MultiplyThreeNumbers
{
    public static void Main()
    {
        Console.WriteLine("Input Fist Number");
        int firstNumber = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Input Second Number"); 
        int secondNumber = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Input Third Number"); 
        int thirdNumber = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("---------------");
        int result = firstNumber * secondNumber * thirdNumber; 

        Console.WriteLine("Result = " + result); 



    }
}
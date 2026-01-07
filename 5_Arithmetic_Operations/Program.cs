

using System.Diagnostics.CodeAnalysis;

public class ArithmeticsOperations
{
    public static void Main()
    {
        Console.WriteLine("INPUT NUMBERS");
        Console.WriteLine("Input First Number");
        int firstNumber = Convert.ToInt32(Console.ReadLine());     
        Console.WriteLine("Input Second Number");
        int secondNumber = Convert.ToInt32(Console.ReadLine());     

        Console.WriteLine( "{0} + {1} = {2}", firstNumber, secondNumber, Sum(firstNumber, secondNumber)); 
        Console.WriteLine( "{0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber); 
        Console.WriteLine( "{0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber); 
        Console.WriteLine( "{0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber); 
        Console.WriteLine( "{0} % {1} = {2}", firstNumber, secondNumber, firstNumber % secondNumber); 


    }

    public static int Sum(int a, int b)
    {
        return a + b; 
    }


}
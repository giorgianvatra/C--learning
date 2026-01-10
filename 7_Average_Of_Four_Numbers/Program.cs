

using System.Linq.Expressions;

public class AverageOfFourNumbers
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the 'Average of Four program"); 
        Console.WriteLine("Insert First Number: "); 
        double firstNumber = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Insert Second Number: "); 
        double secondNumber = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Insert Third Number: "); 
        double thirdNumber = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Insert Fourth Number: "); 
        double fourthNumber = Convert.ToInt32(Console.ReadLine()); 

        double average =  (firstNumber + secondNumber + thirdNumber + fourthNumber)/4; 

        Console.WriteLine("The Average of the Four Numbers is: " + average); 
    }
}
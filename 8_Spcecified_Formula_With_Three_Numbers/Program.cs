
public class SpecifiedFormulaWithThreeNumbers
{
    public static void Main()
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Please input three numbers the program will perfor (x+y)*z and x*y + y*z");
        Console.WriteLine("Input First Number"); 
        double firstNumber = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Input Second Number"); 
        double secondNumber = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Input Third Number"); 
        double thirdNumber = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("({0} + {1}) * {2} = {3}", firstNumber, secondNumber, thirdNumber, (firstNumber + secondNumber) * thirdNumber); 
        Console.WriteLine("{0}*{1} + {1}*{2} = {3}", firstNumber, secondNumber, thirdNumber, (firstNumber * secondNumber) + (secondNumber * thirdNumber)); 

    }
}
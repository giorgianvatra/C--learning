

public class SwapTwoVariables
{
    static public void Main(string[] args)
    {
        int FirstValue, SecondValue, temp;
        Console.Write("Input First Variable: ");
        FirstValue = int.Parse(Console.ReadLine());
        Console.Write("Input Second Variable: ");
        SecondValue = int.Parse(Console.ReadLine());


        Console.WriteLine("Before");
        Console.WriteLine("First Value : " + FirstValue);
        Console.WriteLine("Second Value : " + SecondValue);

        temp = FirstValue;
        FirstValue = SecondValue;
        SecondValue = temp;


        Console.WriteLine("After");
        Console.WriteLine("First Value : " + FirstValue);
        Console.WriteLine("Second Value : " + SecondValue);

    }
}

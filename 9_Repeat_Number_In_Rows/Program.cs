
public class PrepeatNumberInRows
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Reprea number in Rows Program!"); 
        Console.WriteLine("Please input a number in order to perform the program!");
        long number = Convert.ToInt64(Console.ReadLine());  

        for(int i = 1; i <= 4; i++)
        {
            if(i%2 == 1)
            {
                Console.WriteLine("{0} {0} {0} {0}", number); 
            }
            if(i%2 == 0)
            {
                Console.WriteLine("{0}{0}{0}{0}", number); 
            }
        }

    }
}
public class MultiplicationTable
{
    public static void Main()
    {
        Console.WriteLine("INSERT THE NUMBER");
        int number = Convert.ToInt32(Console.ReadLine());

        for(int i  = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", i, number, i * number); 
        }

    
    }
    
}
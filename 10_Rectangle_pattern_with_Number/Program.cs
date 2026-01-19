

using System.Formats.Asn1;

public class RectanglePatternWithNumber
{
    public static void Main()
    {
        Console.WriteLine("Welcome the the Rectangle Pattern With Numbers program");
        Console.WriteLine("Please insert the number to begin the program!");
        long  number = Convert.ToInt64(Console.ReadLine()); 
        for(int i = 0; i < 5; i++)
        {
            if(i == 0 || i == 4)
            {
                string row = ""; 
                for(int j = 0; j < 3; j++)
                {
                 row += number + " "; 
                }
                Console.WriteLine(row);
            }
            else
            {
                string row = ""; 
                for(int j = 0; j < 3; j++)
                {
                    if(j == 0 || j == 2)
                    {
                        row +=  number + " ";
                    }
                    else
                    {
                        row += "  ";
                    }
                 
                }
                Console.WriteLine(row);
            }


        }
        
    }
    
}
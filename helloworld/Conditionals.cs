public class Conditionals
{
    public static void Test1()
    {
        decimal a = 79;
        decimal b = 21;
        // bool check = a + b < 25;
        if(a + b > 100)
        {
            Console.WriteLine("Bigger than a 100");
        }
            
        else if(a + b < 100)
        {
            Console.WriteLine("Smaller than a 100");
        }
        else // answer is 100
        {
            Console.WriteLine("Exactly a 100");
        }
    }
    public static void Test2()
    {
        int counterStop = 15;
        for (int i = 0; i <= counterStop; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"Counter is even {i}");
            }
            else
            {
                Console.WriteLine($"Counter is odd {i}");

            }
        }
    }
}
public class Lists
{
    public static void Test1()
    {
        var numbers = new List<int> {10,20,30,20,30};
        int finalNum = 0;

        for(int i = 0 ; i < numbers.Count ; i++)
        {
            finalNum+=numbers[i];
        }

        Console.WriteLine($"The sum of the list is : {finalNum}");
    }
    public static void Test2()
    {
        var names = new List<string> {"Josh","Martin","Kalina","Antani"};

        foreach (var name in names)
        {
            if(name.Length >5)
            {
                Console.WriteLine(name.Substring(5,1));
            }
            
        }
    }
}
public class Strings
{
    public static void Run()
    {
        Console.WriteLine("Hello, Assholes!");

string firstFriend = "Gosho";
string secondFriend = "Pesho";
string friends = $"My friends are {firstFriend} and {secondFriend}";

Console.WriteLine(friends.Replace("Gosho" , "Marian"));

Console.WriteLine(friends.Length);

Console.WriteLine(friends.StartsWith("My    ")); 
    }
}

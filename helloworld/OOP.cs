
public class Tester
{
    public static void Test1()
    {

        var p1 = new Person("Drago", "Kalchev", new DateOnly(1976, 1, 21));
        var p2 = new Person("Mihaela", "Gicova", new DateOnly(2003, 6, 9));
        p1.Pets.Add(new Cat("Manolova", 2));
        p2.Pets.Add(new Cat("Lisa", 13));
        p2.Pets.Add(new Cat("Chernata", 3));
        List<Person> people = [p1, p2];


        foreach (var person in people)
        {
            Console.WriteLine(person.ToString());
            foreach (var pet in person.Pets)
            {
                Console.WriteLine($"   My owner is {person.First}" + " " + pet.ToString());
            }
        }
    }
}

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First { get; } = firstname;
    public string Last { get; } = lastname;
    public DateOnly Birthday { get; } = birthday;
    public List<Pet> Pets { get; } = new();

    public override string ToString()
    {
        return $"I am {First} {Last} and my bd is {Birthday}";
    }
}
public abstract class Pet(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;
    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"I'm a {GetType().Name} my name is {Name} and i am {Age} year old and i {MakeNoise()} ! ";
    }

}
public class Cat(string name, int age) : Pet(name, age)
{
    public override string MakeNoise() => "Meow Meow";
}

public class Dog(string name, int age) : Pet(name, age)
{

    public override string MakeNoise() => "Woof Woof";
}
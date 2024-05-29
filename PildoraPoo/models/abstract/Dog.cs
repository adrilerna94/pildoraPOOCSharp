namespace PildoraPoo;

public class Dog : AnimalAbstract
{
    public Dog(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

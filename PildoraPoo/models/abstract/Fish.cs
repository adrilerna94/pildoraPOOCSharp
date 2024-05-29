namespace PildoraPoo;

public class Fish : AnimalAbstract, ISwimmable
{
    public Fish(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Sigue nadando, sigue nadando!");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming.");
    }
}


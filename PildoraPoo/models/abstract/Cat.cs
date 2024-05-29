namespace PildoraPoo;

public class Cat : AnimalAbstract
{
    public Cat(string name) : base(name) //"base" llama a la clase AnimalAbstract(param name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}

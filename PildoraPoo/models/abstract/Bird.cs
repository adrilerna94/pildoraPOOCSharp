namespace PildoraPoo;


//bird hereda de AnimalAbstract, Implementa la interfaz IFlyable
public class Bird : AnimalAbstract, IFlyable
{
    public Bird(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Pio Pio!");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying.");
    }
}


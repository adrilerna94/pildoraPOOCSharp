using System;
namespace PildoraPoo;


//Nunca se puede crear una instancia (objetos)
// métodos abstractos >= 0
// Actua como clase base
//--> clases derivadas sobreescriben o implementan sus métodos
public abstract class AnimalAbstract //
{
    protected string Name; //variable protegida

    public AnimalAbstract(string name) //constructor
    {
        Name = name;
    }

    public abstract void MakeSound(); // abstract = vacío

    public virtual void Sleep() // será sobrescrito
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
}

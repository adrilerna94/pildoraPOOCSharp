using System;
namespace PildoraPoo;

public class Perro : Animal //Perro deriva de Animal
{
    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} está ladrando a mansalva.");
    }
}

using System;
namespace PildoraPoo;

public class Animal
{
    //a partir de c#11 "required". 
    // -> propiedad debe ser inicializada por un objeto.
    public required string Nombre {get; set; }
    public void Comer()
    {
        Console.WriteLine(Nombre + " está comiendo Frosties.");
    }
}

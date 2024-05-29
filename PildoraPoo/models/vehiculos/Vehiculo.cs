using System;
namespace PildoraPoo;

public class Vehiculo
{
    //"virtual" en clase base => override en clase derivada

    //Tengo opción de declarar propiedad tipo NULL con "?" o sino me obliga que sea "REQUIRED"
    public virtual string ?Tipo {get; set;}

    public virtual void Conducir()
    {
        Console.WriteLine($"Conduciendo un/a {Tipo}");
    }

    
}

using System;
namespace PildoraPoo;


public class Persona //access modifier-class-ClassName (PascalCase)
{
    // Propiedades: métodos get (lectura) y set (escritura)

    //Propiedad auto-implementada: compilador crea un campo privado (_nombre y _edad)
    //No nos permite agregar lógica
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Propiedad definida de forma explícita. 
    // Nos permite más control y agregar lógica.

   /* 
    private string _nombre; //_backing field (variable privada)
    public string Nombre // propiedad pública con su get y set
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private int _edad;
    public int Edad
    {
        get{return _edad;}
        set {_edad = value;}
    }

    */

    // Constructor
    public Persona(string nombre, int edad)
    {
        Nombre = nombre; // no necesario "this"" porque parámetro != propiedad
        Edad = edad;
    }

    // Métodos
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}




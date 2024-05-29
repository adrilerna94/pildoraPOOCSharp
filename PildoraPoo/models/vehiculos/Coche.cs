using System;
namespace PildoraPoo;

public class Coche : Vehiculo
{
    //sobreescribimos propiedad Tipo
    // public override required string Tipo { get; set;} = "coche";

    public Coche()
    {
        Tipo= "Coche";
    }

    //sobreescribimos método Conducir()
    public override string ?Tipo { get => base.Tipo; set => base.Tipo = value;}

    public override void Conducir()
    {
        base.Conducir();
    }

}
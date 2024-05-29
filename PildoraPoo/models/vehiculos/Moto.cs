using System;
namespace PildoraPoo;

public class Moto:Vehiculo
{
    public Moto()
    {
        Tipo = "moto";
    }
    public override string ?Tipo { get => base.Tipo; set => base.Tipo = value; }

    public override void Conducir()
    {
        base.Conducir();
    }
}

using System; // Importa el espacio de nombres System, que contiene clases básicas de C# como Console.

public class CuentaBancaria
{
    // Variable de respaldo privada que almacena el saldo de la cuenta.
    private decimal _saldo;

    // Propiedad pública que proporciona acceso controlado a la variable de respaldo _saldo.
    public decimal Saldo
    {
        // Getter: devuelve el valor actual de _saldo.
        get { return _saldo; }
        
        // Setter: establece un nuevo valor para _saldo si el valor es mayor o igual a 0; de lo contrario, lanza una excepción.
        set
        {
            if (value >= 0)
            {
                _saldo = value;
            }
            else
            {
                throw new ArgumentException("El saldo no puede ser negativo.");
            }
        }
    }

    // Constructor que inicializa una nueva instancia de CuentaBancaria con un saldo inicial.
    public CuentaBancaria(decimal saldoInicial)
    {
        // Usa la propiedad Saldo para establecer el saldo inicial, lo que también valida el valor.
        Saldo = saldoInicial;
    }

    // Método para depositar una cantidad en la cuenta.
    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            // Usa la propiedad Saldo para agregar la cantidad depositada al saldo actual.
            Saldo += cantidad;
        }
        else{
            Console.WriteLine("Recuerda que el saldo debe ser > 0");
        }
    }

    // Método para retirar una cantidad de la cuenta.
    public void Retirar(decimal cantidad)
    {
        if (cantidad > 0 && cantidad <= Saldo)
        {
            // Usa la propiedad Saldo para restar la cantidad retirada del saldo actual.
            Saldo -= cantidad;
        }
        else{
            Console.WriteLine("Upps, cantidad a retirar demasiado elevada!! \n Prueba con una cantidad más pequeña");
        }
    }
}
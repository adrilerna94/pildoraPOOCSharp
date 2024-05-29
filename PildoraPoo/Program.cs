// See https://aka.ms/new-console-template for more information
using PildoraPoo;

public class Program
{
    public static void Main()
    {
         //CLASE BÁSICA
         // --> CLASE PERSONA
        Persona persona = new Persona("Juan", 30);
        persona.MostrarInformacion();  // Salida: Nombre: Juan, Edad: 30

        //HERENCIA
        // --> CLASE PERRO 
        // Creamos Objeto Perro: Animal
        //Al no haber creado el constructor es necesario llamar al método set de Perro y asignarle el valor cuando instanciamos la clase "Perro"

        Perro perro = new Perro {Nombre= "Kiko Rivera"};
        perro.Comer();
        perro.Ladrar();

        //POLIMORFISMO (de propiedades y métodos) => virtual-override
        
        Vehiculo[] vehiculos = new Vehiculo[2];  // Se crea un arreglo de Vehiculo con 2 elementos.
        vehiculos[0] = new Coche();  // Se asigna una instancia de Coche al primer elemento del arreglo.
        vehiculos[1] = new Moto();   // Se asigna una instancia de Moto al segundo elemento del arreglo.

        foreach (Vehiculo v in vehiculos)  // Se recorre el arreglo de vehiculos.
        {
            v.Conducir();  // Se llama al método Conducir de cada instancia. 
                           // Debido al polimorfismo, se invoca el método correspondiente de Coche o Moto.
        }

        //CLASE COMPLETA: validaciones, variedad de métodos
        // --> CUENTA BANCARIA

        // Crear una instancia de CuentaBancaria con un saldo inicial de 1000.
        CuentaBancaria cuenta = new CuentaBancaria(1000);
        // Llamar al setter de la propiedad Saldo para establecer un nuevo saldo de 1500.
        cuenta.Saldo = 1500;
        // Llamar al getter de la propiedad Saldo para obtener el saldo actual y almacenarlo en la variable saldoActual.
        decimal saldoActual = cuenta.Saldo;        
        // Imprimir el saldo actual en la consola.
        Console.WriteLine($"Saldo actual = {saldoActual}");

        // Llamar al método Depositar para agregar 500 al saldo.
        cuenta.Depositar(500);        
        // Imprimir el saldo después del depósito en la consola.
        
        Console.WriteLine("Tu nuevo saldo despues de ingresar 500€ = " + cuenta.Saldo);
        
        // Llamar al método Retirar para restar 300 del saldo.
        cuenta.Retirar(300);
        
        // Imprimir el saldo después del retiro en la consola.
        Console.WriteLine($"Saldo después de Retirar 300€ es = {cuenta.Saldo}");
    }




}

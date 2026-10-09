using System;

// Clase: MotorCD
class MotorCD
{
    // Propiedades
    public string Identificador { get; set; }
    public double Voltaje { get; set; }
    public double Corriente { get; set; }

    // Método para calcular la potencia eléctrica
    public double CalcularPotencia()
    {
        return Voltaje * Corriente;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Ejercicio 1: Consumo Eléctrico ---");

        // Objeto creado a partir de la clase MotorCD
        MotorCD miMotor = new MotorCD();

        Console.Write("Ingrese el identificador del motor: ");
        miMotor.Identificador = Console.ReadLine();

        Console.Write("Ingrese el voltaje de alimentación (V): ");
        miMotor.Voltaje = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la corriente consumida (A): ");
        miMotor.Corriente = Convert.ToDouble(Console.ReadLine());

        // Llamada al método de la clase
        double potencia = miMotor.CalcularPotencia();
        Console.WriteLine($"Potencia calculada: {potencia} W");

        if (potencia <= 120)
        {
            Console.WriteLine("Estado: Consumo normal");
        }
        else
        {
            Console.WriteLine("Estado: Consumo elevado");
        }
    }
}
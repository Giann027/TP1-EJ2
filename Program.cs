using System;

namespace TP1_EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Operaciones Basicas de dos números ";

            float Numero1, Numero2, Suma, Resta, Multiplicación, División;
            Console.Write("Ingrese el primer Número: ");
            Numero1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese el segundo Número: ");
            Numero2 = Convert.ToSingle(Console.ReadLine());

            Suma = Numero1 + Numero2;
            Resta = Numero1 - Numero2;
            Multiplicación = Numero1 * Numero2;
            División = Numero1 / Numero2;

            Console.WriteLine($"El resultado de la suma es {Suma}");
            Console.WriteLine($"El resultado de la Resta es {Resta}");
            Console.WriteLine($"El resultado de la Multiplicación es {Multiplicación}");
            Console.WriteLine($"El resultado de la División es {División}");



        }
    }
}


using Excepciones;
using System;

namespace EjercicioExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el primer número:");
                double num1 = Utilidades.PedirNumero();

                Console.WriteLine("Ingrese el segundo número:");
                double num2 = Utilidades.PedirNumero();

                Operaciones operaciones = new Operaciones();

                Console.WriteLine($"Suma: {operaciones.Sumar(num1, num2)}");
                Console.WriteLine($"Resta: {operaciones.Restar(num1, num2)}");
                Console.WriteLine($"Multiplicación: {operaciones.Multiplicar(num1, num2)}");

                if (num2 != 0)
                {
                    Console.WriteLine($"División: {operaciones.Dividir(num1, num2)}");
                }
                else
                {
                    Console.WriteLine("No es posible dividir por cero.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
        }
    }
}

namespace Excepciones
{
    class Utilidades
    {
        public static double PedirNumero()
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double numero))
            {
                return numero;
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
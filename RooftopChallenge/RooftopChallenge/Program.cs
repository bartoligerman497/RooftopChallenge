using System;

namespace RooftopChallenge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hola Rooftopper");

            int cantidadFilas = Convert.ToInt32(Console.ReadLine());

            int cantidadColumnas = Convert.ToInt32(Console.ReadLine());

            int[,] matriz;
            matriz = new int[cantidadFilas, cantidadColumnas];

            Console.WriteLine("Cantidad de filas de la matriz: " + matriz.GetLength(0));
            Console.WriteLine("Cantidad de columnas de la matriz: " + matriz.GetLength(1));
        }
    }
}
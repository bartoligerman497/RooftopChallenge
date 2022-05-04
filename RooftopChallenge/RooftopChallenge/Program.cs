using System;

namespace RooftopChallenge
{
    internal class MatrizClase
    {
        private int[,] matriz;

        public int[,] Matriz { get => matriz; set => matriz = value; }

        public void Imprimir()
        {
            for (int f = 0; f < Matriz.GetLength(0); f++)
            {
                for (int c = 0; c < Matriz.GetLength(1); c++)
                {
                    Console.Write(Matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Cargar()
        {
            Console.WriteLine("Hola Rooftopper");

            Console.WriteLine("");

            Console.WriteLine("Ingrese la cantidad de filas que va a tener la matriz: ");
            int cantidadFilas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Ingrese la cantidad de columnas que va a tener la matriz: ");
            int cantidadColumnas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Matriz = new int[cantidadFilas, cantidadColumnas];

            Console.WriteLine("Cantidad de filas de la matriz: " + matriz.GetLength(0));
            Console.WriteLine("Cantidad de columnas de la matriz: " + matriz.GetLength(1));

            Console.WriteLine("");

            Console.Write("Cuantas filas tiene la matriz:");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.Write("Cuantas columnas tiene la matriz:");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);

            Matriz = new int[filas, columnas];

            for (int f = 0; f < Matriz.GetLength(0); f++)
            {
                for (int c = 0; c < Matriz.GetLength(1); c++)
                {
                    Console.Write("Ingrese un número:");
                    linea = Console.ReadLine();
                    Matriz[f, c] = int.Parse(linea);
                }
            }
        }

        private static void Main(string[] args)
        {
            MatrizClase matriz = new MatrizClase();
            matriz.Cargar();
            matriz.Imprimir();
        }
    }
}
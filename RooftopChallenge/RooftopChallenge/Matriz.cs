using System;

namespace RooftopChallenge
{
    internal class MatrizClase
    {
        private int[,] matriz;

        public int[,] Matriz { get => matriz; set => matriz = value; }

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

            for (int fila = 0; fila < Matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < Matriz.GetLength(1); columna++)
                {
                    Console.Write("Ingrese un número:");
                    Matriz[fila, columna] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Imprimir()
        {
            for (int fila = 0; fila < Matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < Matriz.GetLength(1); columna++)
                {
                    Console.Write(Matriz[fila, columna] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Main(string[] args)
        {
            MatrizClase matriz = new MatrizClase();
            matriz.Cargar();
            matriz.Imprimir();

            // desea salir o quiere ingresar otra

            //saludos
        }
    }
}
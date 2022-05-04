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

            Console.Write("Ingrese la cantidad de filas que va a tener la matriz: ");
            int cantidadFilas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Ingrese la cantidad de columnas que va a tener la matriz: ");
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
                    int fila1 = fila + 1;
                    int columna1 = columna + 1;
                    Console.Write("Fila: " + fila1 + " \nColumna: " + columna1 + " \n\nIngrese el número: ");
                    Matriz[fila, columna] = Convert.ToInt32(Console.ReadLine());
                    Imprimir();
                }
            }

            Console.WriteLine("");
        }

        public void Ordenar()
        {
        }

        public void Imprimir()
        {
            //Console.WriteLine("***************************************************************************");
            Console.WriteLine("Matriz");
            Console.WriteLine("");

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
            matriz.Ordenar();
            matriz.Imprimir();

            // desea salir o quiere ingresar otra

            //saludos
        }
    }
}
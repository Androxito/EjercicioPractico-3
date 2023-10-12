using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico_3
{
    internal class Ejercicios
    {
        public void Problema1()
        {
            int[,] arreglo = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for(int i = 0; i < arreglo.GetLength(0); i++)
            {
                for(int a = 0;a < arreglo.GetLength(1); a++)
                {
                    Console.Write(" "+arreglo[i,a]);
                }
                Console.WriteLine();
            }
        }
        public void problema2()
        {
            string[,] Color = { {"Azul","Rojo" }, {"Verde","Amarrillo" } };
            for(int i =0; i < Color.GetLength(0); i++)
            {
                for(int a = 0;a < Color.GetLength(1); a++)
                {
                    Console.Write(" "+ Color[i,a]);
                }
                Console.WriteLine();
            }
        }
        public void problema3()
        {
            double[,] Suma = { {1.1,1.2,1.3 }, {1.4,1.5,1.6 }, {1.7,1.8,1.9 }, {2.0,2.1,2.2 } };
            double respuesta = 0;

            for(int i = 0;i < 4; i++)
            {
                for(int a = 0; a <3; a++)
                {
                    respuesta += Suma[i,a];
                }
            }
            Console.WriteLine(respuesta);

        }


    }
}

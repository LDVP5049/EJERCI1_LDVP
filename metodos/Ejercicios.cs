using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EJERCI1_LDVP.metodos
{
    internal class Ejercicios
    {
        public void CincoNum()
        {
            int[] n = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }

        }

        public void CincoNum2(int elem)
        {
            int cont = 0;
            while (cont < elem)
            {
                cont++;
                Console.WriteLine(cont);
            }
        }
        public void Media()
        {
            int[] nuMedia = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int suma = 0;
            for (int i = 0; i < nuMedia.Length; i++)
            {
                suma += nuMedia[i];
            }
            double media = suma / nuMedia.Length;
            Console.WriteLine($"La media es {media}");
        }


        //AYUDA DE CHAT

        public int[] Arreglo(int rango)
        {
            return new int[rango];
        }

        public void Multiplos(int[] arreglo, int numero)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = (i + 1) * numero;
            }
        }

        public void MostrarArray(int[] arreglo)
        {
            Console.WriteLine("ARRAY:");
            foreach (int elemento in arreglo)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }


        //AYUDA DE CHAT/YOUTUBE -- MAL

        public string[] NombresArre(int tamaño)
        {
            return new string[tamaño]; 
        }

        public int[] LongitudNombres(string[] nombres)
        {
            int[] longitudes = new int[nombres.Length];
            for (int i = 0; i < nombres.Length; i++)
            {
                longitudes[i] = nombres[i].Length;
            }
            return longitudes;
        }

        public void NombresLong(string[] nombres, int[] longitudes)
        {
            Console.WriteLine("Nombres y longitud");

            for (int i = 0; i < nombres.Length ; i++)
            {
                Console.WriteLine($"nombre: {nombres}, longitudes {longitudes}");
            }
        }



    }
}

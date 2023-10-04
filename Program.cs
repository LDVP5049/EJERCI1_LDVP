using EJERCI1_LDVP.metodos;
using System.Xml;

namespace EJERCI1_LDVP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicios eje1 = new Ejercicios();
              eje1.CincoNum(); 

          Ejercicios eje2 = new Ejercicios();
              Console.WriteLine("Ingresa un numero");
              int elem = Convert.ToInt32(Console.ReadLine());
              eje2.CincoNum2(elem);

              Ejercicios eje3 = new Ejercicios();
              eje3.Media();

            //AYUDA DE CHAT
         
            Console.WriteLine("Ingresa el tamaño del array");
            int rango = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numero para multiplos");
            int numero = Convert.ToInt32(Console.ReadLine());

            Ejercicios eje4 = new Ejercicios();
            int[] arreglo = eje4.Arreglo(rango);

            eje4.Multiplos(arreglo, numero);

            eje4.MostrarArray(arreglo);*/

            Console.Write("Ingrese el tamaño de los arrays: ");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            Ejercicios eje5 = new Ejercicios();
            string[] nombres = eje5.NombresArre(tamaño);
            int[] longitudes = eje5.LongitudNombres(nombres);
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"Ingrese el nombre {i + 1}: ");
                nombres[i] = Console.ReadLine();
            }
            longitudes = eje5.LongitudNombres(nombres);
            eje5.NombresLong(nombres, longitudes);

        }

    }
}
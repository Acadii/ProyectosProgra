using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglo de strings declaracion explicita
            string[] diasSemana = {"Domingo", "Lunes", "Martes",
                "Miercoles", "Jueves", "Viernes", "Sabado"};

            int cantDias = diasSemana.Length;

            Console.WriteLine("Hay " + cantDias + " dias en el arreglo.");

            //Asignar un valor al arreglo
            diasSemana[1] = "Monday";

            //Accedo a un elemento y lo guardo como variable
            string diaUno = diasSemana[1];
            string diaTres = diasSemana[3];

            Console.WriteLine(diaUno);
            Console.WriteLine(diaTres);

            //Accedo a un elemento y lo uso directamente
            Console.WriteLine(diasSemana[0]);
            Console.WriteLine(diasSemana[4]);

            for (int i = 0; i < 7; i++) //hardcore :(
            {
            }

            for(int i = 0; i < diasSemana.Length; i++) //Parametrizado :D
            {
                //Uso la var de control i para acceder a cada elemento del arreglo
                Console.WriteLine(i + ".- " + diasSemana[i]);
            }


            Console.ReadLine();
        }
    }
}

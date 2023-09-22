using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeNombres
{
    class GeneradorNombrePirata
    {
        string[] titulo = {"Captain", "Dirty", "Squidlips", "Bowman", "Buccaner", "Two Toes", "Sharkbait",
            "Old", "Peg Leg", "Fluffbucket", "Scallywag", "Bucko", "Dead man", "Matery", "Jolly", "Stinky"};

        string[] nombre = {"Creeper", "Jim", "Storm", "John", "George", "O'", "Rat",
            "Jack", "Legs", "Head", "Cackle", "Patch", "Bones", "Plank", "Greedy", "Sea"};

        string[] apellido = {"From the West", "Byrd", "Jackson", "Sparrow", "Of the Coast", "Jones", "Ned Head",
            "Bart", "O'Fish", "Kidd", "O'Malley", "Barnacle", "Holystone", "Hornswaggle", "McStinky", "Swashbuckler"};


        public void generarNombre(int diaNacimiento, int mesNacimiento, int anioNacimiento)
        {

      
            Console.WriteLine("Ahora seras conocido  como " + titulo[diaNacimiento - 1] + " " + 
                nombre[mesNacimiento - 1] + " " + apellido[anioNacimiento - 1] + ".");

            if (diaNacimiento > 16)
            {
                Console.WriteLine("Por el momento el programa solo cuenta con 16 dias");
            }

            if (mesNacimiento > 16)
            {
                Console.WriteLine("Por el momento el programa solo cuenta con 16 meses");
            }

            if (mesNacimiento > 16)
            {
                Console.WriteLine("Por el momento el programa solo cuenta con 16 años");
            }

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon1 = new Dragon();
            dragon1.presentarse();
            float velocidad = dragon1.calcVelocidadVuelo();
            Console.WriteLine("velocidad: " + velocidad + "\n");

            Dragon dragon2 = new Dragon("electrico", "amarillo");
            dragon2.presentarse();
            Console.WriteLine("Velocidad: " + dragon2.calcVelocidadVuelo() + "\n");

            Dragon dragon3 = new Dragon("roca", "blanco");
            dragon3.presentarse();
            Console.WriteLine("Velocidad: " + dragon2.calcVelocidadVuelo() + "\n");

            //TRIANGULO AREA

            Triangulo triangulo1 = new Triangulo(4, 5);
            triangulo1.presentarRes();
            Console.WriteLine("El area total es de " + triangulo1.calcularArea() + "\n");

            Triangulo triangulo2 = new Triangulo(8, 5);
            triangulo2.presentarRes();
            Console.WriteLine("El area total es de " + triangulo2.calcularArea() + "\n");

            //RECTANGULO PERIMETRO

            Rectangulo rectangulo1 = new Rectangulo(8, 6);
            rectangulo1.presentarRes();
            Console.WriteLine("El perimetro total es de " + rectangulo1.calcularPerimetro() + "\n");

            Rectangulo rectangulo2 = new Rectangulo(10, 5);
            rectangulo2.presentarRes();
            Console.WriteLine("El perimetro total es de " + rectangulo2.calcularPerimetro() + "\n");

            //ZAPATO

            Zapato zapato1 = new Zapato("cafe", 8f);
            zapato1.Describir();

            Zapato zapato2 = new Zapato("negro", 6.5f);
            zapato2.Describir();

            //FOCO

            Foco foco1 = new Foco(23.5f, true);
            Console.WriteLine("El foco consume " + foco1.calcularConsumo() + " watts de energia.\n");
           
            Foco foco2 = new Foco(23.5f, false);
            Console.WriteLine("El foco consume " + foco2.calcularConsumo() + " watts de energia.\n");

            //CONTACTO



            Console.ReadLine();
        }
    }
}

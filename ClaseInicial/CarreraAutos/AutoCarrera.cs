using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    public class AutoCarrera
    {
        public string Modelo;
        public float Peso;
        public int Velocidad;
        public float Gasolina;

        public void PonerGas(float cantidad)
        {
            Gasolina = Gasolina + cantidad;
            Console.WriteLine(Modelo + " tiene " + Gasolina + " litros de gas.\n");
        }


        public void Arrancar()
        {
            if (Gasolina > 0)
            {
                //Consime 0.001 litros de gasolina cada que arranca
                Gasolina = Gasolina - 0.1f;
            Console.WriteLine("Arrancando " + Modelo + ", le quedan " + Gasolina + " litro de gas.\n");
            }

            else
            {
                Console.WriteLine("No se puede arrancar " + Modelo + " sin gasolina.\n");
            }
        }

      

        public void Acelerar(int cantidad)

        {
            Velocidad = Velocidad + cantidad;
            Console.WriteLine("La velocidad de " + Modelo + " aumento a " + Velocidad + " k/h.\n");
            Gasolina = Gasolina - Velocidad / 10f;
            Console.WriteLine("Acelerando " + Modelo + ", le quedan " + Gasolina + " litros de gas.\n");
            if (Gasolina <= 0)
            {
                Velocidad = Velocidad = 0;
                Console.WriteLine(Modelo + " se ha detenido debido que se quedo sin gasonila\n");

            }

 

        }

        public void Frenar()

        {
            Velocidad = 0;
            Console.WriteLine(Modelo + " ha dado un freno, su velocidad disminuyo a " + Velocidad + " k/h.\n");
                
        }



    }
}


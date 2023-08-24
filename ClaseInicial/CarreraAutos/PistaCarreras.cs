using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    public class PistaCarreras
    {
        public string nombre;
        public float longitud;

        public void Competir(AutoCarrera auto1, AutoCarrera auto2)
        {
            Console.WriteLine(
                "Iniciando carrera entre " + auto1.Modelo + " y " + auto2.Modelo + "\n");

            if(auto1.Velocidad > auto2.Velocidad)
            {
                Console.WriteLine("Gano " + auto1.Modelo);
            }

            else if (auto2.Velocidad > auto1.Velocidad)
            {
                Console.WriteLine("Gano " + auto2.Modelo);
            }

            else
            {
                Console.WriteLine("Hubo empate");
            }





    }

}
}




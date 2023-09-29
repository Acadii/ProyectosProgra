using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{ 
    class Dragon
    {
        private string tipo = "hielo";
        private string color = "gris";
        private int cantAlas = 4;
        private float peso = 25000f;

        public Dragon() //Este es un constructor
        {
            tipo = "fuego"; //Establezco el estado inicial del objeto
        }

        public Dragon(string valorTipo, string valorColor)
        {
            tipo = valorTipo;
            color = valorColor;
        }

        public void presentarse()
        {
            Console.WriteLine("Yo soy un dragon de tipo " + tipo + " color " + color + " y voy a comerlos a todos.");

        }

        public float calcVelocidadVuelo()
        {
            return cantAlas / peso;
        }
    }
}

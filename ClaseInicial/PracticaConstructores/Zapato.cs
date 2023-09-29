using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Zapato
    {
        public string color;
        public float talla;

        public Zapato(string colorZap, float tallaZap)
        {
            color = colorZap;
            talla = tallaZap;
        }

        public void Describir()
        {
            Console.WriteLine("Este es un zapato de color " + color + " talla " + talla + ".\n");
        }

    }
}

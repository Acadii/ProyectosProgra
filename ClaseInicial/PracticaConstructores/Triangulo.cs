using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Triangulo
    {
        public float baseTri;
        public float alturaTri;

        public Triangulo(float baseTriangulo, float alturaTriangulo)
        {
            baseTri = baseTriangulo;
            alturaTri = alturaTriangulo;
        }

        public void presentarRes ()
        {
            Console.WriteLine(" Tu triangulo tiene como base " + baseTri + ", y como altura " + alturaTri + ".");
        }

        public float calcularArea()
        {
            return baseTri * alturaTri / 2;
        }





    }
}

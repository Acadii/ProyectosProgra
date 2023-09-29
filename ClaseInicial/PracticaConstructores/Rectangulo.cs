using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Rectangulo
    {
        public float baseRec;
        public float alturaRec;

        public Rectangulo(float baseRectangulo, float alturaRectangulo)
        {
            baseRec = baseRectangulo;
            alturaRec = alturaRectangulo;
        }

        public void presentarRes()
        {
            Console.WriteLine(" Tu rectangulo tiene como base " + baseRec + ", y como altura " + alturaRec + ".");
        }

        public float calcularPerimetro()
        {
            return baseRec *2 + alturaRec * 2;
        }
    }
}

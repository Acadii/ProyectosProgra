using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Foco
    {
        public float watts;
        public bool encendido;

        public Foco(float wattsFoco, bool encendidoFoco)
        {
            watts = wattsFoco;
            encendido = encendidoFoco;
        }

        public float calcularConsumo()
        {
            if (encendido)
            {
                return watts;
            }

            else
            {
               return 0;
            }
        }

    }
}

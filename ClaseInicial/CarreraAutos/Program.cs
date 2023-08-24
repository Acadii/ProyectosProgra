using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    public class Program
    {
        static void Main(string[] args)
        {
            AutoCarrera ferr = new AutoCarrera();
            ferr.Modelo = "Ferrari F150";
            ferr.Peso = 1.3f;
            ferr.Velocidad = 230;
           

            AutoCarrera mcLaren = new AutoCarrera();
            mcLaren.Modelo = "McLarren A45S";
            mcLaren.Peso = 0.98f;
            mcLaren.Velocidad = 280;


            AutoCarrera Herbie = new AutoCarrera();
            Herbie.Modelo = "Herbie";
            Herbie.Peso = 0.90f;
            Herbie.Velocidad = 300;

            PistaCarreras hnsRodriguez = new PistaCarreras();
            hnsRodriguez.nombre = "Autodromo Hermanos Rodriguez";
            hnsRodriguez.longitud = 5.6f;

            //Mando a competir mis coches

            ferr.PonerGas(100);
            ferr.Arrancar();
            ferr.Acelerar(30);
            mcLaren.PonerGas(10);
            mcLaren.Arrancar();
            mcLaren.Acelerar(20);


            hnsRodriguez.Competir(ferr, mcLaren);



            //Esta instruccion espera que des Enter para continuar
            Console.ReadLine();
;
        }
    }
}

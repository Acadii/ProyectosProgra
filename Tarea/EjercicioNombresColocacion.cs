/*
En este ejercicio practicarás el nombre de las cosas
y su ubicación dentro del código.
Por cada línea que tenga una declaración de namespace,
clase, método, atributo, parámetro, variable, así como 
en ciclos y bloques condicionales, deberás indicar con un comentario 
qué es lo que se está declarando y dentro de qué bloque está.

No copies y pegues, debes transcribir.
NO: class Elefante
SI: clase Elefante

Observa con atención los primeros ejemplos.
*/

using System;//El using no es una declaración

namespace Ejemplos//Declaración de espacio de nombre Ejemplos
{
    class Elefante//Declaración de clase Elefante dentro de namespace Ejemplos
    {
        public string Nombre;//Declaración de atributo Nombre dentro de clase Elefante
        public int Edad;//Declaracion de atributo Edad dentro de clase Elefante
        public float Peso;//Declaracion de atributo Peso dentro de clase Elefante

        //Declaración de método Comer dentro de clase Elefante
        //Declaración de parámetro comida dentro de método comer
        public void Comer(string comida)
        {
            
            for(int i = 0; i < 10; i++)//Ciclo for dentro de método Comer
            {
                int porcionesComidas = i + 1;//Declaración de variable local porcionesComidas dentro de ciclo for
            }
            Console.WriteLine($"{Nombre} está comiendo {comida}.");//Esta línea no llevará comentario
        }
        //Declaracion de metodo Rugir dentro de clase Elefante
        public void Rugir()
        {
            int distanciaEscuchante = 100;//Declaracion de variable local distanciaEscuchante dentro de metodo Rugir
            Console.WriteLine($"{Nombre} está rugiendo.");
        }

        //Declaracion de metodo Dormir dentro de clase Elefante
        //Delcaracion de parametro horas dentro de metodo Dormir
        public void Dormir(int horas) 
        {
            if(horas > 10)//Declaracion de bloque condicional if dentro del metodo Dormir
            {
                float energiaGanada = 15;//Declaracion de variable local energiaGanada dentro de metodo Dormir
            }
            Console.WriteLine($"{Nombre} está durmiendo durante {horas} horas.");
        }
    }

    class Zapatero//Declaracion de clase Zapatero dentro de namespace Ejemplos
    {
        public string Nombre;//Declaracion de atributo Nombre dentro de clase Zapatero
        public string Especialidad;//Declaracion de atributo Especialidad dentro de clase Zapatero
        public int AñosExperiencia;//Declaracion de atributo AñosExperiencia dentro de clase Zapatero

        //Declaracion de metodo RepararZapatos dentro de clase Zapatero
        //Delcaracion de parametro tipo y cantidad dentro de metodo RepararZapatos
        public void RepararZapatos(string tipo, int cantidad)
        {
            int precio = 50;//Declaracion de variable local precio dentro del metodo RepararZapatos
            if (tipo == "tenis")//Declaracion de bloque condicional if dentro de metodo RepararZapatos
            {
                precio = 100;//Uso de variable local precio dentro del bloque condicional if
            }
            Console.WriteLine($"{Nombre} está reparando {cantidad} zapatos de tipo {tipo} a precio {precio}");
        }

        //Declaracion de metodo CrearZapato dentro de clase Zapatero
        //Declaracion de parametros estilo y material dentro de metodo CrearZapato
        public void CrearZapato(string estilo, string material)
        {
            for(int i = 0; i < 100; i++)//Declaracion de ciclo for dentro de metodoCrearZapato
            { 
                if(estilo == "industrial")//Declaracion de bloque condicional if dentro de ciclo for
                {
                    Console.WriteLine("Golpeando fuerte");
                }
                else//Declaracion de bloque condicional else dentro de ciclo for
                {
                    Console.WriteLine("Golpeando normal");

                }
            }
            Console.WriteLine($"{Nombre} está creando un zapato de estilo {estilo} con material {material}.");
        }

        //Declaracion de metodo MedirPie dentro de clase Zapatero
        //Declaracion de parametro numeroPie
        public void MedirPie(int numeroPie)
        {
            string cliente;//Declaracion de variable local cliente dentro de metodo numeroPie
            if (numeroPie > 20)//Declaracion de bloque condicional if dentro de metodo numeroPie
            {
                cliente = "Adulto";//Declaracion de variable local cliente dentro de bloque condicional if
            }
            else//Declaracion de bloque condicional else dentro de metodo numeroPie
            {
                cliente = "Niño";//Declaracion de variable local cliente dentro de bloque condicional else
            }
            Console.WriteLine($"{Nombre} está midiendo el pie para el número {numeroPie}.");
        }
    }

    class Television//Declaracion de clase Television dentro de namespace Ejemplos
    {
        public string Marca;//Declaracion de atributo Marca dentro de clase Television
        public int Pulgadas;//Declaracion de atributo Pulgadas dentro de clase Television
        public bool Encendida;//Declaracion de atributo Encendida dentro de clase Television

        //Declaracion de metodo void dentro de clase Television
        public void Encender()
        {
            Encendida = true;//Declaracion de variable local Encendida dentro de metodo Encender
            float consumoLuz = 0.05f;//Declaracion de variable local ConsumoLuz dentro de metodo Encender
            Console.WriteLine($"La televisión de {Pulgadas} pulgadas, marca {Marca}, está encendida.");
        }

        //Declaracion de metodo CambiarCanal dentro de clase Television
        //Declaracion de parametro canal dentro de metodo CambiarCanal
        public void CambiarCanal(int canal)
        {
            for(int i = 1; i < canal; i++)//Declaracion de ciclo for dentro de metodo CambiarCanal
            {
                Console.WriteLine($"Cambiando a canal {i}.");
            }            
        }

        public void AjustarVolumen(int nivel)//Declaracion de metodo AjustarVolumen dentro de clase Television
        {
            if (nivel > 100)//Declaracion de bloque condicional if dentro de metodo AjusatrVolumen
            {
                nivel = 0;//Declaracion de variaqble local nivel dentro del ciclo condicional if
            }
            Console.WriteLine($"Ajustando el volumen a nivel {nivel}.");
        }
    }

    class Guitarra//Declaracion de clase Guitarra dentro de spacename Ejemplos
    {
        public string Marca;//Declaracion de atributo Marca dentro de clase Guitarra
        public string Tipo;//Declaracion de atributo Tipo dentro de clase Guitarra
        public int Cuerdas;//Declaracion de atributo Cuerdas dentro de clase Guitarra

        //Declaracion de metodo void TocarCuerda dentro de la clase Guitarra
        //Declaracion de parametro numeroCuerda dentro del metodo TocarCuerda
        public void TocarCuerda(int numeroCuerda)
        {
            if(numeroCuerda == 6)//Declaracion de bloque condicional if dentro del metodo TocarCuerda
            {
                string nota = "Mi";//Declaracion de variable local nota dentro del bloque condicional if
            }
            else if (numeroCuerda == 5)//Declaracion de bloque condicional else if dentro de metodo TocarCuerda
            {
                string nota = "La";//Declaracion de variable local nota dentro del bloque condicional else if
            }
            Console.WriteLine($"Tocando la cuerda {numeroCuerda} de la guitarra {Marca}.");
        }

        //Declaracion de metodo AfinarGuitarra dentro de la clase Guitarra
        //Declaracion de parametro afinada dentro del metodo AfinarGuitarra
        public void AfinarGuitarra(bool afinada)//Declaracion de metodo AfinarGuitarra dentro de clase Guitarra
        {
            if (afinada)//Declaracion de bloque condicional if dentro del metodo AfinarGuitarra
            {
                Console.WriteLine($"La guitarra {Marca} está afinada.");
            }
            else//Declaracion de bloquecondicional else dentro del metodoAfinarGuitarra
            {
                for(int i = 0; i < 5; i++)//Declaracion de ciclo for dentro del bloque condicional for
                {
                    Console.WriteLine($"Afinando la guitarra {Marca}.");
                }                
            }
        }

        //Declaracion de metodo void CambiarTipo
        //Declaracion de parametro nuevoTipo dentro del metodoCambiarTipo
        public void CambiarTipo(string nuevoTipo)
        {
            Tipo = nuevoTipo;//Declaracion de variable local Tipo dentro del metodo CambiarTipo
            Console.WriteLine($"Cambiando el tipo de la guitarra a {nuevoTipo}.");
        }
    }

}
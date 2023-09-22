using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Albumes

            Album albumThriller = new Album();
            albumThriller.Titulo = "Thriller";
            albumThriller.NumCanciones = 9;
            albumThriller.artista.Nombre = "Michael Jackson";
            albumThriller.DuracionTotal = 42.21f;
            albumThriller.FechaLanzamiento = "30 de noviembre de 1982";

            Album albumSolas = new Album();
            albumSolas.Titulo = "A Solas";
            albumSolas.NumCanciones = 6;
            albumSolas.artista.Nombre = "Rupatrupa";
            albumSolas.DuracionTotal = 26.18f;
            albumSolas.FechaLanzamiento = "18 de septiembre de 2020";

            Album albumFool = new Album();
            albumFool.Titulo = "Elvis(Fool)";
            albumFool.NumCanciones = 16;
            albumFool.artista.Nombre = "Elvis Presley";
            albumFool.DuracionTotal = 45.25f;
            albumFool.FechaLanzamiento = "6 de julio de 1973";

            Album albumEntrenLosQueQuieran = new Album();
            albumEntrenLosQueQuieran.Titulo = "Entren Los Que Quieran";
            albumEntrenLosQueQuieran.NumCanciones = 14;
            albumEntrenLosQueQuieran.artista.Nombre = "Calle 13";
            albumEntrenLosQueQuieran.DuracionTotal = 52.31f;
            albumEntrenLosQueQuieran.FechaLanzamiento = "19 de noviembre de 2010";

            Album albumFinisterra = new Album();
            albumFinisterra.Titulo = "Finisterra";
            albumFinisterra.NumCanciones = 20;
            albumFinisterra.artista.Nombre = "Mägo de Oz";
            albumFinisterra.DuracionTotal = 1.48f;
            albumFinisterra.FechaLanzamiento = "1 de enero de 2000";

            //Artistas

            Artista artMichael = new Artista();
            artMichael.Nombre = "Michael Jackson";
            artMichael.NumSencillos = 85;
            artMichael.CancionMasEscuchada = "Billie Jean";
            artMichael.GrupoMusical = false;
            artMichael.PaisOrigen = "Estados Unidos";

            Artista artRupatrupa = new Artista();
            artRupatrupa.Nombre = "Rupatrupa";
            artRupatrupa.NumSencillos = 32;
            artRupatrupa.CancionMasEscuchada = "Humo";
            artRupatrupa.GrupoMusical = true;
            artRupatrupa.PaisOrigen = "Terenife";

            Artista artElvis = new Artista();
            artElvis.Nombre = "Elvis Presley";
            artElvis.NumSencillos = 771;
            artElvis.CancionMasEscuchada = "Can't Help Falling in Love ";
            artElvis.GrupoMusical = false;
            artElvis.PaisOrigen = "Estados Unidos";

            Artista artCalle13 = new Artista();
            artCalle13.Nombre = "Calle 13";
            artCalle13.NumSencillos = 138;
            artCalle13.CancionMasEscuchada = "Atrévete-Te-Te";
            artCalle13.GrupoMusical = true;
            artCalle13.PaisOrigen = "Puerto Rico";

            Artista artMagoDeOz = new Artista();
            artMagoDeOz.Nombre = "Mägo de Oz";
            artMagoDeOz.NumSencillos = 32;
            artMagoDeOz.CancionMasEscuchada = "Fiesta Pagana";
            artMagoDeOz.GrupoMusical = true;
            artMagoDeOz.PaisOrigen = "Madrid";

            //Canciones

            Cancion CancionBeatIt = new Cancion();
            CancionBeatIt.Nombre = "Beat It";
            CancionBeatIt.Duracion = 4.18f;
            CancionBeatIt.album.Titulo = "Thriller";
            CancionBeatIt.artista.Nombre = "Michael Jackson";
            CancionBeatIt.AñoLanzamiento = "1982";

            Cancion CancionNoSeBailaComoAntes = new Cancion();
            CancionNoSeBailaComoAntes.Nombre = "Ya No Se Baila Como Antes";
            CancionNoSeBailaComoAntes.Duracion = 6.04f;
            CancionNoSeBailaComoAntes.album.Titulo = "A Solas";
            CancionNoSeBailaComoAntes.artista.Nombre = "Rupatrupa";
            CancionNoSeBailaComoAntes.AñoLanzamiento = "2020";

            Cancion CancionBurningLove = new Cancion();
            CancionBurningLove.Nombre = "Burning Love";
            CancionBurningLove.Duracion = 2.50f;
            CancionBurningLove.album.Titulo = "Elvis (Fool)";
            CancionBurningLove.artista.Nombre = "Elvis Presley";
            CancionBurningLove.AñoLanzamiento = "1972";

            Cancion CancionLaVueltaAlMundo = new Cancion();
            CancionLaVueltaAlMundo.Nombre = "La Vuelta Al Mundo";
            CancionLaVueltaAlMundo.Duracion = 3.54f;
            CancionLaVueltaAlMundo.album.Titulo = "Entren Los Que Quieran";
            CancionLaVueltaAlMundo.artista.Nombre = "Calle 13";
            CancionLaVueltaAlMundo.AñoLanzamiento = "2010";

            Cancion CancionDanzaDelFuego = new Cancion();
            CancionDanzaDelFuego.Nombre = "La Danza Del Fuego";
            CancionDanzaDelFuego.Duracion = 5.13f;
            CancionDanzaDelFuego.album.Titulo = "Finisterra";
            CancionDanzaDelFuego.artista.Nombre = "Mägo de Oz";
            CancionDanzaDelFuego.AñoLanzamiento = "2000";

        }
    }
}

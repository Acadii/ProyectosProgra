using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseInicial
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Esto es una Instacia de Mochila
            Mochila mochilaAna = new Mochila();
            mochilaAna.Disenio = "Piolin";
            mochilaAna.Material = "Vynil";
            mochilaAna.NumDeBolsas = 3;
            mochilaAna.NumDeLlaveros = 0;
            mochilaAna.Precio = 500.00f;
            mochilaAna.color = new Color();
            mochilaAna.color.Rojo = 100;
            mochilaAna.color.Verde = 20;
            mochilaAna.color.Azul = 33;

            Mochila mochilaBeto = new Mochila();
            mochilaBeto.Material = "Piel";
            mochilaBeto.Disenio = "Pokemon";
            mochilaBeto.NumDeBolsas = 3;
            mochilaBeto.NumDeLlaveros = 3;
            mochilaBeto.Precio = 179.50f;
            mochilaBeto.Tamanio = "Grande";
            mochilaBeto.color = new Color();
            mochilaBeto.color.Rojo = 0;
            mochilaBeto.color.Verde = 128;
            mochilaBeto.color.Azul = 210;

            Mochila mochilaMass = new Mochila();
            mochilaMass.Material = "Mezclilla";
            mochilaMass.Disenio = "Patrones";
            mochilaMass.NumDeBolsas = 1;
            mochilaMass.NumDeLlaveros = 2;
            mochilaMass.Precio = 200.00f;
            mochilaMass.Tamanio = "Mediana";
            mochilaMass.color = new Color();
            mochilaMass.color.Rojo = 30;
            mochilaMass.color.Verde = 150;
            mochilaMass.color.Azul = 200;

            //Smartphone

            Smartphone OppoA12 = new Smartphone();
            OppoA12.Technology = "GSM / HSPA / LTE";
            OppoA12.Announced = "2020, April 20";
            OppoA12.Status = "Available";
            OppoA12.DimensionHeight = 155.9f;
            OppoA12.DimensionWidth = 75.5f;
            OppoA12.DimensionThickness = 8.3f;
            OppoA12.Weight = 165;
            OppoA12.Build = "Glass front, plastic back, plastic frame";
            OppoA12.SIM = "Dual SIM (Nano-SIM, dual stand-by)";
            OppoA12.Type = "IPS LCD, 450 nits (typ)";
            OppoA12.Size = 6.22f;
            OppoA12.ResolutionHeight = 1520;
            OppoA12.ResolutionWidth = 720;
            OppoA12.Protection = "Corning Gorilla Glass 3";
            OppoA12.OS = "Android 9.0 (Pie), ColorOS 6.1";
            OppoA12.Chipset = "Mediatek MT6765 Helio P35 (12nm)";
            OppoA12.CPU = "Octa-core (4x2.35 GHz Cortex-A53 & 4x1.8 GHz Cortex-A53)";
            OppoA12.GPU = "PowerVR GE8320";
            OppoA12.CardSlot = "microSDXC";
            OppoA12.Internal = "32GB 3GB RAM, 64GB 4GB RAM eMMC 5.1";
            OppoA12.Dual = "13 MP, f/2.2, (wide), 1/3.1, 1.12µm, PDAF 2MP, f / 2.4, (depth)";
            OppoA12.Features = "LED flash, HDR, panorama";
            OppoA12.Video = "1080p@30fps";
            OppoA12.Single = "5 MP, f/2.0, 1/5, 1.12µm";
            OppoA12.SelfieFeatures = "HDR";
            OppoA12.SelfieVideo = false;
            OppoA12.Loudspeacker = true;
            OppoA12.Jack35mm = true;
            OppoA12.WLAN = "Wi-Fi 802.11 a/b/g/n/ac, dual-band, Wi-Fi Direct";







        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LamparaInteractiva : ObjetoInteractuable
{
    public Light laLuz;
    public override void Activar()
    {


        if (laLuz.gameObject.activeInHierarchy)

        {
            laLuz.gameObject.SetActive(false);
            nombreAccion = ("Encender lampara");
        }

        else
        {
            laLuz.gameObject.SetActive(true);
            nombreAccion = ("Apagar lampara");
        }
    }
}

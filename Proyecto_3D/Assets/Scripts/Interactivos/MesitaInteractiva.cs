using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesitaInteractiva : ObjetoInteractuable
{
    public float locacionAbierto = 0;
    public float locacionCerrado = 0;
    private bool cajonAbierto = false;




    public override void Activar()
    {
        if (cajonAbierto)
        {
            transform.position = new Vector3(-14.71697f, 0.7734133f, locacionAbierto);
            cajonAbierto = true;
            nombreAccion = ("Abrir Cajon");

        }

        else
        {
            transform.position =new Vector3(-14.71697f, 0.7734133f, -21.09193f);
            cajonAbierto = false;
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesitaInteractiva : ObjetoInteractuable
{
    public float locacionAbierto = 0;
    public float locacionCerrado = 0;
    public float muebleX = 0;
    public float muebleY = 0;
    private bool cajonAbierto = false;




    public override void Activar()
    {
        if (cajonAbierto)
        {
            transform.position = new Vector3(muebleX, muebleY, locacionAbierto);
            cajonAbierto = true;
            nombreAccion = ("Abrir Cajon");

        }

        else
        {
            transform.position =new Vector3(0, 0, locacionCerrado);
            cajonAbierto = false;
        }
    }

}
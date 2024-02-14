using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaInteractiva : ObjetoInteractuable
{
    public float rotacionAbierto = 0;
    public float rotacionCerrada = 0;
    private bool puertaAbierta = false;

    public override void Activar()
    {
        if (puertaAbierta == false)
        {
            transform.rotation = Quaternion.Euler(0, rotacionCerrada, 0);
            puertaAbierta = true;

        }

        else
        {
            transform.rotation = Quaternion.Euler(0, rotacionAbierto, 0);
            puertaAbierta=false;
        }
    }
       
       

}

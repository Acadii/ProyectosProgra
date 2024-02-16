using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class ObjetoInteractuable : MonoBehaviour

    
{
    public string nombreAccion;
    public abstract void Activar();
    private bool enContacto = false;
    //Este metodo es una promesa de la accion a realizar, se define en una clase que hereda de esta

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && enContacto)
        {
            Activar();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")

        { return; }


        CoontroladorUI.Instancia.MostrarInteractuable(this);
        enContacto = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player")

        { return; }

        CoontroladorUI.Instancia.MostrarInteractuable(null);
        enContacto=false;
    }

}
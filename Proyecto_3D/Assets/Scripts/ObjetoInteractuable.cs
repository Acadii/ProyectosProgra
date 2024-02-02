using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInteractuable : MonoBehaviour

    
{
    public string nombreAccion;
    private void OnTriggerEnter(Collider other)
    {
        CoontroladorUI.Instancia.MostrarInteractuable(this);
    }

    private void OnTriggerExit(Collider other)
    {
        CoontroladorUI.Instancia.MostrarInteractuable(null);
    }

}

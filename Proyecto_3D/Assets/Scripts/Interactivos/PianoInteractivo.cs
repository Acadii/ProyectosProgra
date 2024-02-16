using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoInteractivo : ObjetoInteractuable
{

    private EfectoSonoro piano;

    void Start()
    {
        piano = GetComponent<EfectoSonoro>();
    }

    public override void Activar()
    {

        piano.reproducir("Tocar Piano");

    }
}

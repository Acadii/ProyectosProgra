using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioInteractiva : ObjetoInteractuable
{

    private EfectoSonoro musica;
    private bool apagado = true;
    public GameObject siguiente;

    private void Start()
    {
        musica = GetComponent<EfectoSonoro>();
    }

    public override void Activar()
    {
        if (apagado)
        {
            apagado = false;
            musica.reproducir("Estacion");
        }

        else if (apagado == false && Input.GetButtonDown("Fire2"))
        {
            {
                musica.detener("Apagar");
                siguiente.gameObject.SetActive(true);
                this.gameObject.SetActive(false);
            }

        }

        else
        {
            musica.detener("Apagar");
            apagado = true;
        }
    }
}


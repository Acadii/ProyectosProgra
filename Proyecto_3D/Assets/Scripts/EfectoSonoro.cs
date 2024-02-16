using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(AudioSource))]

public class EfectoSonoro : MonoBehaviour
{
    public Efecto[] misEfectos;
    private AudioSource reproductor;

    void Start()
    {
        reproductor = GetComponent<AudioSource>();
    }
    public void reproducir(string accion)
    {
        foreach (Efecto e in misEfectos)
        {
            if (e.accion == accion)
            {
                reproductor.clip = e.sonido;
                reproductor.Play();

                return;
            }
        }


    }

    public void detener(string accion)
    {
        foreach (Efecto e in misEfectos)
        {
            if (e.accion == accion)
            {
                reproductor.clip = e.sonido;
                reproductor.Stop();

                return;
            }
        }

    }

        [Serializable]

    public class Efecto
    {
        public string accion;
        public AudioClip sonido;
    }


}


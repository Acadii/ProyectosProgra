using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoLateral : MonoBehaviour
{


    public float velocidadCaminar = 5;


    private Rigidbody MiCuerpo;
    private Animator MiAnimador;

    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody>();
        MiAnimador = GetComponent<Animator>();
    }


    void Update()
    {
        float movVert = Input.GetAxis("Horizontal");

        if (movVert > 0 )
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);

            MiCuerpo.velocity = new Vector3(0, 0, velocidadCaminar);

            MiAnimador.SetBool("Caminando", true);
        }
        else if (movVert < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);

            MiCuerpo.velocity = new Vector3(0, 0, -velocidadCaminar);
            MiAnimador.SetBool("Caminando", true);
        }
        else
        {
            MiCuerpo.velocity = new Vector3(0, 0, 0);
            MiAnimador.SetBool("Caminando", false);
        }
    }
}

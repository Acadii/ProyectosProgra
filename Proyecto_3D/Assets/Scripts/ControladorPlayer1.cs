using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPlayer1 : MonoBehaviour
{
    private Rigidbody Micuerpo;
    private Animator miAnimador;
    void Start()
    {
        Micuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            miAnimador.SetBool("Interactuando", true);
        }

        else
        {
            miAnimador.SetBool("Interactuando", false);
        }
    }
}

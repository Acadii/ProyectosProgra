using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoDireccional : MonoBehaviour
{
    public float velocidadMov;
    private Rigidbody miCuerpo;
    public float velocidad = 10;
    private Animator miAnimator;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnimator = GetComponent<Animator>();
    }


    void Update()
    {

        float movHoriz = Input.GetAxis("Horizontal");
        float movVert = Input.GetAxis("Vertical");
        Vector3 direccion = new Vector3(movHoriz, 0, movVert);

        if (movHoriz > 0)

        {
            transform.forward = direccion;
            miCuerpo.velocity = transform.forward * velocidad * direccion.magnitude;
            miAnimator.SetBool("Caminando", true);

        }
        else if (movHoriz < 0)
        {
            transform.forward = direccion;
            miCuerpo.velocity = transform.forward * velocidad * direccion.magnitude;
            miAnimator.SetBool("Caminando", true);
        }

            else if (movVert > 0)
        {
            transform.forward = direccion;
            miCuerpo.velocity = transform.forward * velocidad * direccion.magnitude;
            miAnimator.SetBool("Caminando", true);
        }

       else if (movVert < 0)
        {
            transform.forward = direccion;
            miCuerpo.velocity = transform.forward * velocidad * direccion.magnitude;
            miAnimator.SetBool("Caminando", true);
        }

        else
        {
            miAnimator.SetBool("Caminando", false);
        }

    }


}
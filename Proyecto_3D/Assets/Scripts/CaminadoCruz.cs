using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoCruz : MonoBehaviour
    //Declarar un atributo flotante para la velocidad
{
    private Rigidbody miCuerpo;
    private Animator miAnim;
    public float velocidadMov;


    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
        miAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Asignar velocidad al RB multiplicando el forward de este objeto por el Mov Frontal y sumando el Right de este objeto

        float movHoriz = Input.GetAxis("Horizontal");
        float movVert = Input.GetAxis("Vertical");


        Vector3 direccion = (transform.forward * movVert + transform.right * movHoriz).normalized;
         miCuerpo.velocity = direccion * velocidadMov;


        miAnim.SetFloat("Mov_Front", movVert);
        miAnim.SetFloat("Mov_Lateral", movHoriz);

        if (Input.GetButtonDown("Fire1"))
        {
            miAnim.SetBool("Interactuando", true);
        }

        else
        {
            miAnim.SetBool("Interactuando", false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoDireccional : MonoBehaviour
{
    public float velocidadMov;
    private Rigidbody miCuerpo;
    public float velocidad = 10;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
    }

   
    void Update()

        //Modificar para que use Lerp en vez de asignar directamente

    {
        float movHoriz = Input.GetAxis("Horizontal");
        float movVert = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(movHoriz, 0, movVert);

        transform.forward = direccion;

        miCuerpo.velocity = transform.forward * velocidad * direccion.magnitude;


    }
}

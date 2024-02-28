using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraIsometrica : MonoBehaviour
{
    private Rigidbody miCuerpo;
    public float velocidadMov;


    void Start()
    {
        miCuerpo = GetComponent<Rigidbody>();
    }

    void Update()
    {

        float movHoriz = Input.GetAxis("Horizontal");
        float movVert = Input.GetAxis("Vertical");


        Vector3 direccion = (transform.forward * movVert + transform.right * movHoriz).normalized;
        miCuerpo.velocity = direccion * velocidadMov;


    }

}

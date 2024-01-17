using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMouse : MonoBehaviour
{
    public float velocidadRotacion = 1;
    void Start()
    {
        
    }

    void Update()
    {
        float rotHoriz = Input.GetAxis("Mouse X");   // Leo el movimiento del mouse
        transform.Rotate(transform.up * rotHoriz * velocidadRotacion, Space.Self);  //Roto el objeto sobre su eje Y en relacion a si mismo, no al mundo
    }
}

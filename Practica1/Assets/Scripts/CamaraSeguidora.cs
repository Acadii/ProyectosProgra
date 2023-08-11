using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguidora : MonoBehaviour
{
    //Este es un atributo de la clase que funciona como referencia a la pelota de la escena
    public Transform Pelota;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        //Le coloco la posicion de la pelota a la camara, excepto en Z
    {
        transform.position =
            new Vector3(Pelota.position.x, Pelota.position.y, -1);
    }
}

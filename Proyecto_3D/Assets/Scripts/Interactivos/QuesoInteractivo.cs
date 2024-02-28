using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuesoInteractivo : ObjetoInteractuable
{

    public GameObject queso;
    public override void Activar()
    {
        Debug.Log("Comiendo Queso");
            queso.gameObject.SetActive(true);
            this.gameObject.SetActive(false);


    }


}

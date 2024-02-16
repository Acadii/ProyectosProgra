using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PuertaInteractivaAnimada : ObjetoInteractuable
{

    private Animator miAnim;

    void Start()
    {
     miAnim = GetComponent<Animator>();
    }



    public override void Activar()
    {
        miAnim.SetTrigger("Abrir");
    }
}

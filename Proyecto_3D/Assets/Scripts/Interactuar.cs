using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuar : MonoBehaviour
{
    private Animator miAnim;

    void Start()
    {
        miAnim = GetComponent<Animator>();      
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log("Haciendo Algo");
            miAnim.SetTrigger("Interactuando");
        }

    }
}

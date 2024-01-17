using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPlayer : MonoBehaviour
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
        float movHoriz = Input.GetAxis("Horizontal");
        float movVert = Input.GetAxis("Vertical");

        if (movHoriz != 0 || movVert !=0)
        {
            Vector3 direccion = (transform.forward * movVert + transform.right * movHoriz).normalized;
            miCuerpo.velocity = direccion * velocidadMov;
            miAnim.SetBool("Correr", true);
        }

        else
        {
            miCuerpo.velocity = new Vector3(0, 0, 0);
            miAnim.SetBool("Correr", false);
        }
    }
}

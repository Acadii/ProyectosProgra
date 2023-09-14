using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    public float velocidadCaminar = 3;
    public float fuerzaSalto = 3;
   


    void Start()
    {   //Al atributo MiCuerpo le asigno el componente Rigid Body 2D de este personaje
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
      
    }

    void Update()
    {
        float velActualVert = miCuerpo.velocity.y;

        //Leo si el jugador esta presionando un eje en horizontal
        float movHoriz = Input.GetAxis("Horizontal");
        if(movHoriz > 0)
        {                                   //El 3 es hardcore :(
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("Caminando", true);
        }

        else if (movHoriz < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("Caminando", true);
        }

        else
        {
            miCuerpo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("Caminando", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            miCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
        }

        miAnimador.SetFloat("Vel_Vert", velActualVert);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    private ReproductorSonido misSonidos;
    public float velocidadCaminar = 3;
    public float fuerzaSalto = 3;
    public bool enPiso;
    public int dobleSalto = 1;
    private Personaje miPersonaje;

    void Start()
    {   //Al atributo MiCuerpo le asigno el componente Rigid Body 2D de este personaje
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonido>();
        miPersonaje = GetComponent<Personaje>();
      
    }

    void Update()
    {

        if (enPiso == true)
        {
            dobleSalto = 1;
        }


        comprobarPiso();
 
        float velActualVert = miCuerpo.velocity.y;


        miAnimador.SetBool("EnPiso", enPiso);

        //Leo si el jugador esta presionando un eje en horizontal
        float movHoriz = Input.GetAxis("Horizontal");
        if(movHoriz > 0 && !miPersonaje.aturdido && !miPersonaje.morido)
        {                                   //El 3 es hardcore :(
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            miAnimador.SetBool("Caminando", true);
        }

        else if (movHoriz < 0 && !miPersonaje.aturdido && !miPersonaje.morido)
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

        if (Input.GetButtonDown("Jump") && !miPersonaje.aturdido && !miPersonaje.morido)

        {
            if (enPiso == true)
            {
                miCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
                dobleSalto = dobleSalto - 1;

                misSonidos.reproducir("Saltar");
            }

            else if (enPiso == false && dobleSalto > 0 )
            {
                miCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
                dobleSalto = dobleSalto - 1;
                misSonidos.reproducir("Saltar");
            }

        }

        if (Input.GetButtonDown("Fire1") && !miPersonaje.aturdido && !miPersonaje.morido)
        {
 
            miAnimador.SetTrigger("Atacar");
        }


        miAnimador.SetFloat("Vel_Vert", velActualVert);

    }
    void comprobarPiso()
    {
        enPiso = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
    }

}

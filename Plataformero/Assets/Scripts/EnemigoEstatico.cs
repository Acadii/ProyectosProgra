using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoEstatico : MonoBehaviour
{
    public float distanciaAgro = 5;
    public float distanciaAtaque = 5;
    public float velocidadHongo = 2;
    private GameObject heroe;
    public int puntosDanio = 10;
    private Animator miAnimador;
    private Rigidbody2D Cuerphongo;
    private PersonajeEnemigo miEnemigo;

    void Start()
    {
        heroe = GameObject.FindWithTag("Player");
        miAnimador = GetComponent<Animator>();
        Cuerphongo = GetComponent<Rigidbody2D>();
        miEnemigo = GetComponent<PersonajeEnemigo>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posHeroe = heroe.transform.position;
        Vector3 posYo = this.transform.position;

        float distancia = (posYo - posHeroe).magnitude;
        float velActualVert = Cuerphongo.velocity.y;

            if (distancia < distanciaAgro && !miEnemigo.aturdido && !miEnemigo.morido)
        {//El heroe esta dentro de la distancia de agro
            if (posHeroe.x > posYo.x)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                Cuerphongo.velocity = new Vector3(velocidadHongo, velActualVert, 0);
                miAnimador.SetBool("Caminando", true);
            }

            else
            {//El heroe esta a la izquierda
                transform.rotation = Quaternion.Euler(0, 180, 0);
                Cuerphongo.velocity = new Vector3(-velocidadHongo, velActualVert, 0);
                miAnimador.SetBool("Caminando", true);
            }

        }

        else
        {//El heroe esta fuera de la distancia de agro
            Cuerphongo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("Caminando", false);

        }

        if (distancia < distanciaAtaque && !miEnemigo.aturdido && !miEnemigo.morido)
        {
            Cuerphongo.velocity = new Vector3(-0, 0, 0);
            miAnimador.SetTrigger("Atacar");
            miAnimador.SetBool("Caminando", false);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(name + " hizo colision con " + collision.gameObject.name);

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            Personaje elPerso = otro.GetComponent<Personaje>();
            elPerso.matar();

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(name + " hizo colisión con " + collision.gameObject.name);

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player" && !miEnemigo.aturdido && !miEnemigo.morido)
        {
            //Accedo al componente de tipo Personaje del objeto con el que choque
            Personaje elPerso = otro.GetComponent<Personaje>();
            elPerso.recibirDanio(puntosDanio, this.gameObject);
        }

    }

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public int puntosAtaque = 30;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(name + " hizo colision con " + collision.gameObject.name);

        GameObject otro = collision.gameObject;
        if (otro.tag == "Enemie")
        {
            //Accedo al componente de tipo Personaje del objeto con el que choqué
            PersonajeEnemigo enemigo = otro.GetComponent<PersonajeEnemigo>();
            enemigo.recibirDanio(puntosAtaque, this.gameObject);
        }
    }

}

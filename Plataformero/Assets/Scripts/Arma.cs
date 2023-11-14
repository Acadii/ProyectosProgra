using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public int puntosAtaque = 30;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otro = collision.gameObject;
        print("Arma " + name + " colisiona con " + otro);
        if (otro.tag == "Enemie")
        {
            Personaje Hacha = otro.GetComponent<Personaje>();
            Hacha.hacerDanio(puntosAtaque, this.gameObject);
        }
    }
    

}

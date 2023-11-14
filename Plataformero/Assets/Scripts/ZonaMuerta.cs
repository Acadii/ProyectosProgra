using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerta : MonoBehaviour
{
    public GameObject splashAguaPrefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(name + " hizo colision con " + collision.gameObject.name);

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            Personaje elPerso = otro.GetComponent<Personaje>();
            elPerso.matar();

            GameObject efectoSplash = Instantiate(splashAguaPrefab);
            efectoSplash.transform.position = elPerso.transform.position;
        }
    }
}

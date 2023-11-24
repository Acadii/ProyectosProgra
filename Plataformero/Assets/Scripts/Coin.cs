using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private ReproductorSonido misSonidos;
    private Animator miAnimador;
    private BoxCollider2D colider;
    void Start()
    {
        misSonidos = GetComponent<ReproductorSonido>();
        miAnimador = GetComponent<Animator>();
        colider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Player")

        {
            misSonidos.reproducir("Moneda");
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(this.gameObject,1f);
        }

    }
}

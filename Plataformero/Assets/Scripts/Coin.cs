using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private ReproductorSonido misSonidos;
    private Animator miAnimador;

    void Start()
    {
        misSonidos = GetComponent<ReproductorSonido>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Player")

        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            misSonidos.reproducir("Moneda");
            Destroy(this.gameObject,1f);
        }

    }
}

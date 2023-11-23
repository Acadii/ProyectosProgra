using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private ReproductorSonido misSonidos;

    void Start()
    {
        misSonidos = GetComponent<ReproductorSonido>();
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
            Destroy(this.gameObject,1f);
        }

    }
}

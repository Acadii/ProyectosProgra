using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{

    private ReproductorSonido misSonidos;
    private Animator miAnimador;
    public int puntosDanio = 1;
    public float duracionVeneno = 5f;



    void Start()
    {
        misSonidos = GetComponent<ReproductorSonido>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator DanioVeneno(Personaje Cavernicola)

    {
        float tiempoPasado = 0f;

        while (tiempoPasado < duracionVeneno)

        {
            Cavernicola.recibirDanio(puntosDanio, this.gameObject);
            yield return new WaitForSeconds(1f);
            tiempoPasado += 1f;


        }

        Destroy(gameObject, 1f);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {

            Personaje elPerso = otro.GetComponent<Personaje>();
            StartCoroutine(DanioVeneno(elPerso));
        }
    }



}
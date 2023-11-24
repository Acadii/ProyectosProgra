using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosionVidas : MonoBehaviour
{

    private ReproductorSonido misSonidos;
    private Animator miAnimador;
    public int puntosVida = 1;
    public float duracionVidas = 1f;
    void Start()
    {
        misSonidos = GetComponent<ReproductorSonido>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator recibirVida(Personaje Cavernicola)

    {
        float tiempoPasado = 0f;

        while (tiempoPasado < duracionVidas)

        {
            Cavernicola.recibirVida(puntosVida, this.gameObject);
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
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            StartCoroutine(recibirVida(elPerso));
        }
    }

}

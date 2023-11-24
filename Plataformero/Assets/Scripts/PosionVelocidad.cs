using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosionVelocidad : MonoBehaviour
{

    private ReproductorSonido misSonidos;
    private Animator miAnimador;
    public float duracionVel = 8f;
    void Start()
    {
        misSonidos = GetComponent<ReproductorSonido>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator aumentarVel(ControladorJugador Cavernicola)

    {
        float tiempoPasado = 0f;

        while (tiempoPasado < duracionVel)

        {
            Cavernicola.aumentoVelocidad();
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

            ControladorJugador elPerso = otro.GetComponent<ControladorJugador>();
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            StartCoroutine(aumentarVel(elPerso));
        }
    }

}